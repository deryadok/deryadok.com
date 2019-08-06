using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DoWhileDonguYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //int a = 0;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a < 5); 
            #endregion

            #region Do While While Karşılaştırması
            //int x = 42;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < 10);

            //int y = 42;
            //while (y < 10)
            //{
            //    Console.WriteLine(y);
            //    y++;
            //} 
            #endregion

            int sum = 0, num = 0;
            bool flag = false, flag1 = false;
            string isOk = string.Empty;
            ConsoleKeyInfo answer;

            do
            {
                //Konsol ekranını temizlemek için kullanılır.
                //Console.Clear();
                //Program yeniden başladığında toplamın içerisindeki değerin temizlenmesi gerekir.
                sum = 0;
                Console.WriteLine("\nSayı girişini sonlandırmak için tamam yazabilirsiniz.");
                do
                {
                    isOk = Console.ReadLine();
                    //Kullanıcıdan aldığımız cevabın kontrolü yapılır.
                    flag = isOk != "TAMAM" && isOk != "Tamam" && isOk != "tamam";

                    if (flag)
                    {
                        /*TryParse metodu Convert metodu gibi çalışır. İçerisine aldığı string değerini integer değişkene atar. String değer sayıya dönüştürülebiliyorsa sonuç true, dönüştürülemiyorsa false döner (out anahtar kelimesini daha detaylı inceleyeceğiz)*/
                        flag1 = int.TryParse(isOk, out num);

                        //Kullanıcı geçerli bir sayı girene kadar kullanıcıya uyarı vermeye devam edilecek.
                        //Kullanıcı tamam yazdıysa programdan çıkılacak
                        while (!flag1 && flag)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                            isOk = Console.ReadLine();
                            flag = isOk != "TAMAM" && isOk != "Tamam" && isOk != "tamam";
                            flag1 = int.TryParse(isOk, out num);
                        }

                        //Kullanıcının girdiği sayıların toplamının alındığı kısım.
                        sum += num;
                    }
                    //Kullanıcı tamam dışında değer girmeye devam ettikçe sayı almaya devam edilecek.
                } while (flag);
                Console.WriteLine($"Girdiğiniz sayıların toplamı: {sum}");
                Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz? E|H");

                /*ReadKey metodu klavyeden basılan tuşu yakalamamızı sağlar. Bu sayede kullanıcı E dışında bir tuşa bastığında programı sonlandırabiliriz. Dilerseniz buraya if kontrolü koyup E ya da H dışında bir tuşa basıldığında hata mesajı gösterebilirsiniz.*/
                answer = Console.ReadKey();
            } while (answer.Key == ConsoleKey.E);
        }
    }
}
