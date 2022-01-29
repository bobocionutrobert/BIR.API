using BIR.API.Models;
using BIR.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Services
{
    public class AnimalService : IAnimalService 
    {

        List<Animal> _animals = new List<Animal>()
        {



        };

        private readonly ILogger<IAnimalService> _logger;


        public AnimalService(ILogger<IAnimalService> logger)
        {
            _logger = logger;

        }

        public IActionResult Get(Guid id)
        {
            Animal animal = _animals.Find(f => f.Id == id);
            return Ok(animal);
        }

        private IActionResult Ok(Animal animal)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Animals")]
        public IActionResult Post([FromBody] Animal animal)
        {
            _animals.Add(animal);
            return Ok(_animals);
        }

        private IActionResult Ok(List<Animal> animals)
        {
            throw new NotImplementedException();
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
