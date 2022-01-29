using BIR.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Services
{
    public interface IAnimalService
    {
        IActionResult Get(Guid id);

        IActionResult Delete(Guid id);

        public IActionResult Post([FromBody] Animal animal);



    }
}
