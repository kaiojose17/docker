using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        private string message;

        public HomeController(IRepository repository, IConfiguration config)
        {
            this._repository = repository;
            this.message = config["MESSAGE"] ?? "ASP NET Core MVC - Docker";

            
        }

        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(this._repository.Produtos);
        }
    }
}
