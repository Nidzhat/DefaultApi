using System;
using System.Collections.Generic;
using System.Linq;
using DefaultApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DefaultApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static List<WeatherInfo> weatherInfoList =
            new List<WeatherInfo>
            {
                new WeatherInfo {
                    Id = 1,
                    City = "Astana",
                    Date = DateTime.Today,
                    MaxTemp = 38,
                    MinTemp = 35,
                    WeatherType = WeatherTypes.Cloudy
                },
                new WeatherInfo {
                    Id = 2,
                    City = "Almaty",
                    Date = DateTime.Today.AddDays(1),
                    MaxTemp = 26,
                    MinTemp = 15,
                    WeatherType = WeatherTypes.Rain
                }

            };

        [HttpGet]
        public IEnumerable<WeatherInfo> Get()
        {
            return weatherInfoList;
        }

        [HttpGet("{Id}")]
        public WeatherInfo Get(int Id) {
            return weatherInfoList.FirstOrDefault(wi => wi.Id == Id);
        }

    }
}
