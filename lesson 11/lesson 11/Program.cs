using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //необходимые нам классы для работы с файлами

namespace lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create("e:\\C-homework\\lesson 11\\new.txt");
            //File.WriteAllText("e:\\C-homework\\lesson 11\\new.txt", "lesson 11 start");
            //File.AppendAllText("e:\\C-homework\\lesson 11\\new.txt", "\n текст методом AppendAllText()");
            //File.Delete("e:\\C-homework\\lesson 11\\test.txt");
            FileStream file = new FileStream("e:\\C-homework\\lesson 11\\new.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            FileStream file1 = new FileStream("e:\\C-homework\\lesson 11\\new1.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1, Encoding.Unicode);
            writer.Write("текст streamWriter");
            writer.Close();

            StreamWriter writer1 = new StreamWriter ("e:\\C-homework\\lesson 11\\new2.txt");
            writer1.WriteLine("текст");
            writer1.Close();

            //Directory.CreateDirectory("e:\\C-homework\\lesson 11\\new_folder");

            //Directory.Delete("e:\\C-homework\\lesson 11\\new_folder", true);
            Console.ReadKey();

            //1st
            StreamWriter numbersWriter = new StreamWriter("e:\\C-homework\\lesson 11\\numbers.txt");
            for (int i = 1; i < 501; i++)
            {
                string zapytay= ", ";
                if(i%10==0)
                    zapytay="\n";
                numbersWriter.Write(i +zapytay);
            }
            numbersWriter.Close();

            //2nd
            string[] array = { "red", "green", "black", "white", "blue" };
            StreamWriter arrayWriter = new StreamWriter("e:\\C-homework\\lesson 11\\array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                arrayWriter.WriteLine(array[i]);
            }
            arrayWriter.Close();

            //3rd
            StreamReader arrayReader = new StreamReader("e:\\C-homework\\lesson 11\\array.txt");
            int numStroka=0, stroka=0;
            int length=0;            

            while (!(arrayReader.EndOfStream))
            {
                var s = arrayReader.ReadLine();
                if (length < s.Length)
                {
                    numStroka = stroka; 
                    length = s.Length;  
                  
                }
                stroka++;
            }
            Console.WriteLine(length);
            Console.WriteLine(numStroka);

            Console.ReadKey();
        }
    }
}
