using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Model;
using WebApplication4.Services.Implementations;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {


        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());

        }


        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();

            return Ok(_personService.FindById(id));

        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));

        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(_personService.Delete(id));


        }
    }
}


