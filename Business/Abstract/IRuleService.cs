using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
namespace Business.Abstract
{
  public  interface IRuleService
    {
        void NameLength(Car car);
        void Price(Car car);
    }
}
