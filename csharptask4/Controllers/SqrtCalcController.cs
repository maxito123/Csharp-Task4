using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpTask4.Controllers
{

    public class SqrtCalcController : Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sqrt(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            double sqrtRes1 = Math.Sqrt(numberOne);
            double sqrtRes2 = Math.Sqrt(numberTwo);

            if (sqrtRes1 > sqrtRes2)
            {
                int result = 1;
            }
            else if (sqrtRes1 < sqrtRes2)
            {
                int result = 2;
            }
            else
            {
                int result = 0;
            }
            
            return View();
        }

    }
}