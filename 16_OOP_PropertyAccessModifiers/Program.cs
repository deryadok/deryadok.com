using _16_OOP_MathLibrary;
using System;
using System.Collections.Generic;

namespace _16_OOP_PropertyAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //PowMethod pow = new PowMethod();

            //pow.Base = 5;
            //pow.Pow = 3;

            //PowMethod pow = new PowMethod() //Type Initializer
            //{
            //    Base = 5,
            //    Pow = 3
            //};

            //Console.WriteLine("Taban: " + pow.Base + "\nÜs: " + pow.Pow);
            ////Hesaplama Metotları
            //pow.CalculatePublicMethod(); //SADECE PUBLIC ERISIM BELIRLEYICISINI KULLANABILIYORUM
            //Console.WriteLine("Sonuç: " + pow.Result);

            //Anonymous Types
            //var person = new { Name = "Marty", Surname = "McFly" };

            //Console.WriteLine("Anonim tip nesne:");
            //Console.WriteLine("Ad:" + person.Name + "\nSoyad" + person.Surname);

            Classroom pisagor = new Classroom("202", 4);
            pisagor.Students.Add(new Student()
            {
                Name = "Derya",
                Surname = "Dok",
                Gender = 'K'
            });
            pisagor.Students.Add(new Student()
            {
                Name = "Mert",
                Surname = "Altıntaş",
                Gender = 'E'
            });
            pisagor.Students.Add(new Student()
            {
                Name = "Mustafa Mert",
                Surname = "Oğuz",
                Gender = 'E'
            });
            pisagor.Students.Add(new Student()
            {
                Name = "Miray",
                Surname = "Dopdoğru",
                Gender = 'K'
            });

            Console.WriteLine();
            Console.WriteLine("Bütün Öğrenciler");
            //Bütün öğrencileri yazdır
            foreach (Student item in pisagor.Students)
            {
                Console.WriteLine("Ad: " + item.Name + " Soyad: " + item.Surname );
            }
            Console.WriteLine();
            //Sadece kız öğrencileri yazdır
            Console.WriteLine("Kız Öğrenciler");
            List<Student> list = pisagor['K'];
            foreach (Student item in list)
            {
                Console.WriteLine("Ad: " + item.Name + " Soyad: " + item.Surname);
            }
            Console.WriteLine();
            //İndexteki öğrenciyi yazdır normal yöntem

            Console.WriteLine("2. İndeksteki Öğrenci (Normal Yöntem)");
            Student mmo = pisagor.Students[2];
            Console.WriteLine("Ad: " + mmo.Name + " Soyad: " + mmo.Surname);
            //İndexteki öğrenciyi yazdır 
            Console.WriteLine("1. İndeksteki Öğrenci");

            Student ma = pisagor[1];
            Console.WriteLine("Ad: " + ma.Name + " Soyad: " + ma.Surname);

            Console.ReadKey();
            
        }
    }

    class Deneme : PowMethod
    {
        public Deneme()
        {
            CalculatePublicMethod();
            CalculateProtectedMethod();
            CalculateProtectedInternalMethod();
        }
    }
}
