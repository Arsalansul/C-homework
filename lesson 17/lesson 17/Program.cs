using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_17
{
    class Animal
    {
        public string Name { get; set; }
    }
    class Dog : Animal
    {
        public void Guad()
        {
            // собака охраняет
        }
    }
    class Cat : Animal
    {
        public void CatchMouse()
        {
            // кошка ловит мышь
        }
    }
    class Parrot
    {
        public double BeakLenght { get; set; }
        public Parrot(string name, double beak)
        {            
            BeakLenght = beak;
        }
    }

    class GeoFigure
    {
        private double[,] Center;
        public GeoFigure(double[,] x)
        {
            Center=x;
        } 
    }
    class Triangle
    {

    }
    class Circle
    {
        public double Radius{get;set;};
        public Circle(double[,] x, double radius)
        {
            Radius=radius;
        }
        
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Name = "Barbos";
            Cat cat1 = new Cat();
            cat1.Name = "Murzik";
            dog1.Guad();
            cat1.CatchMouse();
            Parrot parrot1 = new Parrot("Kesha", 2.2);
            Console.WriteLine(parrot1.BeakLenght);
            Console.ReadKey();
        }
    }
}
