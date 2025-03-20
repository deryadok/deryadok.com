#region Nongenericlist - GenericList
//MyNongenericList nonGenericList = new MyNongenericList();
//nonGenericList.Add(5);
//nonGenericList.Add(6);
//nonGenericList.Add(7);
//nonGenericList.Add("Example");

//foreach (var item in nonGenericList)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("------------------------------");

//MyGenericList<int> myGenericList = new MyGenericList<int>();
//myGenericList.Add(5);
//myGenericList.Add(6);
//myGenericList.Add(7);
////myGenericList.Add("Example");

//foreach (int item in myGenericList)
//{
//    Console.WriteLine(item.ToString());
//}
#endregion

#region Performance Test
//MyNongenericList myNongenericList = new MyNongenericList();
//MyGenericList<int> myGenericList = new MyGenericList<int>();

//int value = 0;

//DateTime start = DateTime.Now;
//for (int i = 0; i < 1000000; i++)
//{
//    myNongenericList.Add(i);
//}
//for (int i = 0; i < 1000000; i++)
//{
//    value = (int)myNongenericList[i];
//}
//DateTime end = DateTime.Now;
//TimeSpan diff = end - start;
//Console.WriteLine("NonGeneric : " + diff.TotalMilliseconds.ToString());

//Console.WriteLine("--------------------");

//start = DateTime.Now;
//for (int i = 0; i < 1000000; i++)
//{
//    myGenericList.Add(i);
//}
//for (int i = 0; i < 1000000; i++)
//{
//    value = myGenericList[i];
//}
//end = DateTime.Now;
//diff = end - start;
//Console.WriteLine("Generic : " + diff.TotalMilliseconds.ToString());
#endregion

#region GenericMethod
//GenericMethodHelper.FindMax<int>(2, 5);

//GenericMethodHelper.SendMail<string>(SystemMembers.Admin, "");
#endregion

#region Generic Interface
//IntegerAdd integerAdd = new IntegerAdd();
//Console.WriteLine(integerAdd.Add(5, 6));

//StringAdd stringAdd = new StringAdd();
//Console.WriteLine(stringAdd.Add("Hello", "World!"));
#endregion

#region Generic Inheritance
//SecondClass s = new SecondClass();
//s.GetType(5);

//ThirdClass<string> t = new ThirdClass<string>();
//t.GetType("Hello World");
#endregion

#region Multiple Generic Type
//MultipleGenericType<string, int, bool> multiple = new MultipleGenericType<string, int, bool>();
//multiple.TProperty = "Hello World";
//multiple.UProperty = 5;
//multiple.KProperty = false;
#endregion

#region Generic Constraints

#endregion

Console.ReadLine();