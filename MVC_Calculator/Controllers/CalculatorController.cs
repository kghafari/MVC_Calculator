using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(int num1, int num2, string operation)
        {
            int result = 0;
            if (operation == "addition")
            {
                result = num1 + num2;
            }
            else if (operation == "subtraction")
            {
                result = num1 - num2;
            }
            else if (operation == "multiplication")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            return View("DisplayResult", result);
        }

        public IActionResult DisplayResult()
        {
            return View();
        }
    }
}