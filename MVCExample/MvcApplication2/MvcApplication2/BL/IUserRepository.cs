using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.BL
{
    public interface IUserRepository
    {
        IEnumerable<UserProfile> GetUserProfiles();
        UserProfile GetUserProfileById(int id);
        void AddUserProfile(UserProfile userProfile);
        void UpdateUserProfile(UserProfile userProfile);
        void DeleteUserProfile(int id);
    }
}