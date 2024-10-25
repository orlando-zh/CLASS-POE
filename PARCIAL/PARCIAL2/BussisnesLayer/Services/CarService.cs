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
            // Check if Car with carId exists
            if (_carsRepository.CarExists(car.CarID))
            {
                // Car exists, proceed with insertion
                _carsRepository.AddCar(car);
            }
            else
            {
                // Car doesn't exist, handle error
                Console.WriteLine("Error: Car with ID {0} not found. Cannot add car.", car.CarID);
            }
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
