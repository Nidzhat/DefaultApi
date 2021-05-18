using System;

namespace DefaultApi.Models
{
    public class WeatherInfo
    {
        public int Id { get; set; }
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }

        public WeatherTypes WeatherType { get; set; }
    }
}
