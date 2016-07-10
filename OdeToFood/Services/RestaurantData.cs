using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>{
                new Restaurant { Id = 1, Name = "Wendy's"},
                new Restaurant { Id = 2, Name = "Burger King"},
                new Restaurant { Id = 3, Name = "McDonald's"}};
        }

        public IEnumerable<Restaurant> GetAll() => _restaurants;

        List<Restaurant> _restaurants;
    }
}
