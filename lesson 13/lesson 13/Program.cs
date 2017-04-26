using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        public string group; // не рекомендуется использовать public для поля
    }

    public class Pupil //без указания модификатор доступа, класс будет internal
    {
    }

    public class Math
    {
        private const double Pi = 3.14;
    }

    public class Car
    {
        private int age;
        protected string marka;

        internal string model;
        public string color;

        public int skorost(int a)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            return a * t;
 
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();//создание объекта student1 класса Student
            Student student2 = new Student();//Такие поля класса Student, как firstName, lastName и age указаны с модификатором доступа private, поэтому доступ к ним будет запрещен вне класса

            student1.group = "Group1";
            student2.group = "Group2";

            Console.WriteLine(student1.group);
            Console.WriteLine(student2.group);

            Car car1 = new Car();
            car1.color = "Blue";
            //car1.age = 1;

            Console.WriteLine(car1.skorost(2));
            Console.WriteLine(car1.color);
            
            Console.ReadKey();
        }
    }
}
