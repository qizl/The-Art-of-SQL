using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheArtofSQL.Models;

namespace TheArtofSQL.Controllers
{
    public class HomeController : Controller
    {
        private TAOSDBContext _db = new TAOSDBContext("TAOSDBContext");
        private TAOSDBContext _db1 = new TAOSDBContext("TAOSDBContext1");

        public ActionResult Index()
        {
            var files = this._db.Files.ToList();

            var filesOnly = this._db.Database.SqlQuery<File>("SELECT * FROM FILES").ToList();

            var f = this._db.Database.SqlQuery<int>("SELECT DBO.FTEST(@P0)", 1).First();

            var p = this._db.Database.SqlQuery<File>("EXEC PTEST").ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}