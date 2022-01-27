using BIR.API.Models;
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

            new Animal(1,"M",10,"Name",120,"good"),
            new Lion(2,"m",7,"bear",200,"very good",true),
            new Bear(3,"f",15,"brownie",200,"good","brown bear"),
            new Tiger(3,"f",3,"tigri",180,"bad","bengal tiger"),
            new Deer(3,"f",3,"chopper",160,"very good",true)





        };






        private readonly ILogger<AnimalsController> _logger;


        public AnimalsController(ILogger<AnimalsController> logger)
        {
            _logger = logger;
            
        }

        [HttpGet]
        public List<Animal> Get()
        {
            return _animals;
        }

        [HttpGet("{id}", Name = "Get")]
        public Animal Get(int id)
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
        public IActionResult Delete(int id)
        {
            Animal animal = _animals.Find(f => f.Id == id);

            _animals.Remove(animal);

            return Ok(_animals);
        }

    }
}
