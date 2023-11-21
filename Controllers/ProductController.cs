using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQL_TESTBL;

namespace TEST.Controllers
{
    public class ProductController : Controller
    {
        SQL_TESTClassBL sql_test = new SQL_TESTClassBL();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSearchProductByIDResult(int prodID)
        {
            var _data = sql_test.GetSearchProductByIDResult(prodID);
            return Json(
                new { data = _data},
                JsonRequestBehavior.AllowGet
                );
        }

        public void AddTransactions(
         string ProdName, 
         decimal Cost, 
         int Qty
         )
        {
            sql_test.AddTransactions(ProdName, Cost, Qty);
        }
    }
}