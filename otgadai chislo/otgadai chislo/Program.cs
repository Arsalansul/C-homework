using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otgadai_chislo
{
    class Program
    {
        public static int Move()
        {
            Console.WriteLine("Enter your number (1-20): ");

            while (true)
            {
                    try
                    {
                        var Number = Convert.ToInt32(Console.ReadLine());

                        if (Number > 20 || Number < 1) Console.WriteLine("Число должно быть от 1 до 20. Повтори попытку: ");

                        else return Number;
                    }
                    catch
                    {
                        Console.WriteLine("Error! Enter only your number: ");
                    }
            }
        }

        public static bool Proverka(int FirstPlayerNumber, int SecondPlayerNumber)
        {
            if (FirstPlayerNumber == SecondPlayerNumber)
                return true;
            else
                return false;            
        }

        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int CompNumber = rnd1.Next(1, 21);
            Console.WriteLine(CompNumber);
            int MyNumber=Move();
            int Number;
            bool MyMove = false;
            bool End = false;
            while (!End)
            {
                if (MyMove)
                {
                    Console.WriteLine("Попробуй отгадать");
                    Number = Move();
                    MyMove=false;
                    End = Proverka(Number, CompNumber);

                }
                else
                {
                    Number=rnd1.Next(1, 21);
                    Console.WriteLine("Очередь второго игрока. Его попытка " + Number);
                    End = Proverka(Number, MyNumber);
                    MyMove=true;
                }

            }
            
            if (MyMove)
                Console.WriteLine("Lose");
            else
                Console.WriteLine("Congratulations!");
            Console.ReadKey();
        }
    }
}
