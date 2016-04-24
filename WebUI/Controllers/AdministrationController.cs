using Contracts;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class AdministrationController : Controller
    {

        IRepositoryBase<Customer> _customers;
        IRepositoryBase<Product> _products;
        //Constructor
        public AdministrationController(IRepositoryBase<Customer> customers,IRepositoryBase<Product> products)
        {
            _customers = customers;
            _products = products;
        }

        // GET: Administration
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Lists products
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductsList()
        {
            // get all products and pass to view
            var model = _products.GetAll();
            return View(model);
        }
 
        public ActionResult CreateProduct()
        {
            //Create new Product
            var model = new Product();
            return View(model);
        }
    }
}