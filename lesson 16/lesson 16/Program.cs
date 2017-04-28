using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16
{
    class Student
    {
        private int year;   //объявление закрытого поля
        public int Year   //объявление свойства
        {
            get //аксессор чтения поля
            {
                return year;
            }
            set //аксессор записи в поле
            {
                if (value < 1)
                    year = 1;
                else if (value > 5)
                    year = 5;
                else
                    year = value;                 
            }
        }

        public bool Grats { get; set; }
    }

    class TVSet
    {
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0)
                    volume = 0;
                else if (value > 100)
                    volume = 100;
                else
                    volume = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Year = 0;// записываем в поле, используя аксессор set
            Console.WriteLine(st1.Year);// читаем поле, используя аксессор get, выведет 1

            st1.Grats = true;
            Console.WriteLine(st1.Grats);

            TVSet mytv = new TVSet();
            mytv.Volume = 99;
            Console.WriteLine(mytv.Volume);
            Console.ReadKey();
        }
    }
}
