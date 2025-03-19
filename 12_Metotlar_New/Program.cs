#region Pass by value
using _12_Metotlar_New;

int sayi = 50;
string deger = "ESKİ";

Console.WriteLine("Before value type {0}", sayi);
Console.WriteLine("Before reference type {0}", deger);
Console.WriteLine("-----------");

StaticMethods.PassValueType(sayi);
StaticMethods.PassReferenceType(deger);

Console.WriteLine("After value type {0}", sayi);
Console.WriteLine("After reference type {0}", deger);
Console.WriteLine("-----------");
#endregion

#region REF
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
int number = 10;
Console.WriteLine("Önce: {0}", number);
StaticMethods.Change(ref number);
Console.WriteLine("Sonra: {0}", number);
number = 158;
Console.WriteLine("Main Değişim: {0}", number);
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region REF Örnek
//Stringlerin değerlerini değiştirmek
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
string value1 = "Kedi", value2 = "Köpek";
Console.WriteLine("Before: {0} - {1}", value1, value2);
StaticMethods.Swap(ref value1, ref value2);
Console.WriteLine("After: {0} - {1}", value1, value2);
Console.WriteLine();
Console.WriteLine("------------");
#endregion

#region Array Resize Method
//Array'in boyutunu girilen değer kadar arttırmak
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
int[] numbers = { 1, 96, 36, 21, 10, 3 };
Console.WriteLine("Array Size: {0}", numbers.Length);
StaticMethods.ArrayResize(ref numbers, 10);
Console.WriteLine("New Array Size: {0}", numbers.Length);
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region OUT
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
char letter;
string text = StaticMethods.GetWordAndFirstLetter(out letter);
Console.WriteLine($"İlk Harf: {letter}");
Console.WriteLine($"Metin: {text}");
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region OUT Örnek
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
//Kullanıcıdan alınan sayının tam kısmı ile ondalık kısmını ayırmak
Console.Write("Parçalanacak Ondalıklı Sayı: ");
decimal num = decimal.Parse(Console.ReadLine());
decimal floating;
int integer = StaticMethods.GetParts(num, out floating);
Console.WriteLine("Tam Kısım = {0}  -  Ondalıklı Kısım = {1}", integer, floating);
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region Custom TryParse
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
//Kendi TryParse Metotumuzu Yazma
Console.WriteLine("Bir sayı giriniz: ");
string value = Console.ReadLine();
int numberVal;
bool isConverted = StaticMethods.TryParse(value, out numberVal);
if (isConverted)
{
    Console.WriteLine("Girdiğiniz değer int çevirildi. {0}", numberVal);
}
else
{
    Console.WriteLine("Girdiğiniz değer çevrilemedi");
}
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region Method Overloading
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
Console.WriteLine("1. Metot: {0} ", StaticMethods.Toplama(1, 5));
Console.WriteLine("2. Metot: {0} ", StaticMethods.Toplama(101.65, 5.5));
Console.WriteLine("3. Metot: {0} ", StaticMethods.Toplama(78, 52, 74));
Console.WriteLine("4. Metot: {0} ", StaticMethods.Toplama(125, 74, 25));
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region Method Overloading Örneği
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
StaticMethods.SendMail("dunya@mail.com", "mars@mail.com", "Merhaba", "Merhaba Dünya!");
string[] to = { "ali@mail.com", "ayse@mail.com", "bulent@mail.com" };
StaticMethods.SendMail(to, "derya@mail.com", "Toplantı", "Toplantı 1 saat sonraya ertelenmiştir");
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region Recursive Metotlar
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
Console.WriteLine("Kaçıncı Fibonacci sayısını görmek istiyorsunuz?");
int order = int.Parse(Console.ReadLine());
Console.WriteLine($"{order}. Fibonacci Sayısı: {StaticMethods.Fibonacci(order)}");
Console.WriteLine();
Console.WriteLine("-----------");
#endregion

#region Recursive Faktöriyel
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();
Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
int factorial = int.Parse(Console.ReadLine());
Console.WriteLine($"{factorial}! = {StaticMethods.Factorial(factorial)}");
Console.WriteLine();
Console.WriteLine("-----------");

#endregion

#region Recursive Pascal
Console.Write("Görmek istediğiniz satır: ");
int row = int.Parse(Console.ReadLine());
int[] pascal = StaticMethods.Pascal(row);
foreach (int item in pascal)
{
    Console.WriteLine(item + " ");
}
#endregion

Console.ReadKey();

