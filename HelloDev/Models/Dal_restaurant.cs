using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace HelloDev.Models
{


    public class Dal_restaurant : IDisposable
    {


        Bdd_Restaurant dbContext;


        public Dal_restaurant()
        {
            
            dbContext = new Bdd_Restaurant();
            
        }


        public void Dispose()
        {

            dbContext.Dispose();

        }


        public void AddRestaurant(Restaurant restaurant)
        {

            dbContext.Restaurants.Add(restaurant);
            dbContext.SaveChanges();
            
        }


        public Restaurant GetRestaurant(int _id)
        {


            return dbContext.Restaurants.FirstOrDefault(restau => restau.ID == _id);
        }


        public object getRestaurants()
        {

            return dbContext.Restaurants.ToList();

        }


        public List<Restaurant> GetRestaurants(Restaurant restaurant)
        {


           return dbContext.Restaurants.ToList();
        }


        public void UpDateRestaurant(Restaurant _restaurant)
        {

            Restaurant restaurant = GetRestaurant(_restaurant.ID);

            if(restaurant != default(Restaurant))
            {

                restaurant.Nom = _restaurant.Nom;
                restaurant.Specialite = restaurant.Specialite;
                restaurant.Telephone = restaurant.Telephone;
                dbContext.SaveChanges();

            }

        }


        public void DeleteRestaurant(int id)
        {

            Restaurant restaurant = GetRestaurant(id);

            if(restaurant != default(Restaurant))
            {

                dbContext.Restaurants.Remove(restaurant);
                dbContext.SaveChanges();
            }


        }

    }


}