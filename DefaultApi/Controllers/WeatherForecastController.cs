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
                    city = "Astana",
                    date = DateTime.Today,
                    maxTemp = 38,
                    minTemp = 35,
                    WeatherType = WeatherTypes.Cloudy
                },
                new WeatherInfo {
                    Id = 2,
                    city = "Almaty",
                    date = DateTime.Today.AddDays(1),
                    maxTemp = 26,
                    minTemp = 15,
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
