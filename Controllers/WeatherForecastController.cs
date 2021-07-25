using Microsoft.AspNetCore.Mvc;
using RazorPdfTask.Models;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPdfTask.Controllers
{
    public class WeatherForecastController : Controller
    {
        public IActionResult Index()
        {
            List<Weather> objweathers = new List<Weather>();

            for (int i = 0; i < 5; i++)
            {

                Weather weathers = new Weather();
                weathers.Date = DateTime.Now.AddDays(i);
                weathers.TemperatureC = 21 + i;
                weathers.TemperatureF = 32 + (int)(i / 0.5556);
                weathers.Summary = "Test Satyam";

                objweathers.Add(weathers);
            }
            return new ViewAsPdf(objweathers);
        }
   
    }
}
