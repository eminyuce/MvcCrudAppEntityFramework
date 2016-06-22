using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using PagedList;
using TestApp.Entities;
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

        public ActionResult SaveOrUpdateProduct(int id = 0)
        {
            Product p = new Product();
            if (id > 0)
            {
                p = ProductRepository.GetSingle(id);
            }

            return View(p);
        }
        [HttpPost]
        public ActionResult SaveOrUpdateProduct(Product product)
        {
            if (product.Id > 0)
            {
                ProductRepository.Edit(product);
            }
            else
            {

                ProductRepository.Add(product);
            }
            ProductRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult ProductDetail(int id)
        {
            var p = ProductRepository.GetSingle(id);
            return View(p);
        }

        public ActionResult DeleteProduct(int id)
        {
            ProductRepository.Delete(r => r.Id == id);
            ProductRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult ListDisplay()
        {
            return View(ProductRepository.GetAll().ToList());
        }
        public ActionResult ProductPaging(int ? page)
        {
            // return a 404 if user browses to before the first page
            if (page.HasValue && page < 1)
            {
                page = 1;
            }

            // retrieve list from database/whereverand
            var listUnpaged = ProductRepository.GetAll();

            // page the list
            const int pageSize = 20;
            var listPaged = listUnpaged.ToPagedList(page ?? 1, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;

            return View(listPaged);
        }
    }
    
}
