using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotFix.Models;

namespace HotFix.Services
{
    public class FoodService
    {
        private static List<FoodModel> rests = new List<FoodModel>();
        private static FoodService Instance = null;

        private FoodService()
        {
            AddressModel address = new AddressModel()
            {
                City = "Lisboa",
                Country = "Portugal",
                PostalCode = "2790-485",
                Street = "Rua das cenas"
            };

            FoodModel food1 = new FoodModel()
            {
                Id = 1,
                Name = "Nice 2 eat you",
                Category = "Italian",
                Address = address,
                PriceMin = 15,
                PriceMax = 30,
                Image = "http://www.commodoreelite.com/Photos/Commodore-elite-restaurant-02.jpg"
            };

            FoodModel food2 = new FoodModel()
            {
                Id = 1,
                Name = "Curry is life",
                Category = "Indian",
                Address = address,
                PriceMin = 10,
                PriceMax = 20,
                Image = "http://www.barcelonaconnect.com/wp-content/uploads/2016/04/indisch.jpg"
            };

            rests.Add(food1);
            rests.Add(food2);
        }

        public static FoodService GetInstance()
        {
            if (Instance == null)
                Instance = new FoodService();
            return Instance;
        }

        public List<FoodModel> GetRest()
        {
            return rests;
        }

        public bool CreateRest(FoodViewModel model)
        {
            try
            {
                FoodModel rest = new FoodModel();
                rest.Address = new AddressModel();

                rest.Name = model.Name;
                rest.Category = model.Category;
                rest.PriceMin = model.PriceMin;
                rest.PriceMax = model.PriceMax;
                rest.Address.Street = model.Street;
                rest.Address.City = model.City;
                rest.Address.PostalCode = model.PostalCode;

                rest.CreatedAt = model.CreatedAt;
                rest.CreatedBy = model.CreatedBy;

                rests.Add(rest);

                return true;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}