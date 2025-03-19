#region Dizi Tanımlama
int[] dizi = new int[5]; //boş bir dizi oluşturur
dizi[0] = 5;
dizi[1] = -3;
dizi[2] = 325;
dizi[3] = 14;
dizi[4] = 0;
int[] dizi1 = new int[] { 1, -9, -20 }; //3 elemanlı bir dizi oluşturur
string[] dizi2 = { "ali", "ahmet", "ayşe", "fatma" }; //4 elemanlı bir dizi oluşturur
object[] dizi3 = new object[3] { 2, "üç", false }; //3 elemanlı bir dizi oluşturur
#endregion

#region Diziler ve Döngüler
Console.WriteLine("\tFor Döngüsü:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\t{i}. eleman = {dizi[i]}");
}

Console.WriteLine("\t----------------------");
Console.WriteLine("\tWhile döngüsü:");

int k = 0;

while (k < 5)
{
    Console.WriteLine($"\t{k}. eleman = {dizi[k]}");
    k++;
}

int l = 0;

Console.WriteLine("\t----------------------");
Console.WriteLine("\tDo While döngüsü:");

do
{
    Console.WriteLine($"\t{l}. eleman = {dizi[l]}");
    l++;
} while (l < 5);

#endregion

#region Dizi Sınırını Aşmak
//for (int i = 0; i <= 5; i++)
//{
//    Console.WriteLine($"\t{i}. eleman = {dizi[i]}");
//}
#endregion

#region Örnek 1
//Kullanıcıdan kaç adet sayı gireceğini alıp toplamlarını ekrana yazdıralım.

Console.WriteLine();
int[] array;

Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
int count = int.Parse(Console.ReadLine());
array = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}. sayı: ");
    array[i] = int.Parse(Console.ReadLine());
}

int sum = 0;

for (int i = 0; i < count; i++)
{
    sum += array[i];
}

Console.WriteLine("Girdiğiniz sayıların toplamı: {0}", sum);

Console.WriteLine("");
Console.WriteLine("---------------------------");
Console.WriteLine("");
#endregion

#region ForEach Döngüsü
string[] names = { "Chloe", "Ralph", "Yusuf", "Megan", "Ella" };
foreach (string item in names)
{
    Console.WriteLine("\t" + item);
}
#endregion

#region String
string ad = "Derya";
Console.WriteLine();
for (int i = 0; i < ad.Length; i++) //length metodu bize o dizinin boyutunu verir
{
    Console.WriteLine("\t" + ad[i]);
}
Console.WriteLine();
#endregion

#region Örnek 2
//Girilen isimde her harften kaç tane bulunduğunu hesaplayan program
Console.WriteLine();
Console.WriteLine("Lütfen bir isim giriniz: ");
string name = Console.ReadLine();
char[] letters = name.ToCharArray(); //Bu metot sayesinde isim içerisindeki harfleri bir char dizisi olarak alabileceğiz.
byte[] counter = new byte[name.Length];

for (int i = 0; i < letters.Length; i++)
{
    for (int j = 0; j < name.Length; j++)
    {
        if (letters[i] == name[j])
        {
            counter[i]++;
        }
    }
}

Console.WriteLine($"{name} isminde ");

for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"{counter[i]} adet {letters[i]} harfi bulunmaktadır.");
}

Console.WriteLine();
#endregion

#region Örnek 3
//Kullanıcının girdiği kelimedeki sesli harfleri bulan program
Console.WriteLine();
Console.WriteLine("Bir kelime giriniz");
string word = Console.ReadLine();

char[] vowelLetters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

byte counterValue = 0;

for (int i = 0; i < word.Length; i++)
{
    for (int j = 0; j < vowelLetters.Length; j++)
    {
        if (word[i] == vowelLetters[j])
        {
            counterValue++;
        }
    }
}

Console.WriteLine($"{word} kelimesinde {counterValue} adet sesli harf bulunmaktadır.");
Console.WriteLine();
#endregion

#region Çok Boyutlu Diziler
string[,] values = new string[2, 3];
values[0, 0] = "A";
values[0, 1] = "B";
values[0, 2] = "C";
values[1, 0] = "Ç";
values[1, 1] = "D";
values[1, 2] = "E";

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"values[{i},{j}] = {values[i, j]}");
    }
}

Console.WriteLine();
#endregion

#region Örnek 4
Console.WriteLine();

int[,] satisMiktari = new int[3, 3];
//Bitter
satisMiktari[0, 0] = 520; //Ocak
satisMiktari[0, 1] = 600; //Şubat
satisMiktari[0, 2] = 450; //Mart
                          //Sütlü
satisMiktari[1, 0] = 700; //Ocak
satisMiktari[1, 1] = 250; //Şubat
satisMiktari[1, 2] = 300; //Mart
                          //Beyaz
satisMiktari[2, 0] = 400; //Ocak
satisMiktari[2, 1] = 600; //Şubat
satisMiktari[2, 2] = 250; //Mart

//Sütlü Çikolatanın 3 aylık otalama satış miktarı
double ort = 0;

for (int i = 0; i < 3; i++)
{
    ort += satisMiktari[1, i];
}

ort /= 3;

Console.WriteLine($"Ortalama satış miktarı: {ort}");
Console.WriteLine();
#endregion

#region Örnek 5
//Tüm çikolata türleri için 3 aylık satış toplamlarını hesaplayalım.
Console.WriteLine();
int[] tur = new int[3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        tur[i] += satisMiktari[i, j];
    }
}

for (int i = 0; i < 3; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine($"Bitter çikolata satış toplamı: {tur[i]}");
            break;
        case 1:
            Console.WriteLine($"Sütlü çikolata satış toplamı: {tur[i]}");
            break;
        case 2:
            Console.WriteLine($"Beyaz çikolata satış toplamı: {tur[i]}");
            break;
    }
}

Console.WriteLine();
#endregion

#region Jagged Arrays (İç içe geçmiş diziler)
Console.WriteLine();

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { -1, 0, 2, 6, 9, 3 };

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"jaggedArray[{i}][{j}] = {jaggedArray[i][j]}");
    }
}
#endregion

Console.ReadKey();