using _17_OOP_Kalitim_Inheritance_.Constructor;
using _17_OOP_Kalitim_Inheritance_.Inheritance;
using _17_OOP_Kalitim_Inheritance_.NonInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalitim_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non Inheritance
            /*Console.WriteLine("Kalıtım Öncesi");

            Dog dog = new Dog();
            dog.Name = "Odie";
            dog.Legs = 4;
            dog.Age = 2;
            Console.WriteLine("Name : " + dog.Name);
            Console.WriteLine(dog.Bark());
            Console.WriteLine(dog.GoOutside());

            Cat cat = new Cat();
            cat.Name = "Garfield";
            cat.Legs = 4;
            cat.Age = 2;
            Console.WriteLine("Name : " + cat.Name);
            Console.WriteLine(cat.Purr());
            Console.WriteLine(cat.StayInside());*/
            #endregion

            //Console.WriteLine("------------------------------");

            #region Kalıtım
            /*Console.WriteLine("Kalıtım Sonrası");
            DogInherited dogInherited = new DogInherited();
            dogInherited.Name = "Odie";
            dogInherited.Legs = 4;
            dogInherited.Age = 2;
            Console.WriteLine("Name : " + dogInherited.Name);
            Console.WriteLine(dogInherited.MakeNoise("Woof!"));
            Console.WriteLine(dogInherited.GoOutside());

            CatInherited catInherited = new CatInherited();
            catInherited.Name = "Garfield";
            catInherited.Legs = 4;
            catInherited.Age = 2;
            Console.WriteLine("Name : " + catInherited.Name);
            Console.WriteLine(catInherited.MakeNoise("Meow!"));
            Console.WriteLine(catInherited.StayInside());*/
            #endregion

            //Animal animal = new CatInherited();
            //animal.Name = "Felix";
            //animal.Legs = 4;
            //animal.Age = 5;
            //Console.WriteLine("Name : " + animal.Name);
            //Console.WriteLine(animal.MakeNoise("Purr!"));
            ////Console.WriteLine(animal.StayInside());

            //CatInherited cat2 = new CatInherited() { 
            //    Name = "Kitty",
            //    Legs = 4,
            //    Age = 1
            //};

            //Console.WriteLine("Name : " + cat2.Name + " Age: " + cat2.Age);

            GetCar();
            //Car car = new Car();
            //Car car = new Car("Hello car!");

            GC.Collect(); //destructor metodun çağrılması için garbadge collector kullanıyoruz.
            Console.ReadKey();
        }

        private static void GetCar()
        {
            Car car = new Car();
        }
    }
}
