using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CityInfoApi.Controllers
{

    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id) 
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
