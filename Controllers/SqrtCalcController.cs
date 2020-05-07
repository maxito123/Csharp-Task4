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

            int result = 0;
            double higherSqrt = 0;
            double lowerSqrt = 0;
            int higherNo = 0;
            int lowerNo = 0;
            if (sqrtRes1 > sqrtRes2)
            {
                result = 1;
                higherSqrt = sqrtRes1;
                lowerSqrt = sqrtRes2;
                higherNo = numberOne;
                lowerNo = numberTwo;


            }
            else if (sqrtRes1 < sqrtRes2)
            {
                result = 2;
                higherSqrt = sqrtRes2;
                lowerSqrt = sqrtRes1;
                 higherNo = numberTwo;
                lowerNo = numberOne;
            }
            else
            {
                result = 3;

            }
            ViewBag.Result = result;
            ViewBag.HigherSqrt = higherSqrt;
            ViewBag.LowerSqrt = lowerSqrt;
            ViewBag.HigherNo = higherNo;
            ViewBag.LowerNo = lowerNo;
            return View();
        }
        
    }
}