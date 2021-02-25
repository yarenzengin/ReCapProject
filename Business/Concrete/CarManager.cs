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
        
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            
           
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2 || car.DailyPrice < 0)
            {
                Console.WriteLine ("Bu arabayı ekleyemezsiniz.Araba adı minimum 2  ve fiyatı 0 dan büyük olmalıdır ");
            }
            _carDal.Add(car);
            Console.WriteLine("araba eklendi");
            
        }

       

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("araba silindi");

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
