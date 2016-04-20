using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpEditor.Models;

namespace EmpEditor.Controllers
{
    public interface IUserRepository
    {
        bool ContainsUser(UserModel user);
        bool AddUser(UserModel user);
        bool IsValid(string email, string password);
    }
}