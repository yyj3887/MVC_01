using MVC_01_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_01_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IssueAct _issue = new IssueAct();
            var data = _issue.GetIssue();
            return View(data);
        }
    }
}