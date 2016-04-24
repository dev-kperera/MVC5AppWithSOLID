using Contracts;
/*
 Licence MIT
 * Author Kushan Lahiru Perera
 * @kushanlahiru
 */
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    /// <summary>
    /// Usage: 
    /// Implement the Repositoty base in your repository class with 
    /// Constructor implementation
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        //Data access context 
        internal DataContext context;
        //Database set
        internal DbSet<TEntity> dbset;

        /// <summary>
        /// Repository Constructor
        /// </summary>
        /// <param name="context">Data context</param>
        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        /// <summary>
        /// Return all
        /// </summary>
        /// <returns>List</returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            return dbset;
        }

        /// <summary>
        /// Find by ID
        /// </summary>
        /// <param name="id">ID of item</param>
        /// <returns></returns>
        public virtual TEntity GetByID(object id)
        {
            return dbset.Find(id);
        }

        /// <summary>
        /// Inserts
        /// </summary>
        /// <param name="student"></param>
        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="poductID"></param>
        public virtual void Delete(TEntity entity)
        {
            //Deleting by passing entity
            if (context.Entry(entity).State == EntityState.Detached)
                dbset.Attach(entity);

            //remove item
            dbset.Remove(entity);
        }

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="product"></param>
        public virtual void Update(TEntity entity)
        {
            dbset.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Save Changes
        /// </summary>
        public virtual void Save()
        {
            context.SaveChanges();
        }

        #region Disposal of Objects

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
