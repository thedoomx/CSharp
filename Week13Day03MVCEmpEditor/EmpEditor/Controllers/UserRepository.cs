using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpEditor.Models;

namespace EmpEditor.Controllers
{
    public class UserRepository : IUserRepository
    {
        private Week08Day03Entities context = new Week08Day03Entities();


        private List<User> GetUsers()
        {
            return context.Users.ToList();
        }
        public bool ContainsUser(UserModel usermodel)
        {
            foreach (User item in GetUsers())
            {
                if (item.Email.Equals(usermodel.Email) && item.Password.Equals(usermodel.Password))
                {
                    return true;
                }
            }

            return false;
        }
        public bool AddUser(UserModel user)
        {
            if(context.Users.FirstOrDefault(email => email.Email.Equals(user.Email)) == null)
            {
                var crypto = new SimpleCrypto.PBKDF2();

                var encrPass = crypto.Compute(user.Password);

                User userToSave = context.Users.Create();

                userToSave.Email = user.Email;
                userToSave.Password = encrPass;
                userToSave.PasswordSalt = crypto.Salt;
                userToSave.UserId = Guid.NewGuid();

                context.Users.Add(userToSave);
                context.SaveChanges();

                return true;
            }

            return false;
        }
        public bool IsValid(string email, string password)
        {
            var crypto = new SimpleCrypto.PBKDF2();

            bool isValid = false;

            var user = context.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                if (user.Password == crypto.Compute(password, user.PasswordSalt))
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}