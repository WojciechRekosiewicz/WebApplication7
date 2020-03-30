using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carRepository.GetAllCars();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carRepository.GetCarById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Add([FromBody]Car car)
        {
            if (_carRepository.GetAllCars().Where(u => u.Id == car.Id) == null)
            {
                _carRepository.CreateCar(car);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Car car)
        {
            _carRepository.UpdateCar(id, car);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carRepository.DeleteCar(id);
        }
    }
}
