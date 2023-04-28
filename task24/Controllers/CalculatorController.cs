using Microsoft.AspNetCore.Mvc;

namespace task24.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet("add")]
        public async Task<ActionResult<int>> Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        [HttpGet("multiply")]
        public async Task<ActionResult<int>> Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
