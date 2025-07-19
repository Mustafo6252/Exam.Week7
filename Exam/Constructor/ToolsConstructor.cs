
// -----------------------------  1- bo'lim ------------------------------------

using Microsoft.AspNetCore.Mvc;


namespace HomeTask2.Controllers
{
    [ApiController]
    [Route("api/Tools")]
    public class ToolsController : Controller
    {
        [HttpGet("Random")]
        public IActionResult GetRandomNumber()
        {
            int number = new Random().Next(1, 100);
            return Ok(number);
        }

        [HttpGet("greet")]
        public async Task<IActionResult> GetGreet([FromQuery] string name)
        {
            await Task.Delay(2000);
            return Ok($"Salom, {name}");
        }

        [HttpGet("today")]
        public IActionResult GetToday()
        {
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            return Ok(today);
        }

        [HttpGet("length")]
        public IActionResult GetLength([FromQuery] string text)
        {
            int length = text.Length;
            return Ok(length);
        }

        [HttpGet("sqrt")]
        public IActionResult GetSqrt([FromQuery] int value)
        {
            double result = Math.Sqrt(value);
            return Ok(result);
        }

    }
}