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

        [HttpPost("Animals")]
        public List<Animal> Post([FromBody] Animal animal)
        {
            _animals.Add(animal);
            return _animals;
        }


        [HttpPost("Lions")]
        public List<Animal> Post([FromBody] Lion lion)
        {
            _animals.Add(lion);
            return _animals;
        }


        [HttpPost("Tigers")]
        public List<Animal> Post([FromBody] Tiger tiger)
        {
            _animals.Add(tiger);
            return _animals;
        }


        [HttpPost("Bears")]
        public List<Animal> Post([FromBody] Bear bear)
        {
            _animals.Add(bear);
            return _animals;
        }


        [HttpPost("Deers")]
        public List<Animal> Post([FromBody] Deer deer)
        {
            _animals.Add(deer);
            return _animals;
        }


        [HttpDelete("{id}")]
        public List<Animal> Delete(int id)
        {
            Animal animal = _animals.Find(f => f.Id == id);

            _animals.Remove(animal);

            return _animals;
        }

    }
}
