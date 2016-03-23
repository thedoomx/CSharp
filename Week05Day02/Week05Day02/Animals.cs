using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day02
{
    public abstract class Animal
    {
        public abstract void Move();

        public abstract void Eat();

        public abstract void GiveBirth();
    }

    public abstract class LandAnimals : Animal
    {
        public virtual void Greet()
        {

        }
    }

    public abstract class Mammals : LandAnimals
    {
        
    }

    public abstract class Reptiles : LandAnimals
    {
        public virtual int GetTemperature(int temperature)
        {
            return temperature;
        }
    }

    public abstract class Fish : LandAnimals
    {

    }

    public abstract class Birds : Animal
    {
        public virtual void MakeNest()
        {

        }
    }

    public class Cat : Mammals
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Mammals
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("Bau, bau");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class Crocodile : Reptiles
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("RAWRARWAR");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class Owl : Birds
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void MakeNest()
        {
            Console.WriteLine("I am nesting, wtf??");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class Shark : Fish
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }


}
