static bool Condition1() { return true; }
static bool Condition2() { return false; }

#region Ve Mantıksal Operatörü
//bool a = false;
//bool b = false;
//Console.WriteLine(a && b);

//bool c = false;
//bool d = true;
//Console.WriteLine(c && d);

//bool e = true;
//bool f = false;
//Console.WriteLine(e && f);

//bool g = true;
//bool h = true;
//Console.WriteLine(g && h);
#endregion

#region Veya Mantıksal Operatörü
//bool a = false;
//bool b = false;
//Console.WriteLine(a||b);

//bool c = false;
//bool d = true;
//Console.WriteLine(c||d);

//bool e = true;
//bool f = false;
//Console.WriteLine(e||f);

//bool g = true;
//bool h = true;
//Console.WriteLine(g||h);
#endregion

#region && ve & arasındaki Fark 
//if (Condition2() && Condition1())
//{
//    Console.WriteLine("");
//}
//else if (Condition2() & Condition1())
//{
//    Console.WriteLine("");
//} 
#endregion

#region || ve | arasındaki Fark 
//if (Condition2() || Condition1())
//{
//    Console.WriteLine("");
//}
//else if (Condition2() | Condition1())
//{
//    Console.WriteLine("");
//} 
#endregion

#region Null Coalescing
//int? val1 = null;
//int? val2 = 5;

//int val3 = val1 ?? 105;
//int val4 = val2 ?? 105;

//Console.WriteLine($"Val3: {val3}");
//Console.WriteLine($"Val4: {val4}");
#endregion

#region Ternary If
Random rnd = new Random();
int age = rnd.Next(100);
int guess = 0;
string message = "";
Console.WriteLine("Yaşı tahmin et. :)");
do
{
    guess = int.Parse(Console.ReadLine());
    message = guess < age ? "Biraz büyük bir sayı gir. :)" : "Biraz küçük bir sayı gir. :)";
    Console.WriteLine(message);
} while (guess != age);
Console.WriteLine("Tebrikler! Bildin. :)");

#endregion

Console.ReadKey();