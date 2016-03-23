using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PandaLibrary
{
    public enum GenderType
    {
        Male,
        Female,
    };

    [Serializable]
    public class Panda
    {
        private string Name { get; set; }
        private string Email { get; set; }
        public GenderType Gender { get; set; }

        public Panda()
        {

        }

        public static bool ValidEmail(string str)
        {
            //"[a-z]"
            var a = new Regex(@"@\.");
            return Regex.IsMatch(str, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public Panda(string name, string email, GenderType gender)
        {
            Name = name;
            Gender = gender;
            if (ValidEmail(email))
            {
                Email = email;
            }
        }

        public override string ToString()
        {
            return "Panda name: " + Name + ", email: " + Email + " gender: " + Gender.ToString();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Email.GetHashCode();
                hash = hash * 23 + Gender.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            Panda p = obj as Panda;
            if (p == null)
            {
                return false;
            }

            return (this.Name == p.Name && this.Email == p.Email && this.Gender == p.Gender) ? true : false;
        }

        public static bool operator ==(Panda p1, Panda p2)
        {
            return object.Equals(p1, p2);
        }

        public static bool operator !=(Panda p1, Panda p2)
        {
            return !(p1 == p2);
        }
    }
}
