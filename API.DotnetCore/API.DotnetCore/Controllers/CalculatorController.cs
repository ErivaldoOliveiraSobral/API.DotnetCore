using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.DotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/sum/5/5
        [HttpGet("sum/{x}/{y}")]
        public ActionResult Sum(string x, string y)
        {
            try
            {
                Int32.TryParse(x, out int xInt);
                Int32.TryParse(y, out int yInt);
                return Ok((xInt + yInt).ToString());
            }
            catch
            {
                return BadRequest("Valor inválido!");
            }
        }
        // GET api/calculator/sub/5/5
        [HttpGet("sub/{x}/{y}")]
        public ActionResult Sub(string x, string y)
        {
            try
            {
                Int32.TryParse(x, out int xInt);
                Int32.TryParse(y, out int yInt);
                return Ok((xInt - yInt).ToString());
            }
            catch
            {
                return BadRequest("Valor inválido!");
            }
        }
    }
}
