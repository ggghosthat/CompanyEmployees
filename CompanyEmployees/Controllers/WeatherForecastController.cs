using System.Collections.Generic;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;
        private readonly IRepositoryManager _repositoryManager;

        public WeatherForecastController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_logger.LogInfo("This is an info log from Weather Forecast Controller");
            //_logger.LogDebug("This is a debug log from Weather Forecast Controller");
            //_logger.LogWarn("This is a warn log from Weather Forecast Controller");
            //_logger.LogError("This is an error log from Weather Forecast Controller");


            return new string [] { "value1","value2"};
        }
    }
}