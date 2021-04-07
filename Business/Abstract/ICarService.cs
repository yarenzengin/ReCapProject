﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Business.Abstract
{
  public   interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<Car>> GetByColordId(int id);
        
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car);
        

    }
}
