using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_24
{
    public class ConvertMoney
    {       
        public static void RurToUsd(string unit, Money a)
        { 
            decimal kurs = 60;
            if (unit == "USD")
                a.Amount = a.Amount / kurs;
            else
                a.Amount = a.Amount * kurs;
            a.Unit = unit;            
        }
    }

    public class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Unit != b.Unit)
                //throw new InvalidOperationException("Нельзя суммировать деньги разных валют");
                ConvertMoney.RurToUsd(b.Unit,a);
            return new Money(a.Amount + b.Amount, a.Unit);
        }
        public static Money operator ++(Money a)
        {
            a.Amount++;
            return a;
        }
        public static Money operator --(Money a)
        {
            a.Amount--;
            return a;
        }
        public static string operator +(string text, Money a)
        {
            return text + a.Amount + " " + a.Unit;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money MyMoney=new Money(35,"RUR");
            Money HisMoney=new Money(100,"USD");
            Money HerMoney=new Money(50,"USD");

            Money sum=MyMoney+HisMoney;
            Console.WriteLine(sum.Amount);
            sum=HisMoney+HerMoney;
            Console.WriteLine(sum.Amount);
            MyMoney++;
            HisMoney--;
            Console.WriteLine("у меня " + MyMoney);

            
            Console.ReadKey();
        }
    }
}
