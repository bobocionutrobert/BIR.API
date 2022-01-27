using BIR.API.Models;
using BIR.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnimalsController : ControllerBase
    {

        List<Animal> _animals = new List<Animal>()
        {

            

        };

        private readonly ILogger<IAnimalService> _logger;


        public AnimalsController(ILogger<IAnimalService> logger)
        {
            _logger = logger;

        }

        [HttpGet]
        public List<Animal> Get()
        {
            return _animals;
        }

        [HttpGet("{id}", Name = "Get")]
        public Animal Get(Guid id)
        {
            Animal animal = _animals.Find(f => f.Id == id);
            return animal;
        }

        [HttpGet("name/{name}")]

        public IActionResult GetByName([FromRoute] string name)
        {
            Animal animal = _animals.Find(f => f.Name == name);

            return Ok(animal);
        }

        [HttpGet("type/{typeValue}")]

        public IActionResult GetByType([FromRoute] string typeValue)
        {
            if(typeValue == "Lion")
            {
                return Ok(this._animals.Where(_animals => _animals is Lion));
            }
            else if(typeValue == "Tiger")
            {
                return Ok(this._animals.Where(_animals => _animals is Tiger));
            }
            else if( typeValue == "Bear")
            {
                return Ok(this._animals.Where(_animals => _animals is Bear));
            }
            else if ( typeValue == "Deer")
            {
               return Ok(this._animals.Where(_animals => _animals is Deer));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Tiger")]

        public IActionResult GetTiger([FromRoute] string type)
        {
            return Ok(this._animals.Where(_animals => _animals is Tiger));

        }
        [HttpGet("Lion")]
        public IActionResult GetLion([FromRoute] string type)
        {
            return Ok(this._animals.Where(_animals => _animals is Lion));

        }

        [HttpGet("Bear")]
        public IActionResult GetBear([FromRoute] string type)
        {
            return Ok(this._animals.Where(_animals => _animals is Bear));

        }

        [HttpGet("Deer")]
        public IActionResult GetDeer([FromRoute] string type)
        {
            return Ok(this._animals.Where(_animals => _animals is Deer));

        }


        [HttpPost("Animals")]
        public IActionResult Post([FromBody] Animal animal)
        {
            _animals.Add(animal);
            return Ok(_animals);
        }


        [HttpPost("Lions")]
        public IActionResult Post([FromBody] Lion lion)
        {
            _animals.Add(lion);
            return Ok();
        }


        [HttpPost("Tigers")]
        public IActionResult Post([FromBody] Tiger tiger)
        {
            _animals.Add(tiger);
            return Ok();
        }


        [HttpPost("Bears")]
        public IActionResult Post([FromBody] Bear bear)
        {
            _animals.Add(bear);
            return Ok();
        }


        [HttpPost("Deers")]
        public IActionResult Post([FromBody] Deer deer)
        {
            _animals.Add(deer);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Animal animal = _animals.Find(f => f.Id == id);

            _animals.Remove(animal);

            return Ok(_animals);
        }


    
    }
}
