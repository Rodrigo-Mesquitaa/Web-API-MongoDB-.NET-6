using Microsoft.AspNetCore.Mvc;
using Mongo_API.Models;
using Mongo_API.Services;
using System.Collections.Generic;

namespace Mongo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult<List<Car>> Get() =>
            _carService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Car> Get(string id)
        {
            var book = _carService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<Car> Create(Car car)
        {
            _carService.Create(car);

            return CreatedAtRoute("GetBook", new { id = car.Id.ToString() }, car);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Car carIn)
        {
            var car = _carService.Get(id);

            if (car == null)
            {
                return NotFound();
            }

            _carService.Update(id, carIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var car = _carService.Get(id);

            if (car == null)
            {
                return NotFound();
            }

            _carService.Remove(car.Id);

            return NoContent();
        }
    }
}
