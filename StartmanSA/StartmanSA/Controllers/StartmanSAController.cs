using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace StartmanSA.Controllers
{
    public class StartmanSAController : Controller
    {
        // 
        // GET: /StartmanSA/

        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /StartmanSA/Welcome/ 

        public IActionResult Privacy()
        {
            return View();
        }

    }
}