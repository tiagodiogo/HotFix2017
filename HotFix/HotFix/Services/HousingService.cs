using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotFix.Models;

namespace HotFix.Services
{
    public class HousingService
    {
        private static List<HousingModel> houses = new List<HousingModel>();
        private static HousingService Instance = null;

        private HousingService()
        {

        }

        public static HousingService GetInstance()
        {
            if (Instance == null)
                Instance = new HousingService();
            return Instance;
        }

        public List<HousingModel> GetHouses()
        {
            return houses;
        }

        public bool CreateHouse(HousingViewModel model)
        {
            try
            {
                HousingModel house = new HousingModel();
                house.Address = new AddressModel();
                int id = houses.Count + 1;

                house.Id = id;
                house.Name = model.Name;
                house.Category = model.Category;
                house.Description = model.Description;
                house.Rooms = model.Rooms;
                house.CreatedAt = model.CreatedAt;
                house.CreatedBy = model.CreatedBy;
                house.Address.Street = model.Street;
                house.Address.City = model.City;
                house.Address.Country = "Portugal";
                house.Address.PostalCode = model.PostalCode;

                houses.Add(house);

                return true;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}