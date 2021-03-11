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
using Business.Constants;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //UserTest();
            // ColorTest();
            //CustomerTest();

            DateTime dateTime = DateTime.Now;
            string sqlFormattedDate = dateTime.ToString("2021-11-20");
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
           
            Rental rental = new Rental() { Id = 15, CarId = 2, CustomerId = 5, ReturnDate = sqlFormattedDate };
            rentalManager.Delete(rental);
            Console.WriteLine(Messages.RentalDeleted);
   
            
            






        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { CustomerId = 7, UserId = 7, CompanyName = " Faith " };
            customerManager.Add(customer);
            Console.WriteLine(Messages
                .CustomerAdded);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User() { UserId = 7, FirstName = "şevval", LastName = "albayrak", Email = "sevvalalbayrak", Password = "bilemiyorumsevval" };
            userManager.Add(user);
            //userManager.Update(new User
            //{
            //    UserId = 5,
            //    FirstName = "beyza",
            //    LastName = "akyol",
            //    Email = "beyzaakyol",
            //    Password = "beyzakyoll"
            //}


               
            Console.WriteLine(Messages.UserAdded);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color() { ColorId = 5, ColorName = "turuncu" };
            colorManager.Add(color);
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Update(new Color { ColorId = 5, ColorName = "sarı" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand1 = new Brand() { BrandId = 7, BrandName = "yaren" };
            //brandManager.Add(brand1);
            //brandManager.Delete(new Brand { BrandId = 1, BrandName = "BMW" });
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
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
    

