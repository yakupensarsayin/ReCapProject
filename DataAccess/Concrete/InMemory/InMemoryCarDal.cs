using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        // Simulating data like it comes from a database.
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ID = 1, BrandID = 1, ModelYear = 1980, DailyPrice = 100, Description = "Porsche 911 Carrera RS"},
                new Car{ID = 2, BrandID = 2, ModelYear = 1982, DailyPrice = 200, Description = "Bugatti EB110"},
                new Car{ID = 3, BrandID = 3, ModelYear = 1995, DailyPrice = 300, Description = "BMW Z1"},
                new Car{ID = 4, BrandID = 3, ModelYear = 1980, DailyPrice = 400, Description = "BMW M3 Lightweight"},
                new Car{ID = 5, BrandID = 4, ModelYear = 1983, DailyPrice = 500, Description = "Ferrari F50"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.ID == car.ID));
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandID(int brandID)
        {
            return _cars.Where(c => c.BrandID == brandID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
