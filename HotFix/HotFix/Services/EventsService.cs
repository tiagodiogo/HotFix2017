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
            AddressModel address = new AddressModel()
            {
                City = "Lisboa",
                Country = "Portugal",
                PostalCode = "2790-485",
                Street = "Rua das cenas"
            };

            AddressModel address2 = new AddressModel()
            {
                City = "Porto",
                Country = "Portugal",
                PostalCode = "2790-485",
                Street = "Rua das cenas"
            };

            EventModel event1 = new EventModel()
            {
                Id = 1,
                Name = "Festas de S. João",
                Category = "Traditional event",
                Description = "Festive season in the name of Porto saint",
                Image = "https://s-media-cache-ak0.pinimg.com/originals/24/8b/5f/248b5f93da41079e8906709c66be532b.jpg",
                Address = address2,
                Time = new DateTime(2017,6,24)
            };

            EventModel event2 = new EventModel()
            {
                Id = 2,
                Name = "Portugal vs Nova Zelândia",
                Category = "Sport",
                Description = "Confederation Cup game",
                Image = "http://www.fpf.pt/Portals/0/Imagens/0Info/Institucional/Logos%20FPF/logo%20FPF.jpg?w=540&h=360",
                Address = address,
                Time = new DateTime(2017, 6, 24)
            };

            events.Add(event1);
            events.Add(event2);
        }

        public static EventsService GetInstance()
        {
            if (Instance == null)
                Instance = new EventsService();
            return Instance;
        }

        public EventModel GetEvent(int id)
        {
            return events.Where(x => x.Id == id).FirstOrDefault();
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
                int id = events.Count + 1;

                //populate fields
                newEvent.Id = id;
                newEvent.Name = model.Name;
                newEvent.Category = model.Category;
                newEvent.Description = model.Description;
                newEvent.Time = model.Time;
                newEvent.CreatedAt = model.CreatedAt;
                newEvent.CreatedBy = model.CreatedBy;
                newEvent.Address.Street = model.Street;
                newEvent.Address.City = model.City;
                newEvent.Address.Country = "Portugal";
                newEvent.Address.PostalCode = model.PostalCode;
                newEvent.Image = "~/assets/img/event.jpg";
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