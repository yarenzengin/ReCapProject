using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;
        IRuleService _ruleService;
        
        public CarManager(ICarDal carDal, IRuleService ruleService )
        {
            _carDal = carDal;
            _ruleService = ruleService;
           
        }

        public void Add(Car car)
        {
            _ruleService.NameLength(car);
            _ruleService.Price(car);
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColordId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
