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
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() {BrandId = 3, Description = "Opel", DailyPrice = 90000, ModelYear = 1999 ,ColorId = 2};
            carManager.Add(car1);
            Console.WriteLine("Araba adı : " + car1.Description + " Arabanın değeri :  " + car1.DailyPrice);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.);
            //    //Console.WriteLine( "Car Id : " + car.Id  +  " Car Name : " + car.Description);
            //}


        }
    }
}
