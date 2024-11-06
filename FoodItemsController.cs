using eateryonline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace eateryonline.Web.Controllers
{
   
        public class FoodItemsController : Controller
        {
            private readonly ApplicationDbContext _context;

            public FoodItemsController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
            var foodItems = _context.FoodItems.ToList(); // Fetch items from the database
            return View(foodItems); // Pass items to the view
                                    /* List<FoodItem> foodItems = _context.FoodItems.ToList();
            return View(foodItems);*/
            }
        }
    }


