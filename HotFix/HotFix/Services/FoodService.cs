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

        public bool CreateRest(FoodModel model)
        {
            try
            {
                FoodModel rest = new FoodModel();
                return true;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}