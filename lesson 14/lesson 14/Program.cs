using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14
{
    class TVSet
    {
        private bool switchedOn;        
        public void SwitchOn()
        {
            switchedOn = true;
        }
        public void SwitchOff()
        {
            switchedOn = false;
        }

        private int channel;
        public void PreviousChannel()
        {
            if (channel > 0)
                channel--;
            Console.WriteLine(channel);
        }
        public void NextChannel()
        {
            channel++;
            Console.WriteLine(channel);
        }
        public void SwitchChannel(int a)
        {
            if (a < 0)
                Console.WriteLine("Ошибка ввода");
            else
                channel=a;
            Console.WriteLine(channel);
        }

    }

    class StringHelper
    {
        public static string TrimIt(string s, int max)
        {
            if (s == null)
                return string.Empty;
            if (s.Length <= max)
                return s;
            return s.Substring(0, max) + "...";

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TVSet myTV = new TVSet();
            myTV.SwitchOn();// включаем телевизор, switchedOn = true;
            myTV.SwitchOff();// выключаем телевизор, switchedOn = false;

            string s = "Очень длинная строка, которую необходимо обрезать до указанной длины и добавить многоточие";
            Console.WriteLine(StringHelper.TrimIt(s, 5));

            myTV.PreviousChannel();
            myTV.NextChannel();
            Console.WriteLine("Введите канал");
            bool error = true;
            int a=0;
            while (error)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("введи число");
                    
                }
            }
            
            myTV.SwitchChannel(a);

            Console.ReadKey();
        }
    }
}
