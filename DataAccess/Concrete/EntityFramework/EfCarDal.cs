using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join cr in context.Colors
                             on c.ColorId equals cr.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId


                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cr.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description


                             };
                return result.ToList();

            }
        //    public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        //{
        //    using (RentCarContext context = new RentCarContext())
        //    {
        //        var result = from brand in context.Brands
        //                     join car in context.Cars
        //                     on brand.BrandId equals car.BrandId
        //                     join col in context.Colors
        //                     on car.ColorId equals col.ColorId
        //                     select new CarDetailDto
        //                     {
                                 
        //                         CarId = car.CarId,
        //                         BrandName = brand.BrandName,
        //                         ColorName = col.ColorName,
        //                         DailyPrice = car.DailyPrice,
        //                         Description = car.Description,
        //                         ModelYear = car.ModelYear,
        //                         BrandId = brand.BrandId,
        //                         ColorId = col.ColorId,
        //                         ImagePath = (from a in context.CarImages where a.CarId == car.CarId select a.ImagePath).FirstOrDefault()
        //                     };

        //        return filter == null
        //         ? result.ToList()
        //         : result.Where(filter).ToList();

        //    }
        }
    }

}



    

