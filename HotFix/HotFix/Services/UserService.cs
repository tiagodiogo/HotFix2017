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