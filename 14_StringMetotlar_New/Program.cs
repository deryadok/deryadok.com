string quote = " If you want to know what a man's like, take a good look at how he treats his inferiors, not his equals. ― J.K. Rowling, Harry Potter and the Goblet of Fire ";
string date = "25.05.2020 15.40";
string name = "Derya";
string surname = "Dok";

Console.WriteLine();

#region Contains
bool isContain = quote.Contains('e');
Console.WriteLine("Verilen metin 'e' karakterini içerir mi?");
if (isContain)
{
    Console.WriteLine("İçerir");
}
else
{
    Console.WriteLine("İçermez");
}
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Split
string[] splittedText = date.Split(' ');
Console.WriteLine("Tarih: " + splittedText[0]);
Console.WriteLine("Saat: " + splittedText[1]);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Replace
string newQuote = quote.Replace('o', '*');
Console.WriteLine(newQuote);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Substring
string value = quote.Substring(3, 11);
Console.WriteLine(value);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Concat
string fullName = string.Concat(name, surname);
Console.WriteLine("Birleştirilmiş Hali: " + fullName);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Trim
string value1 = quote.Trim();
Console.WriteLine("Trimmed string: " + value1);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region IsNullOrEmpty or IsNullOrWhiteSpace
bool isNull = string.IsNullOrEmpty(quote);
bool isWhiteSpace = string.IsNullOrWhiteSpace(" ");
Console.WriteLine("Null mu? " + isNull);
Console.WriteLine("Boşluk mu? " + isWhiteSpace);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region EndsWith and StartsWith
bool isStart = quote.StartsWith("If");
bool isEnd = quote.EndsWith("you.");

Console.WriteLine("If ile mi başlıyor. " + isStart);
Console.WriteLine("you. ile mi bitiyor. " + isEnd);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region ToLower and ToUpper
Console.WriteLine("ToLower: " + quote.ToLower());
Console.WriteLine();
Console.WriteLine("ToUpper: " + quote.ToUpper());
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region IndexOf and LastIndexOf
int startIndex = quote.IndexOf('a');
int lastIndex = quote.LastIndexOf('o');

Console.WriteLine("a'nın başlangıç indexi: " + startIndex);
Console.WriteLine("o'nun bitiş indexi: " + lastIndex);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Remove
string value2 = quote.Remove(10);
Console.WriteLine("Removed Text: " + value2);
string value3 = quote.Remove(10, 10);
Console.WriteLine("Removed Text: " + value3);
#endregion

Console.WriteLine("\n----------------------------------------------\n");

#region Insert
string value4 = quote.Insert(37, " Harry Potter");
Console.WriteLine("Inserted Text: " + value4);
#endregion

Console.ReadKey();