using Business.Concrete;
using System;
using DataAccess.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities;
using Core.DataAccess;
using Core.Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();

            // ColorTest();
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Update(new Color { ColorId = 5, ColorName = "sarı" });

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color() { ColorId = 5, ColorName = "turuncu" };
            colorManager.Add(color);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand() { BrandId = 7, BrandName = "yaren" };
            brandManager.Add(brand1);
            brandManager.Delete(new Brand { BrandId = 1, BrandName = "BMW" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car() { BrandId = 2, Description = "volkswagen", DailyPrice = 100000, ModelYear = 2009, ColorId = 3 };
            //carManager.Delete(new Car { CarId = 1002, BrandId = 1, ColorId = 3, ModelYear = 1997, DailyPrice = 80000, Description = "BMW" });
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            }

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.Description + "/" + car.ColorName);
            //    //Console.WriteLine( "Car Id : " + car.Id  +  " Car Name : " + car.Description);
            //    //Console.WriteLine("Araba adı : " + car1.Description + " Arabanın değeri :  " + car1.DailyPrice);
            //}
        }

}
    

