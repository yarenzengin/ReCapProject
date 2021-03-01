using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService


    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                context.Brands.Add(brand);
                Console.WriteLine(  "marka eklendi");
                context.SaveChanges();
            }
        }

        public void Delete(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                _brandDal.Delete(brand);
                Console.WriteLine("marka silindi");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(c => c.BrandId == id);
        }

        public void Update(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                _brandDal.Update(brand);
                Console.WriteLine("marka güncellendi");
            }
        }
    }
}
