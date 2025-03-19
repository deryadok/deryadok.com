#region Switch-Case Yapısı
//int num = 0;
//Console.WriteLine("Üçe kadar bir değer giriniz: ");
//num = Convert.ToInt32(Console.ReadLine());
//switch (num)
//{
//    case 1:
//        Console.WriteLine("Girdiğiniz değer bir.");
//        break;
//    case 2:
//        Console.WriteLine("Girdiğiniz değer iki.");
//        break;
//    case 3:
//        Console.WriteLine("Girdiğiniz değer üç.");
//        break;
//} 
#endregion

#region default
//int age = 89;
//switch (age)
//{
//    case 19:
//        Console.WriteLine("Genç");
//        break;
//    case 42:
//        Console.WriteLine("Yetişkin");
//        break;
//    case 70:
//        Console.WriteLine("Yaşlı");
//        break;
//    default:
//        Console.WriteLine("Default");
//        break;
//}
#endregion

#region break ifadesiz switch case
int number = 1;
switch (number)
{
    case 1:
    case 3:
    case 4:
        Console.WriteLine("Girilen sayı ilk dört sayıdan biri");
        break;
    case 2:
        Console.WriteLine("Girilen sayı ikidir");
        break;
    case 5:
    case 6:
        Console.WriteLine("Girilen sayı ilk dört sayıdan biri değildir");
        break;
    default:
        Console.WriteLine("Girilen sayı farklı bir sayıdır");
        break;
}
#endregion

Console.ReadKey();