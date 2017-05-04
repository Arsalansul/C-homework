using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otgadai_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int CompNumber=22;
            int MyNumber=23;
            while (MyNumber != CompNumber)
            {
                CompNumber = rnd1.Next(1, 21);
                Console.WriteLine("Enter your number (1-20): ");
                bool numberIsCorrect = false;
                while (numberIsCorrect == false)
                {
                    try
                    {
                        MyNumber = Convert.ToInt32(Console.ReadLine());
                        numberIsCorrect = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error! Enter only your number: ");
                    }
                }
            }
            Console.WriteLine("Congratulations!");
            Console.ReadKey();
        }
    }
}
