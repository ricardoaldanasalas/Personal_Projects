using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxForecast.Models;

namespace TaxForecast.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12?  hour + "Good Morning" : hour + "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult UserInfo()
        {
            return View();
        }
        [HttpPost]
        public ViewResult UserInfo(NewUserInput newUserInput)
        {
            if (ModelState.IsValid)
            {
                NewRepository.AddResponse(newUserInput);
                return View("Thanks", newUserInput);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult NewW2Form()
        {
            return View(NewRepository.Responses);
        }

        [HttpGet]
        public ViewResult Currentuser()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Currentuser(loginPortal login)
        {
            if (ModelState.IsValid)
            {
                ExistingRepository.AddResponse(login);
                return View("Thanks2", login);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        public ViewResult W2Form()
        {
            return View(ExistingRepository.Responses);
        }
    }
}
