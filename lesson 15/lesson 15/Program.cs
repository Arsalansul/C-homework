using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_15
{
    class Car
    {
        private double mileage;
        private double fuel;

        public Car()
        {
            mileage = 0;
            fuel = 0;
        }

        public Car(double mileage, double fuel)
        {
            this.mileage = 0;
            this.fuel = 0;
        }

    }

    class Student
    {
        private string name;
        private int course;
        bool grants;

        public Student()
        {
            course = 1;
            grants = true;
        }

        public Student(string name, int course, bool grants)
        {
            this.name = name;
            this.course = course;
            this.grants = grants;
        }

        public Student(string name)
        {
            this.name = name;
            course = 1;
            grants = true;
        }

        public void writer()
        {
            Console.WriteLine(name + " " + course + " " + grants);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Car newCar1 = new Car();// создаем автомобиль с параметрами по умолчанию, 0 и 0 
            Car newCar2 = new Car(100, 50);// создаем автомобиль с указанными параметрами 

            Student newStudent = new Student("Anton");
            Student oldSrudent = new Student("Dima", 3, false);

            newStudent.writer();
            oldSrudent.writer();
            Console.ReadKey();
        }
    }
}
