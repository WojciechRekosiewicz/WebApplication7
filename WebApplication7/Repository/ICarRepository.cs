using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        void CreateCar(Car car);
        void UpdateCar(int id, Car car);
        void DeleteCar(int id);
    }
}
