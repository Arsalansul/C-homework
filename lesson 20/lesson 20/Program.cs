using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_20
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Human\nName: " + Name);
            Console.WriteLine("Age: " + Age);
        }
           
    }
    class Student:Human
    {
        public string HighSchoolName { get; set; }
        public Student(string name, int age, string highschoolname):base(name,age)
        {
            HighSchoolName = highschoolname;
        }

        public override void ShowInfo()
        {
            //Console.WriteLine("Human\nName: " + Name + "\n"+"Age: " + Age + "\n"+"High School name: " + HighSchoolName + "\n");
            base.ShowInfo();
            Console.WriteLine("High School name: " + HighSchoolName + "\n");
        }
    }
    class Pupil:Human
    {
        public string Form { get; set; }    
        public Pupil(string name, int age, string form):base(name,age)
        {
            Form = form;
        }
        public override void ShowInfo()
        {
            //Console.WriteLine("Human\nName: " + Name + "\n" + "Age: " + Age + "\n" + "Form: " + Form + "\n");
            base.ShowInfo();
            Console.WriteLine("Form: " + Form + "\n");
        }
    }

    class Warrior:Human
    {
        public int Health { get; set; }
        
        public Warrior(string name, int age, int health):base(name,age)
        {
            Health = health;
        }
        public virtual void HealthAtThisMoment(int damage)
        {
            Health = Health -damage;
        }
    }
    class WarriorInLightArmor:Warrior
    {
        public double LightArmor { get; set; }
        
        public WarriorInLightArmor(string name, int age, int health, double armor):base(name, age, health)
        {
            LightArmor = armor;
        }
        public override void HealthAtThisMoment(int damage)
        {
            Health= Health-(int)Math.Ceiling(LightArmor*damage);
        }
    }
    class WarriorInHeavyArmor:Warrior
    {
        public double HeavyArmor { get; set; }
        
        public WarriorInHeavyArmor(string name, int age, int health, double heavyarmor):base(name,age,health)
        {
            HeavyArmor = heavyarmor;
        }
        public override void HealthAtThisMoment(int damage)
        {
            Health = Health -(int) Math.Ceiling(HeavyArmor * damage * 0.5);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List < Human > humans= new List<Human>();
            humans.Add(new Human("Ivan", 32));
            humans.Add(new Student("Petr", 18, "NSU"));
            humans.Add(new Pupil("Dasha", 7, "1-a"));
            foreach(Human human in humans)
            {
                human.ShowInfo();
            }
            List<Warrior> warriors = new List<Warrior>();
            warriors.Add(new Warrior("Vasy", 32, 100));
            warriors.Add(new WarriorInLightArmor("Trus", 24, 60, 0.8));
            warriors.Add(new WarriorInHeavyArmor("Tank", 40, 200, 0.2));
            foreach(Warrior warrior in warriors)
            {                
                warrior.HealthAtThisMoment(50);
                Console.WriteLine(warrior.Name+" "+warrior.Health);
            }
            Console.ReadKey();
        }
    }
}
