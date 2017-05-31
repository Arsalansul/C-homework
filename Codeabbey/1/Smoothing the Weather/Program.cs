using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Smoothing_the_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "27.9 33.7 39.9 32.8 48.6 39.8 49.0 50.1 47.8 46.4 41.6 35.2 21.7 25.1 21.2 16.1 12.7 17.8 12.2 10.7 21.3 19.4 19.8 24.8 30.1 38.0 53.7 41.4 56.9 49.3 50.0 45.0 49.2 57.4 37.4 35.2 19.1 24.8 14.9 17.0 11.5 17.8 7.9 10.4 12.7 27.5 5.0 13.9 35.1 37.5 40.0 46.3 47.4 56.7 49.0 44.6 48.0 42.9 39.8 35.3 32.1 35.8 22.6 15.9 22.2 25.7 22.9 24.0 12.7 9.5 20.8 28.2 15.9 44.7 35.9 44.1 54.4 45.4 50.1 50.9 58.6 35.9 40.0 35.2 44.1 27.9 20.8 16.4 3.5 0.8 8.6 15.4 -1.4 4.9 19.5 35.0 19.1 34.4 48.6 44.2 47.3 49.4 49.7 49.3 47.3 44.2 54.1 35.1 31.6 24.9 14.4 16.6 13.2 11.0 7.1 11.1 12.6 23.8 19.2 24.8 42.5 35.3 39.6 57.8 47.6 50.1 58.9 50.2 32.3 48.7 38.3 35.2 30.0 25.1 27.7 27.2 8.9 17.5 9.7 19.6 12.7 15.9 20.1 17.7 24.6 39.1 42.1 44.2 48.6 39.8 41.1 50.1 47.8 44.1 40.6 34.2 22.9 24.9 35.0 9.0 12.6 9.0 10.0 15.8 20.1 15.9 23.4 15.9 29.6 30.7 25.0 47.4 48.0 49.5 58.3 53.4 47.3 44.7 39.9 29.6 31.8 24.8 24.5 15.8 21.0 10.7 11.1 -3.0 4.4 16.9 14.2 24.8";
            string[] stroki = stroka.Split(' ');
            double[] array = new double[stroki.Length];
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            for (int i = 0; i < stroki.Length; i++)
            {
                array[i] = Convert.ToDouble(stroki[i], provider);
            }

            Console.Write(array[0] + " ");
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.Write((array[i - 1] + array[i] + array[i + 1]) / 3 + " ");
            }
            Console.WriteLine(array.Last());
            Console.ReadKey();
        }
    }
}
