using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_assi
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound");
        }

        public void Run()
        {
            Console.WriteLine("Mammal is running");
        }
    }

    class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Reptile sound");
        }

        public void Crawl()
        {
            Console.WriteLine("Reptile is crawling");
        }
    }

    class  Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird sound");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Lion : Mammal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public void Roar()
        {
            Console.WriteLine("Lion is roaring");
        }
    }

    class Snake : Reptile
    {
        public Snake(string name, int age) : base(name, age)
        {
        }

        public void Hiss()
        {
            Console.WriteLine("Snake is hissing");
        }
    }

    class Eagle : Bird
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public void Soar()
        {
            Console.WriteLine("Eagle is soaring");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal lion = new Lion("Simba", 5);
            Animal snake = new Snake("Kaa", 3);
            Animal eagle = new Eagle("Freedom", 2);

            lion.MakeSound();
            ((Lion)lion).Run();
            ((Lion)lion).Roar();

            snake.MakeSound();
            ((Snake)snake).Crawl();
            ((Snake)snake).Hiss();

            eagle.MakeSound();
            ((Eagle)eagle).Fly();
            ((Eagle)eagle).Soar();
        }
    }
} 
