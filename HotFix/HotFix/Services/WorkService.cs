﻿using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Services
{
    public class WorkService
    {

        private static List<WorkModel> works = new List<WorkModel>();
        private static WorkService Instance = null;

        private WorkService()
        {
            AddressModel address = new AddressModel()
            {
                City = "Lisboa",
                Country = "Portugal",
                PostalCode = "2790-485",
                Street = "Rua das cenas"
            };

            WorkModel work1 = new WorkModel()
            {
                Id = 1,
                Name = "Instituto Agronomia",
                JobDescription = "Forestry",
                Picture = "https://www.isa.ulisboa.pt/files/logo_green.png",
                Address = address
            };
            WorkModel work2 = new WorkModel()
            {
                Id = 2,
                Name = "Cintell Corp",
                JobDescription = "Marketing",
                Picture = "http://cintell.net/wp/wp-content/uploads/2015/01/Cintell_Logo_Print_v1.0.png",
                Address = address
            };

            works.Add(work1);
            works.Add(work2);
        }

        public static WorkService GetInstance()
        {
            if (Instance == null)
                Instance = new WorkService();
            return Instance;
        }

        public WorkModel GetWork(int id)
        {
            return works.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<WorkModel> GetWorks()
        {
            return works;
        }

        public bool AddWork(WorkViewModel model)
        {
            try
            {
                WorkModel newWork = new WorkModel();
                newWork.Address = new AddressModel();

                newWork.Name = model.Name;
                newWork.JobDescription = model.JobDescription;
                newWork.Category = model.Category;
                newWork.Picture = model.Picture;
                works.Add(newWork);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}