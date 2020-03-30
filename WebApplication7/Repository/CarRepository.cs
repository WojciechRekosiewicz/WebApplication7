using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Repository
{
    public class CarRepository : ICarRepository
    {       
        public static List<Car> cars { get; private set; }

        static CarRepository()
        {
            cars = new List<Car>();
            cars.Add(new Car()
            {
                Id = 1,
                Name = "Skoda",
                MaxSpeed = 220
            });
            cars.Add(new Car()
            {
                Id = 2,
                Name = "Mazda",
                MaxSpeed = 250
            });
            cars.Add(new Car()
            {
                Id = 3,
                Name = "Ford",
                MaxSpeed = 300
            });
            cars.Add(new Car()
            {
                Id = 4,
                Name = "Audi",
                MaxSpeed = 300
            });           
        }
        public void CreateCar(Car car)
        {
            cars.Add(car);
        }

         public IEnumerable<Car> GetAllCars()
        {                             
            return cars;
        }

        public Car GetCarById(int id)
        {
            return cars.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateCar(int id, Car car)
        {
            var car1 = GetAllCars().Where(u => u.Id == id).FirstOrDefault();            
            if(car1 != null)
            {
                cars.Remove(car1);
                cars.Add(car);
            }
        }

        public void DeleteCar(int id)
        {
            var car = GetAllCars().Where(u => u.Id == id).FirstOrDefault();
            if (car != null)
            {
                cars.Remove(car);
            }
        }
    }
}
