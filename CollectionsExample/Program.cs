// See https://aka.ms/new-console-template for more information
using System.Collections;
// used for dictionaries
using System.Collections.Generic;

#region ArrayList Code

ArrayList arrayList= new ArrayList();
ArrayList arrayList2= new ArrayList();

arrayList.Add("Billy");
arrayList.Add(40);
Console.WriteLine($"Count {arrayList.Count}");
Console.WriteLine($"Capacity {arrayList.Capacity}");

arrayList2.AddRange(new object[] {"Jake","Neil","Jim","Zeuz","Joe","James","Xenu","Jeff","Jahn","Zena" });
arrayList.AddRange(arrayList2);

arrayList2.Sort();
arrayList2.Reverse();

arrayList.Insert(1, "Turkey");
arrayList2.RemoveAt(0);
arrayList2.RemoveRange(0, 1);
Console.WriteLine($"{arrayList.IndexOf("Turkey")}");
Console.WriteLine($"There is no Turkey in arrayList2 so it's minus one {arrayList2.IndexOf("Turkey")}");

foreach(object item in arrayList)
{
    Console.WriteLine(item);
}

string[] myArray = (string[])arrayList.ToArray(typeof(string));

string[] customers = { "Bob", "Sally", "Sue" };
ArrayList custArrayList = new ArrayList();
custArrayList.AddRange(customers);

#endregion