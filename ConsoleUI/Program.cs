using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2017, Description = "Chevrolet A Series", DailyPrice = 250 }); // We are not using CarId because it is Auto Incremented in database.

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine("ID: {0} | Name: {1}", c.CarId, c.Description);
            }

            // etc. etc.

        }
    }
}
