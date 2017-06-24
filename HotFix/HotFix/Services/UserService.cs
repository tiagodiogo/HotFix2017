using HotFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotFix.Services
{
    public class UserService
    {

        private static List<LoginModel> credentials = new List<LoginModel>();
        private static Dictionary<LoginModel, UserModel> users = new Dictionary<LoginModel, UserModel>();

        private static UserService Instance = null;

        private UserService()
        {
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
                Street = "Rua das cenas"
            };

            users.Add(user1, new RefugeeModel()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "user1@user1.com",
                BirthDate = DateTime.Parse("27-07-1991"),
                Address = Address
            });
            users.Add(admin, new AdminModel(UserModel.Roles.MUNICIPAL)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "user1@user1.com",
                BirthDate = DateTime.Parse("27-07-1991"),
                Address = Address
            });
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
    }
}