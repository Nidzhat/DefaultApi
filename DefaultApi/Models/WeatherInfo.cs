using System;

namespace DefaultApi.Models
{
    public class WeatherInfo
    {
        public int Id { get; set; }
        public int maxTemp { get; set; }
        public int minTemp { get; set; }
        public string city { get; set; }
        public DateTime date { get; set; }

        public WeatherTypes WeatherType { get; set; }
    }
}
