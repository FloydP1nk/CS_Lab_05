// See https://aka.ms/new-console-template for more information

using Lab_05_1;


MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
dictionary.Add(1, "One");
dictionary.Add(2, "Two");
dictionary.Add(3, "Three");

Console.WriteLine("Count: " + dictionary.Count);
Console.WriteLine("Value for key 2: " + dictionary[2]);

Console.WriteLine("Iterating over dictionary: ");
dictionary.Iterate();