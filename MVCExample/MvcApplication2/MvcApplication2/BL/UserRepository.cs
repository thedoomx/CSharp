using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcApplication2.BL
{
    public class UserRepository : IUserRepository
    {
        private UsersContext _db = new UsersContext();

        public IEnumerable<Models.UserProfile> GetUserProfiles()
        {
            return this._db.UserProfiles.ToList();
        }

        public UserProfile GetUserProfileById(int id)
        {
            return this._db.UserProfiles.Find(id);
        }

        public void AddUserProfile(UserProfile userProfile)
        {
            this._db.UserProfiles.Add(userProfile);
            this._db.SaveChanges();
        }

        public void UpdateUserProfile(UserProfile userProfile)
        {
            this._db.Entry(userProfile).State = EntityState.Modified;
            this._db.SaveChanges();
        }

        public void DeleteUserProfile(int id)
        {
            UserProfile userprofile = this._db.UserProfiles.Find(id);

            if (userprofile != null)
            {
                this._db.UserProfiles.Remove(userprofile);
                this._db.SaveChanges();
            }
        }
    }
}