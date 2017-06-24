using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotFix.Models;

namespace HotFix.Services
{
    public class EventsService
    {
        private static List<EventModel> events = new List<EventModel>();
        private static EventsService Instance = null;

        private EventsService()
        {

        }

        public static EventsService GetInstance()
        {
            if (Instance == null)
                Instance = new EventsService();
            return Instance;
        }

        public List<EventModel> GetEvents()
        {
            return events;
        }

        public bool CreateEvent(EventViewModel model)
        {
            try
            {
                EventModel newEvent = new EventModel();
                newEvent.Address = new AddressModel();

                //populate fields
                newEvent.Name = model.Name;
                newEvent.Category = model.Category;
                newEvent.Description = model.Description;
                newEvent.CreatedAt = model.CreatedAt;
                newEvent.CreatedBy = model.CreatedBy;
                newEvent.Address.Street = model.Street;
                newEvent.Address.City = model.City;
                newEvent.Address.Country = "Portugal";
                newEvent.Address.PostalCode = model.PostalCode;

                events.Add(newEvent);

                return true;
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }
    }
}