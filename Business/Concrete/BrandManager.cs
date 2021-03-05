using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                context.Brands.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
                //Console.WriteLine(  "marka eklendi");
                context.SaveChanges();
            }
        }

        public IResult Delete(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                _brandDal.Delete(brand);
                return new SuccessResult(Messages.BrandDeleted);
                //Console.WriteLine("marka silindi");
            }
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
            
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            using (RentCarContext context = new RentCarContext())
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdted);
                //Console.WriteLine("marka güncellendi");
            }
        }
    }
}
