using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using TestApp.Repositories.IRepositories;

namespace TestApp.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        [Inject]
        public IProductRepository ProductRepository { get; set; }

        public ActionResult Index()
        {
            return View(ProductRepository.GetAll().ToList());
        }

    }
}
