using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_21
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; protected set; }
        public abstract void GetInfo();
    }
    class Parrot:Animal
    {
        public Parrot(string name)
        {
            Name = name;
            Type = "Bird";
        }
        public override void GetInfo()
        {
            Console.WriteLine("Type: "+Type + "\n"+"Name: " + Name+"\n");
        }
    }
    class Cat:Animal
    {
        public Cat(string name)
        {
            Name = name;
            Type = "Cat";
        }
        public override void GetInfo()
        {
            Console.WriteLine("Type: " + Type + "\n" + "Name: " + Name+"\n");
        }
    }

    abstract class Human
    {
        public string Name { get; set; }
        public string Nation { get; protected set; }
        public abstract void SayHello();
    }
    class Russian:Human
    {
        public Russian(string name)
        {
            Nation = "Russian";
            Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine(Nation+": Privet " + Name + "\n");
        }
    }
    class Amirican:Human
    {
        public Amirican(string name)
        {
            Nation = "American";
            Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine(Nation + ": Hello " + Name + "\n");
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Parrot("Kesha"));
            animals.Add(new Cat("Murzik"));
            foreach(Animal animal in animals)
            {
                animal.GetInfo();                
            }
            List<Human> humans = new List<Human>();
            humans.Add(new Russian("Pasha"));
            humans.Add(new Amirican("Sam"));
            foreach (Human human in humans)
                human.SayHello();
            Console.ReadKey();
        }
    }
}
