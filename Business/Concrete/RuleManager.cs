using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;


namespace Business.Concrete
{
    public class RuleManager : IRuleService
    {
        public void NameLength(Car car)
        {
            if (car.Description.Length <2)
            {
                Console.WriteLine("araba ismi min 2 olmalıdır");
            }
            
        }

        public void Price(Car car)
        {
            if (car.DailyPrice < 0)

            {
                Console.WriteLine("araba fiyatı 0 'dan büyük olmalıdır");
            }
        }
    }
}
