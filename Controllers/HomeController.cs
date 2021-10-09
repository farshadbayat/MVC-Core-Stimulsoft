using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkcgIvwL0jnpsDqRpWg5FI5kt2G7A0tYIcUygBh1sPs7koivWV0htru4Pn2682yhdY3 + 9jxMCVTKcKAjiEjgJzqXgLFCpe62hxJ7 / VJZ9Hq5l39md0pyydqd5Dc1fSWhCtYqC042BVmGNkukYJQN0ufCozjA / qsNxzNMyEql26oHE6wWE77pHutroj + tKfOO1skJ52cbZklqPm8OiH / 9mfU4rrkLffOhDQFnIxxhzhr2BL5pDFFCZ7axXX12y / 4qzn5QLPBn1AVLo3NVrSmJB2KiwGwR4RL4RsYVxGScsYoCZbwqK2YrdbPHP0t5vOiLjBQ + Oy6F4rNtDYHn7SNMpthfkYiRoOibqDkPaX + RyCany0Z + uz8bzAg0oprJEn6qpkQ56WMEppdMJ9 / CBnEbTFwn1s / 9s8kYsmXCvtI4iQcz + RkUWspLcBzlmj0lJXWjTKMRZz + e9PmY11Au16wOnBU3NHvRc9T / Zk0YFh439GKd / fRwQrk8nJevYU65ENdAOqiP5po7Vnhif5FCiHRpxgF";


            _logger = logger;
        }

        public IActionResult Index()
        {
            //string testCase = "Jaber is good boy and will go with other friend with name jaber so jaber is good name.";
            //var ls = testCase.ToLower().Split(" ").ToList();
            //var res = ls.GroupBy(c => c).Max(c=>c.Key.( r => r.));
            //// ls.Sort();

            //Dictionary<string, int> countWord = new Dictionary<string, int>();
            //foreach (var item in ls)
            //{
            //    if (countWord.ContainsKey(item))
            //    {
            //        countWord[item]++;
            //    } else
            //    {
            //        countWord[item] = 1;
            //    }
            //}
            //int maxWordCount = countWord[ls[0]];

            //// List<string> ls = new List<string>() { "st3", "st1", "st1", "st2" };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetReport()
        {
            StiReport report = new StiReport();
            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public IActionResult ViewerEvent()
        {            
            return StiNetCoreViewer.ViewerEventResult(this);
        }

    }
}
