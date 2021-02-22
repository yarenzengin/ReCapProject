﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        new List<Car> _cars;//database
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car{Id = 1, BrandId = 1, DailyPrice =90000, ModelYear=2012,Description = "Citroen"},
            new Car{Id = 2, BrandId = 1, DailyPrice =79000, ModelYear=2007,Description = "Citroen"},
            new Car{Id = 3, BrandId = 3, DailyPrice =1950000, ModelYear=2009,Description = "Lamborghini"},
            new Car{Id = 4, BrandId = 5, DailyPrice =85000, ModelYear=2010,Description = "Renault"},
            new Car{Id = 5, BrandId = 2, DailyPrice =93000, ModelYear=2011,Description = "Hyundai"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; //return database
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
