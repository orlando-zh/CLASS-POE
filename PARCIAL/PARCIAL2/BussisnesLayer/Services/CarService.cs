using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussisnesLayer.Services
{
    public class CarService
    {
        private CarRepository _carsRepository;

        public CarService()
        {
            _carsRepository = new CarRepository();
        }

        public DataTable GetAllCars()
        {
            return _carsRepository.GetCars();
        }

        public void AddCar(Car car)
        {
            _carsRepository.AddCar(car);
        }

        public void EditCar(Car car)
        {
            _carsRepository.UpdateCar(car);
        }

        public void DeleteCar(int carId)
        {
            _carsRepository.DeleteCar(carId);
        }
    }
}
