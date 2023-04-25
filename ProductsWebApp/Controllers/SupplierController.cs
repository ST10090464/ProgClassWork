using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsWebApp.Models;

namespace ProductsWebApp.Controllers
{
    public class SupplierController : Controller
    {
        List<Supplier> supplierList = new List<Supplier>();

        public SupplierController()
        {
            Populate();
        }

        public void Populate()
        {
            supplierList.Add(new Supplier("S123", "Pepkor", "0747195424"));
            supplierList.Add(new Supplier("S461","Clover", "0747195424"));
            supplierList.Add(new Supplier("S123", "Coca Cola", "0747195424"));
            supplierList.Add(new Supplier("S123", "Pepko", "0747195424"));
        }
        // GET: SupplierController
        public ActionResult AllSuppliers()
        {
           
            return View(supplierList);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerifyLogin()
        {

            string username = Request.Form["username"].ToString();
            string password = Request.Form["password"].ToString();

            Supplier sp = new Supplier("Phakeme", "12345");

            if (username.Equals(sp.Username) && password.Equals(sp.Password))
            {
                return RedirectToAction("AllSuppliers");
            }

            else 
            {
                return View("Login");
            }
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNew()
        {
            string supID = Request.Form["txtID"].ToString();
            string name = Request.Form["txtName"].ToString();
            string phone = Request.Form["txtPhone"].ToString();
            string username = Request.Form["txtUsername"].ToString();
            string password = Request.Form["txtPassword"].ToString();

            Supplier ss = new Supplier(supID, name, phone);
            ss.Username = username;
            ss.Password = password;

            supplierList.Add(ss);
            return View("AllSuppliers", supplierList);
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            string supID = collection["txtID"].ToString();
            string name = collection["txtName"].ToString();
            string phone = collection["txtPhone"].ToString();
            string username = collection["txtUsername"].ToString();
            string password = collection["txtPassword"].ToString();

            Supplier sp = new Supplier(supID, name, phone);
            sp.Username = username;
            sp.Password = password;

            supplierList.Add(sp);
            return View("AllSuppliers", supplierList);

        }

        // GET: SupplierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupplierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
