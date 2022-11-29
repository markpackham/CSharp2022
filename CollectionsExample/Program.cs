// See https://aka.ms/new-console-template for more information
using System.Collections;
// used for dictionaries
using System.Collections.Generic;

#region ArrayList Code
Console.WriteLine("------------------------");
Console.WriteLine("ArrayList Code");
Console.WriteLine("------------------------");

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

// Convert an ArrayList into a string array
ArrayList arrayList3 = new ArrayList() {"Alpha","Bravo","Charlie","Delta"};
string[] myStingArray = (string[])arrayList3.ToArray(typeof(string));

// Convert a string array into an ArrayList
string[] customers = { "Bob", "Sally", "Sue" };
ArrayList custArrayList = new ArrayList();
custArrayList.AddRange(customers);

#endregion


// ---------- DICTIONARIES ----------
#region Dictionary Code
Console.WriteLine("------------------------");
Console.WriteLine("Dictionary Code");
Console.WriteLine("------------------------");

// Dictionaries store key value pairs
// To create them define the data
// type for the key and the value
Dictionary<string, string> superheroes = new Dictionary<string, string>();

superheroes.Add("Clark Kent", "Superman");
superheroes.Add("Bruce Wayne", "Batman");
superheroes.Add("Wally West", "Flash");

// Remove a key / value
superheroes.Remove("Wally West");

// Number of keys
Console.WriteLine("Count : {0}",
    superheroes.Count);

// Check if a key is present
Console.WriteLine("Clark Kent : {0}",
    superheroes.ContainsKey("Clark Kent"));

// Get the value for the key and store it
// in a string

superheroes.TryGetValue("Clark Kent", out string test);

Console.WriteLine($"Clark Kent : {test}");

// Cycle through key value pairs
foreach (KeyValuePair<string, string> item in superheroes)
{
    Console.WriteLine("{0} : {1}",
        item.Key,
        item.Value);
}

// Clear a dictionary
superheroes.Clear();


#endregion


// ---------- QUEUES ----------
#region Queue Code
Console.WriteLine("------------------------");
Console.WriteLine("Queue Code");
Console.WriteLine("------------------------");

// Queue 1st in 1st Out Collection
// Queues are old school

// Create a Queue
Queue queue = new Queue();

// Add values
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

// Is item in queue
Console.WriteLine($"1 in Queue : {queue.Contains(1)}");

// Remove 1st item from queue
Console.WriteLine($"Remove 1 : {queue.Dequeue()}");

// Look at 1st item but don't remove
Console.WriteLine($"Peek 1 : {queue.Peek()}");

// Copy queue to array
object[] numArray = queue.ToArray();

// Print array
Console.WriteLine(string.Join(",", numArray));

// Print queue items
foreach (object o in queue)
{
    Console.WriteLine($"Queue : {o}");
}

// Clear the queue
queue.Clear();


#endregion


// ---------- STACKS ----------
#region Stacks Code
Console.WriteLine("------------------------");
Console.WriteLine("Stacks Code");
Console.WriteLine("------------------------");

// Stack Last in 1st Out Collection (also old school) like a stack of plates to be washed

Stack stack= new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine($"Peek 1: {stack.Peek()}");
Console.WriteLine($"Pop 1: {stack.Pop()}");
Console.WriteLine($"Contains 1: {stack.Contains(1)}");

#endregion