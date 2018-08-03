using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CustomerMVC.Models;


namespace CustomerMVC.Controllers
{
    public class OCCRUDController : Controller
    {
        MVCProjectEntities db = new MVCProjectEntities();




        // GET: OCCRUD
        [HttpGet]
        public ActionResult AddOrder()
        {
            var data = new SelectList(db.tbl_customer, "customerID", "customerName");
            Session["rsdata"] = data;
            return View();

        }
        [HttpPost]
        public ActionResult AddOrder(tbl_order order)
        {
            order.productName = Request.Form["txtname"].ToString();
            order.price = int.Parse(Request.Form["txtprice"].ToString());
            //string name= Request.Form["ddlCustomer"].ToString();
            //var n = db.tbl_customer.Where(x => x.customerName == name) ;


            order.customerId = int.Parse(Request.Form["ddlCustomer"].ToString());

            db.tbl_order.Add(order);
            var result = db.SaveChanges();
            if (result > 0)
                ModelState.AddModelError("", "Data Inserted");
            return View();
        }

        [HttpGet]
        public ActionResult SelectCustomer()
        {
            var data = new SelectList(db.tbl_customer, "customerId", "customerName");
            Session["Data1"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult SelectCustomer(string command)
        {
            if (command == "Search")
            {
                int custid = int.Parse(Request.Form["ddlcustomer"].ToString());

                var data = (db.tbl_order.Where(x => x.customerId == custid)).ToList();

                Session["pdata"] = data;
                return View();
            }
            return View();
        }

        [HttpGet]
        public ActionResult ChangeOrderPrice(int id)
        {

            var data = db.tbl_order.Where(x => x.OrderId == id).SingleOrDefault();
            Session["Data3"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult ChangeOrderPrice()
        {
            int id = int.Parse(Request.Form["txtid"].ToString());
            var olddata = db.tbl_order.Where(x => x.OrderId == id).SingleOrDefault();
            olddata.price = Decimal.Parse(Request.Form["price"].ToString());


            var res = db.SaveChanges();
            if (res > 0)
            {

                return RedirectToAction("SelectCustomer");
            }

            else
                return View();
        }

        [HttpGet]
        public ActionResult GetOrderByID()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetOrderByID(string command)
        {
            int custid = int.Parse(Request.Form["txtid"].ToString());
            if (command == "Search")
            {
                var data = (from t in db.tbl_order
                            where t.customerId == custid
                            select t).ToList();
                Session["pdata"] = data;
                return View();
            }
            return View();
        }
    }
}
