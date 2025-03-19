using _15_OOP_Kapsulleme_Encapsulation_New;

//Elma elma = new Elma();

//elma.SetAgirlik(770);
//elma.SetHacim(30);

//elma.SetAgirlik(220);
//elma.SetHacim(10);

//Console.WriteLine("Ağırlık : " + elma.GetAgirlik());
//elma.GetHacim("4523");
//elma.GetHacim("1234");


Person person = new Person();

person.SetName("Marty");
person.Surname = "McFly";
person.EMail = "marty@mcfly.com";

Console.WriteLine("İsim: " + person.GetName());
Console.WriteLine("Soyisim: " + person.Surname);
Console.WriteLine("E-Mail: " + person.EMail);


Console.ReadKey();