using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day02
{
    public abstract class Person
    {
        private string sex;

        public abstract string DailyStuff();
    }

    public class Children : Person
    {
        private List<Toys> toys = new List<Toys>();
        
        public override string DailyStuff()
        {
            return "I am playing";
        }

        public void AddToys(params Toys[] toys)
        {
            
            foreach (var item in toys)
            {
                this.toys.Add(item);
            }
        }
    }

    public class Adults : Person
    {
        private List<Children> children = new List<Children>();

        public override string DailyStuff()
        {
            return "I am working";
        }

        public void AddChildren(params Children[] children)
        {
            foreach (var item in children)
            {
                this.children.Add(item);
            }
        }

        public bool IsBoring()
        {
            if (this.children.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return String.Format("I am an adult and I have {0} children. {1}", children.Count, this.DailyStuff());
        }
    }

    public class Toys
    {
        private int size;
        private string colour;

        public Toys(int size, string colour)
        {
            this.size = size;
            this.colour = colour;
        }
    }
}
