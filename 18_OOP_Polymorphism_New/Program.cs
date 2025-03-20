//Dog dog1 = new Dog();
//Console.WriteLine(dog1.MakeNoise());

//Cat cat1 = new Cat();
//Console.WriteLine(cat1.MakeNoise());

using _18_OOP_Polymorphism_New.BusinessApp;

Staff staff = new Staff();
staff.Name = "Biff";
staff.Lastname = "Tannen";
staff.DailyWage = 10;
staff.WorkDays = 20;

Worker worker = new Worker();
worker.Name = "Marty";
worker.Lastname = "McFly";
worker.DailyWage = 10;
worker.WorkDays = 20;

Manager manager = new Manager();
manager.Name = "Emmett";
manager.Lastname = "Brown";
manager.DailyWage = 10;
manager.WorkDays = 20;

Intern intern = new Intern();
intern.Name = "Lorraine";
intern.Lastname = "Baines";
intern.DailyWage = 10;
intern.WorkDays = 20;

Console.WriteLine("Staff: " + staff.Name + " " + staff.Lastname + " Salary: " + staff.Salary);
Console.WriteLine("Staff: " + worker.Name + " " + worker.Lastname + " Salary: " + worker.Salary);
Console.WriteLine("Staff: " + manager.Name + " " + manager.Lastname + " Salary: " + manager.Salary);
Console.WriteLine("Staff: " + intern.Name + " " + intern.Lastname + " Salary: " + intern.Salary);

Console.ReadKey();