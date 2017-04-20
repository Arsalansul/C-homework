using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Console.WriteLine("Enter number");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                result = "вы ввели" + a;

            }
            catch (FormatException)
            {
                result = "ввели не число";
            }
            finally
            {
                Console.WriteLine(result);
            }
            

            //HW
            int[] array = {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine("введите 1 число");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите 2 число");
                int j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(array[i] + array[j]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("индекс вне рамок массива"); 
            }
            Console.ReadKey();

        }
    }
}
