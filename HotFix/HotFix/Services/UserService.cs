using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Services
{
    public class UserService
    {
        private static List<UserModel> userExamples = new List<UserModel>();

        private static List<LoginModel> credentials = new List<LoginModel>();
        private static Dictionary<LoginModel, UserModel> users = new Dictionary<LoginModel, UserModel>();

        private static UserService Instance = null;

        private UserService()
        {

            System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("pt-PT");
            LoginModel user1 = new LoginModel()
            {
                Email = "user1@user1.com",
                Password = "12345"
            };
            LoginModel admin = new LoginModel()
            {
                Email = "hotfix@hotfix.com",
                Password = "admin"
            };

            credentials.Add(user1);
            credentials.Add(admin);

            var Address = new AddressModel()
            {
                City = "Lisboa",
                Country = "Portugal",
                PostalCode = "2790-485",
                Street = "Exemplo de Rua"
            };

            users.Add(user1, new RefugeeModel()
            {
                FirstName = "João",
                LastName = "Récio",
                Email = "user1@user1.com",
                BirthDate = DateTime.Parse("27/7/1991", cultureinfo),
                Address = Address
            });
            users.Add(admin, new AdminModel(UserModel.Roles.MUNICIPAL)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "user1@user1.com",
                BirthDate = DateTime.Parse("27/7/1991", cultureinfo),
                Address = Address
            });

            InitializeUserExamples();
        }

        internal void AddNewUser(RegistrationModel model)
        {
            LoginModel creds = new LoginModel()
            {
                Email = model.Email,
                Password = model.Password
            };
            RefugeeModel user = new RefugeeModel()
            {
                Email = model.Email,
                Address = model.Address,
                BirthDate = model.BirthDate,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            credentials.Add(creds);
            users.Add(creds, user);
            LoginUser(creds);
        }

        public static UserService GetInstance()
        {
            if (Instance == null)
                Instance = new UserService();
            return Instance;
        }

        public bool LoginUser(LoginModel model)
        {
            LoginModel login = credentials.Where(l => l.Email == model.Email && l.Password == model.Password).FirstOrDefault();
            if(login != null){
                HttpContext.Current.Session["user"] = users[login];
                return true;
            }
            return false;
        }

        public UserModel GetUser()
        {
            try
            {
                return HttpContext.Current.Session["user"] as UserModel;
            }catch(Exception)
            {
                return null;
            }
        }

        public List<UserModel> GetUserExamples()
        {
            return userExamples;
        }



        private void InitializeUserExamples()
        {
            userExamples.Add(new RefugeeModel()
            {
                Address = new AddressModel(),
                FirstName = "Joao",
                LastName = "Chitas",
                Email = "mailDoChitas@gmail.com"
            });

            userExamples.Add(new RefugeeModel()
            {
                Address = new AddressModel(),
                FirstName = "Joao",
                LastName = "Recio",
                Email = "mailDoRecio@gmail.com"
            });

            userExamples.Add(new RefugeeModel()
            {
                Address = new AddressModel(),
                FirstName = "Tiago",
                LastName = "Diogo",
                Email = "mailDoTD@gmail.com"
            });

        }
    }
}