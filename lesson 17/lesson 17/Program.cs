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
        public Animal(string name)
        {
            Name = name;
        }
    }
    class Dog : Animal
    {
        public Dog(string name):base(name)
        {

        }
        public void Guad()
        {
            // собака охраняет
        }
    }
    class Cat : Animal
    {
        public Cat(string name):base(name)
        {

        }
        public void CatchMouse()
        {
            // кошка ловит мышь
        }
    }
    class Parrot:Animal
    {
        public double BeakLenght { get; set; }
        public Parrot(string name, double beak): base(name)
        {            
            BeakLenght = beak;
        }
    }

    class GeoFigure
    {
        public double[,] Center { get; set; }
        public GeoFigure(double[,] center)
        {
            Center=center;
        } 
    }
    class Triangle:GeoFigure
    {
        private double[,] A;
        private double[,] B;

        public Triangle(double[,] center, double[,] a, double[,] b):base(center)
        {
            A = a;
            B = b;
        }
        public void Draw()
        {
            //могла бы быть специфическая логика рисования фигуры
        }
    }
    class Circle:GeoFigure
    {
        private double Radius { get; set; }
        
        public Circle(double[,] center, double radius):base(center)
        {
            Radius=radius;            
        }
        public void Draw()
        {
            //могла бы быть специфическая логика рисования фигуры
        }
        
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Barbos");
            //dog1.Name = "Barbos";
            Cat cat1 = new Cat("Murzik");
            //cat1.Name = "Murzik";
            dog1.Guad();
            cat1.CatchMouse();
            Parrot parrot1 = new Parrot("Kesha", 2.2);
            Console.WriteLine(parrot1.BeakLenght);

            Circle circle1 = new Circle(new double [1,1], 1);
            Triangle triangle1 = new Triangle(new double[5, 5], new double[6, 5], new double[5, 6]);
            circle1.Draw();
            triangle1.Draw();
            Console.ReadKey();
        }
    }
}
