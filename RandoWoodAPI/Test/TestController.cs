using Microsoft.AspNetCore.Mvc;

namespace RandoWoodAPI.Test
{
    /// <summary>
    /// Controller for simple "are-we-up" tests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Give a string, get a string
        /// </summary>
        /// <param name="input">String to return</param>
        /// <returns><paramref name="input"/></returns>
        [HttpGet]
        public string Test(string input)
        {
            return input;
        }
    }
}
