using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HangfireMVC.Models;
using System.Globalization;

namespace HangfireMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddJob()
        {
            //RecurringJob.AddOrUpdate(
            //    () => new Jobs().CreateFile()
            //    , Cron.Minutely);

            // 每天台灣時間下午3點39分執行
        //    RecurringJob.AddOrUpdate(() => new Jobs().CreateFile(), "39 15 * * *" , TimeZoneInfo.Local);

            // 每天台灣時間下午3點40分執行
            RecurringJob.AddOrUpdate(() => new Jobs().CreateFile2(), "40 15 * * *", TimeZoneInfo.Local);

            //每天上午12點與下午12點各執行一次
       //     RecurringJob.AddOrUpdate(() => new Jobs().CreateFile(), "0 0,12 * * *", TimeZoneInfo.Local);

            //每天上午5點  上午11點  下午15點  下午22點各執行一次
            RecurringJob.AddOrUpdate(() => new Jobs().CreateFile(), "0 5,11,15,22 * * *", TimeZoneInfo.Local);


            // 每天台灣時間下午3點10分執行,任務名稱是 ABC
            RecurringJob.AddOrUpdate("ABC", () => new Jobs().CreateFile(), "10 15 * * *", TimeZoneInfo.Local);

            //導向 http://loclahost/hangfire
            return Redirect("/hangfire");
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