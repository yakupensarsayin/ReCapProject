using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car
            {
                ID = 6,
                BrandID = 5,
                DailyPrice = 450,
                ModelYear = 1998,
                Description = "Mercedes-Benz CLK GTR"
            };
            carManager.Add(car1);

            car1.DailyPrice = 550;
            carManager.Update(car1);

            foreach (var cars in carManager.GetByBrandID(3))
            {
                Console.WriteLine("ID: {0} | Description: {1}", cars.ID, cars.Description);
            }

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("ID: {0} | Brand ID: {1} | Description: {2}", cars.ID, cars.BrandID, cars.Description);
            }

        }
    }
}
