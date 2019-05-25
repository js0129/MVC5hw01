using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5hw.Models;

namespace MVC5hw.Content
{
    public class CountController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: Count
        public ActionResult Index()
        {
            return View(db.Vw_客戶相關數量.ToList());
        }
    }
}