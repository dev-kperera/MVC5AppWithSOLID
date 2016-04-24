using Contracts;
using DAL.Data;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        //Inherit the Repository base

        //Contructor implements Repository base
        public ProductRepository(DataContext context)
            : base(context)
        {

            //Check for context is defined
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
        }




        #region Uncomment this section if you need to implement Repository from the scratch
        ////Data access context 
        //internal DataContext context;

        ///// <summary>
        ///// Repository Constructor
        ///// </summary>
        ///// <param name="context"></param>
        //public ProductRepository(DataContext context)
        //{
        //    this.context = context;
        //}

        ///// <summary>
        ///// Return all
        ///// </summary>
        ///// <returns>List</returns>
        //public virtual IEnumerable<Product> GetProducts()
        //{
        //    return context.Products.ToList();
        //}

        ///// <summary>
        ///// Find by ID
        ///// </summary>
        ///// <param name="id">ID of item</param>
        ///// <returns></returns>
        //public virtual Product GetStudentByID(int id)
        //{
        //    return context.Products.Find(id);
        //}

        ///// <summary>
        ///// Inserts
        ///// </summary>
        ///// <param name="student"></param>
        //public virtual void InsertProduct(Product entity)
        //{
        //    context.Products.Add(entity);
        //}

        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="poductID"></param>
        //public virtual void DeleteProduct(Product entity)
        //{
        //    //Uncomment below for delete by ID and pass entityID(int) for it 
        //    //Product entity = context.Products.Find(entityID);

        //    //Deleting by passing entity
        //    if (context.Entry(entity).State == EntityState.Detached)
        //        context.Products.Attach(entity);

        //    //remove item
        //    context.Products.Remove(entity);
        //}

        ///// <summary>
        ///// Update 
        ///// </summary>
        ///// <param name="product"></param>
        //public virtual void UpdateStudent(Product entity)
        //{
        //    context.Products.Attach(entity);
        //    context.Entry(entity).State = EntityState.Modified;
        //}

        ///// <summary>
        ///// Save Changes
        ///// </summary>
        //public virtual void Save()
        //{
        //    context.SaveChanges();
        //}

        //#region Disposal of Objects

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        //#endregion
        #endregion
    }
}
