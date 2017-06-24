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