using System;

namespace Animalbstract
{
    abstract class Animal
    {
        public abstract void Animaleatinghabit();


    }
    class Herbivores : Animal
    {
        public override void Animaleatinghabit()
        {
            Console.WriteLine("Eats only vegetable");
        }
        public void Demo()
        {
            Console.WriteLine(".............");
        }
    }
    class Carnivores : Animal
    {
        public override void Animaleatinghabit()
        {
            Console.WriteLine("Eats other Animal");
        }
    }

    class Program
    {
      
        public void CallFun(Animal a)
        {
            if(a.GetType() == typeof(Herbivores))
            {
                Herbivores H = (Herbivores)a;
                H.Demo();
            }
            a.Animaleatinghabit();
        }
        static void Main(string[] args)
        {

            Herbivores h = new Herbivores();
            Carnivores c = new Carnivores();
            Animal h1 = new Herbivores();
            h.Animaleatinghabit();
            c.Animaleatinghabit();
            Program p = new Program();
            p.CallFun(h1);
         
            //Console.WriteLine("Hello World!");
        }
    }
}
