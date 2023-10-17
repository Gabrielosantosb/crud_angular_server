using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
       

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum( string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber)){
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber) 
        { 
        
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber)){
                var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(div.ToString()); 
            }
            return BadRequest("Invalid Input");
   
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]

        public IActionResult Med(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var med = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok("Media: "+ med.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult Multi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)){
                var multi = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok("Multiplicacao: " + multi.ToString());
            }
            return BadRequest("Invalid Input");
        }
        [HttpGet("square/{firstNumber}")]
        public IActionResult Square(string firstNumber) 
        {
            if (IsNumeric(firstNumber))
            {
                var square = Math.Sqrt(((double)ConvertToDecimal(firstNumber)));
                return Ok("Raiz Quadrada: " + square.ToString());
            }
            return BadRequest("Invalid Input");

        }


        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;

        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;

        }

    }
}
