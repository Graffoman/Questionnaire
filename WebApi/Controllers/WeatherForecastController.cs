using Microsoft.AspNetCore.Mvc;
using Infrastructure.DataAcess;
using Domain.Entities.BaseClasses;
using Domain.Entities;
using MongoDB.Driver;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MongoDB<Question> _db;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MongoDB<Question> db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Question> Get()
        {
            Console.WriteLine();
            var quest = new QuestionIntRange()
            {
                QuestionText = "Выбери Range еще и еще",
                IsOptional = true,
                Type = Domain.Entities.Enums.QuestionType.IntRange,
                Answer = new IntRange(10, 50),
            };

            _db.Collection.InsertOne(quest);

            var test = _db.Collection.AsQueryable().ToList();

            Console.WriteLine();

            return test;
        }


    }
}
