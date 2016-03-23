using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day02
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Crocodile crocodile = new Crocodile();
            //crocodile.Greet();
            //Console.WriteLine("Croc's temp is {0}", crocodile.GetTemperature(5));

            //List<Animal> animals = new List<Animal>() { new Crocodile(), new Dog(), new Cat(), new Owl() };
            //foreach (var item in animals)
            //{
            //    if (item is LandAnimals)
            //    {
            //        LandAnimals temp = item as LandAnimals;
            //        temp.Greet();
            //    }
            //}


            Square sq = new Square();
            sq.Height = 5;
            sq.Width = 12;
            sq.GetPerimeter();

            
        }
    }
}
