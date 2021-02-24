using Business.Concrete;
using System;
using DataAccess.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(), new RuleManager());
            Car car1 = new Car() {BrandId = 1, Description = "BMW", DailyPrice = 80000, ModelYear = 1997 ,ColorId = 3};
            carManager.Add(car1);
            Console.WriteLine(car1.Description + car1.DailyPrice);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.);
            //    //Console.WriteLine( "Car Id : " + car.Id  +  " Car Name : " + car.Description);
            //}


        }
    }
}
