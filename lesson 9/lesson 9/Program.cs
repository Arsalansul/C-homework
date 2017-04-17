using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            char c = s1[1];
            Console.WriteLine("\n"+s1);
            string.IsNullOrEmpty(s1);
            string s2 = "world";
            int a = string.Compare(s1, s2);
            Console.WriteLine(a);
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());
            
            if (s1.Contains("Hello"))
                Console.WriteLine("Yes");

            Console.WriteLine(s1.IndexOf("lo"));
            Console.WriteLine(s1.StartsWith("He"));

            Console.WriteLine(s1.Insert(2, "123"));

            Console.WriteLine(s1.Remove(3));
            Console.WriteLine(s1.Remove(3, 1));

            Console.WriteLine(s1.Substring(2));
            Console.WriteLine(s1.Substring(2, 2));

            Console.WriteLine(s1.Replace("l", "S"));

            char[] array = s1.ToCharArray();
            Console.WriteLine(array[1]);

            string[] split = s1.Split('e');
            Console.WriteLine(split[1]);
            Console.ReadKey();

            //1st task
            string s = "Nikolay,Nikolay,Nikolay,Nikolay,Nikolay,Pavel";
            Console.WriteLine(s.Replace("Nikolay", "Oleg"));
            Console.ReadKey();

            //2nd task
            string text = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были111 описаны основные операторы и методы, которые используются для работы со строками";
            Console.WriteLine(text.Substring(text.IndexOf("Были")));
            Console.ReadKey();

            //3rd task
            string logins = "Login1,LOgin2,login3,loGin4";
            string loginsLow = logins.ToLower();
            string[] login = loginsLow.Split(',');
            Console.WriteLine(login[1]);
            Console.ReadKey();

        }
    }
}
