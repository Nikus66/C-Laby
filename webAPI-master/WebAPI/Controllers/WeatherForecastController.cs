using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI;
using WebAPI.Context;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ApiContext _apiContext;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApiContext apiContext)
        {
            _logger = logger;
            _apiContext = apiContext;
        }

        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _apiContext.WeatherForecasts.ToList();
        }
        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetAll()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult Prod(int number1, int number2)
        {
            return Ok(number1 / number2);
        }

        [HttpPost]
        public IActionResult Qote(int number1, int number2)
        {
            return Ok(number1 * number2);
        }

        [HttpGet]
        public IActionResult GetSummary(int number)
        {
            return Ok(Summaries[number]);
        }

        [HttpPost]
        public IActionResult PostSummary(string text)
        {
            Summaries = Summaries.Append(text).ToArray();
            return Ok(Summaries.ToArray());
        }
        [HttpPost]
        public WeatherForecast AddForecast(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Add(data);
            _apiContext.SaveChanges();
            return result.Entity;
        }
        [HttpDelete]
        public void DeleteForecast(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Remove(data);
            _apiContext.SaveChanges();
        }
        [HttpDelete]
        public IActionResult DeleteSummary(int number)
        {
            List<string> SummariesList = Summaries.ToList();
            SummariesList.RemoveAt(number);
            Summaries = SummariesList.ToArray();
            return Ok(Summaries);
        }

        [HttpPut]
        public IActionResult UpdateSummary(int number, string text)
        {
            Summaries[number] = text;
            return Ok(Summaries);
        }
    }
}
