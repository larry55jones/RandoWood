using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RandoWoodAPI.Test
{
    /// <summary>
    /// Controller for simple "are-we-up" tests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="logger"></param>
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Give a string, get a string
        /// </summary>
        /// <param name="input">String to return</param>
        /// <returns><paramref name="input"/></returns>
        [HttpGet]
        public string Test(string input)
        {
            _logger.LogInformation("Test endpoint called with {a}", input);
            return input;
        }
    }
}
