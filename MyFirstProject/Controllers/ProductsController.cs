using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h2>Products</h2>","text/html");
        }

        [Route("Products/Manage/{id:int}/{todo}")]
        public IActionResult Manage(int id,string toDo)
        {
            return Content($"Action:{toDo} product" +
                $"with id: {id}");
        }
    }
}
