using _20_OOP_Abstract_vs_Interface.Interface;
using _20_OOP_Abstract_vs_Interface.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathLib mathLib = new MathLib();
            //Console.WriteLine(mathLib.Name);
            //int num1, num2;
            //Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($" Toplam : {mathLib.Addition(num1, num2)} {Environment.NewLine} Çarpım : {mathLib.Multiplication(num1, num2)} \n Fark : {mathLib.Subtraction(num1, num2)} \n Bölüm: {mathLib.Division(num1, num2)}");

            Bird bird = new Bird();
            Plane plane = new Plane();
            Fish fish = new Fish();
            Submarine submarine = new Submarine();
            Duck duck = new Duck();

            Console.WriteLine("-----Kuş-----");
            Console.WriteLine(bird.Fly() + Environment.NewLine + bird.Settle());
            Console.WriteLine("-----Uçak-----");
            Console.WriteLine(plane.Fly() + Environment.NewLine + plane.Settle());
            Console.WriteLine();
            Console.WriteLine("-----Balık-----");
            Console.WriteLine(fish.Swim() + Environment.NewLine + fish.Dive() + Environment.NewLine + fish.GetOut());
            Console.WriteLine("-----Denizaltı-----");
            Console.WriteLine(submarine.Swim() + Environment.NewLine + submarine.Dive() + Environment.NewLine + submarine.GetOut());
            Console.WriteLine();
            Console.WriteLine("-----Ördek-----");
            Console.WriteLine(duck.Fly() + Environment.NewLine + duck.Settle());
            Console.WriteLine(duck.Swim() + Environment.NewLine + duck.Dive() + Environment.NewLine + submarine.GetOut());


            Console.ReadKey();
        }
    }
}
