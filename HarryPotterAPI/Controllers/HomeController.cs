using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HarryPotterAPI.Models;

namespace HarryPotterAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SortGryffindor(bool sort)
        {
            var request = new Generator();
            var response = request.RetrieveGryffindors();
            if (sort)
            {
                var result = response.OrderBy(n => n.Name);
                return Json(result);
            }
            else
            {
                var result = response;
                return Json(result);
            }

        }

        public IActionResult SortSlytherin(bool sort)
        {
            var request = new Generator();
            var response = request.RetrieveSlytherins();
            if (sort)
            {
                var result = response.OrderBy(n => n.Name);
                return Json(result);
            }
            else
            {
                var result = response;
                return Json(result);
            }

        }

        public IActionResult SortHufflepuff(bool sort)
        {
            var request = new Generator();
            var response = request.RetrieveHufflepuffs();
            if (sort)
            {
                var result = response.OrderBy(n => n.Name);
                return Json(result);
            }
            else
            {
                var result = response;
                return Json(result);
            }

        }

        public IActionResult SortRavenclaw(bool sort)
        {
            var request = new Generator();
            var response = request.RetrieveRavenclaws();
            if (sort)
            {
                var result = response.OrderBy(n => n.Name);
                return Json(result);
            }
            else
            {
                var result = response;
                return Json(result);
            }

        }

        public IActionResult Gryffindor(bool id)
        {
            var request = new Generator();
            var response = request.RetrieveGryffindors();


            var result = id 
                ? response.Where(n => n.House == "Gryffindor" && n.Gender == "female")
                : response.Where(n => n.House == "Gryffindor")
            ;
            
            return Json(result);

        }

        public IActionResult Slytherin(bool id)
        {
            var a = id;

            var request = new Generator();
            var response = request.RetrieveSlytherins();


            var result = id
                ? response.Where(n => n.House == "Slytherin" && n.Gender == "female")
                : response.Where(n => n.House == "Slytherin")
            ;

            return Json(result);
        }

        public IActionResult Hufflepuff(bool id)
        {
            var a = id;

            var request = new Generator();
            var response = request.RetrieveHufflepuffs();


            var result = id
                ? response.Where(n => n.House == "Hufflepuff" && n.Gender == "female")
                : response.Where(n => n.House == "Hufflepuff")
            ;

            return Json(result);
        }

        public IActionResult Ravenclaw(bool id)
        {
            var a = id;

            var request = new Generator();
            var response = request.RetrieveRavenclaws();


            var result = id
                ? response.Where(n => n.House == "Ravenclaw" && n.Gender == "female")
                : response.Where(n => n.House == "Ravenclaw")
            ;

            return Json(result);
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
