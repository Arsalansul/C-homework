using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_18
{
    class Animals
    {
        public string Name { get; set; }
        public Animals(string name)
        {
            Name = name;
        }
    }
    class Dog:Animals
    {
        public Dog(string name):base (name)
        {

        }
        public void Guard()
        {
            Console.WriteLine(Name + " guard");
        }
    }
    class Cat:Animals
    {
        public Cat(string name):base (name)
        {

        }
        public void CatchMouse()
        {
            Console.WriteLine(Name + " catch mouse");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>();
            Dog dog1 = new Dog("Barbos");
            //Cat cat1 = new Cat("Barsik");
            animals.Add(dog1);
            animals.Add(new Cat("Barsik"));

            foreach (Animals animal in animals)
            {
                if (animal is Dog)
                    //((Dog)animal).Guard();
                    (animal as Dog).Guard();
                else
                    ((Cat)animal).CatchMouse();
               
            }

            Console.WriteLine(dog1 is Dog);
            Console.WriteLine(dog1 is Animals);
            Console.WriteLine(dog1 is Cat);
            Console.ReadKey();
        }
    }
}
