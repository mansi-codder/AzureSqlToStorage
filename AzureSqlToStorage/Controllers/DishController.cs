using AzureSqlToStorage.Models;
using AzureSqlToStorage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSqlToStorage.Controllers
{
    public class DishController : Controller
    {
        private readonly DishService _dishService;

        public DishController(DishService dishService)
        {
            _dishService = dishService;
        }

        public IActionResult Index()
        {
            IEnumerable<Dish> _dish_list = _dishService.GetDishes();
            return View(_dish_list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
