using System;
using Microsoft.AspNetCore.Mvc;

namespace sqrtCalcWeb.Controllers
{
    public class CalcController : Controller
    {
        public static bool isNumeric(string s)
        {
            return double.TryParse(s, out double n);
        }     

        [HttpGet]
        public IActionResult SqrtCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SqrtCalc(string num1, string num2)
        {
            double firNum, secNum, sqrtFirNum, sqrtSecNum;

            // int num11 = Convert.ToInt32(isNumeric(num1));
            // int num22 = Convert.ToInt32(isNumeric(num2));

            //     ViewBag.num11 = num11;
            //     sqrtFirNum = Math.Sqrt(num11);
            //     ViewBag.num22 = num22;
            //     sqrtSecNum = Math.Sqrt(num22);
            //     ViewBag.sqrtFirNum = sqrtFirNum;
            //     ViewBag.sqrtSecNum = sqrtSecNum;

            if (isNumeric(num1) && isNumeric(num2))
            {
                firNum = double.Parse(num1);
                ViewBag.firNum = firNum;
                sqrtFirNum = Math.Sqrt(firNum);
                secNum = double.Parse(num2);
                ViewBag.secNum = secNum;
                sqrtSecNum = Math.Sqrt(secNum);
                ViewBag.sqrtFirNum = sqrtFirNum;
                ViewBag.sqrtSecNum = sqrtSecNum;
            }
            else
            {
                string err ="Enter a valid number!";
                ViewBag.err1 = err;
            }
            return View();
        }
    }
}