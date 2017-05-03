using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_22
{
    interface IGeometrical
    {
        void Perimetr();
        void Ploshad();
        
    }
    interface IDrawable
    {
        void Draw();
    }
    class Rectangle:IGeometrical, IDrawable
    {
        public void Perimetr()
        {
            Console.WriteLine("(a+b)*2");
        }
        public void Ploshad()
        {
            Console.WriteLine("a*b");
        }
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Circle:IGeometrical, IDrawable
    {
        public void Perimetr()
        {
            Console.WriteLine("2*Pi*r");
        }
        public void Ploshad()
        {
            Console.WriteLine("Pi*r*r");
        }
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }

    interface ISwitchable
    {
        void SwitchOn();
        void SwitchOff();
    }
    class TVSet: ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("TV Vkluchen");
        }
        public void SwitchOff()
        {
            Console.WriteLine("TV Vikluchen");
        }
    }
    class PC: ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("PC Vkluchen");
        }
        public void SwitchOff()
        {
            Console.WriteLine("PC Vikluchen");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IGeometrical> f = new List<IGeometrical>();
            f.Add(new Rectangle());
            f.Add(new Circle());
            foreach(IGeometrical figure in f)
            {
                figure.Perimetr();
                figure.Ploshad();
                
            }
            List<ISwitchable> device = new List<ISwitchable>();
            device.Add(new TVSet());
            device.Add(new PC());
            foreach(ISwitchable d in device)
            {
                d.SwitchOn();
                d.SwitchOff();
            }
            Console.ReadKey();
        }
    }
}
