using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using EshopApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class UsersServices : IUsers
    {
        private readonly EshopDB _db;
        public UsersServices(EshopDB db)
        {
            _db = db;
        }
        public List<Users> GetUsersList()
        {
            return _db.Users.ToList();
        }
        public Users RegisterUser(Users userData)
        {
            var user_email = userData.Email;
            List<Users> listUsers = _db.Users.ToList();
            Users matched_email = null;
            foreach (Users item in listUsers)
            {
                if (item.Email == user_email)
                {
                    matched_email = item;
                }
            }
            if(matched_email == null)
            {
                _db.Users.Add(userData);
                _db.SaveChanges();

            }
            else
            {
                userData = null;
            }


            return userData;


        }

        public Users UpdateProfile(Users userData)
        {
            var oldData = _db.Users.Find(userData.Id);
            if(oldData != null)
            {
                oldData.Id = userData.Id;
                oldData.FirstName = userData.FirstName;
                oldData.LastName = userData.LastName;
                oldData.Email = userData.Email;
                oldData.Password = userData.Password;
                oldData.Phone = userData.Phone;
                oldData.Address = userData.Address;
                oldData.Type = userData.Type;

            }
            _db.Users.Update(oldData);
            _db.Entry(oldData).Property(x => x.Id).IsModified = false;//To prevent Identity column update issue
            _db.SaveChanges();
            return userData;
        }

        public Users ValidateUser(LoginUser userData)
        {
           /* Response response = new Response();*/
            var User_input_Email = userData.Email;
            var User_input_Password = userData.Password;
            List<Users> listUsers = _db.Users.ToList();
            Users existing_userdata = null;
            foreach(Users item in listUsers)
            {
                if(item.Email == User_input_Email && item.Password == User_input_Password)
                {
                    existing_userdata = item;
                }
            }
            return existing_userdata;
        
        }
    }
}
