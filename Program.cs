using System.Text;

// Create Read Update Delete
// CRUD

// Create
string petInstrument = "Violin";

// Concatenation
petInstrument = "Stentor " + petInstrument;

// Template Literal: allows us to create strings in complex fashion
Console.WriteLine($"I AM BUYING A {petInstrument}. YOU CANNOT STOP ME!!!");
Console.WriteLine("\n");

Console.WriteLine(petInstrument);
Console.WriteLine("\n");

// READ
// Console.WriteLine()


// UPDATE
// Using the concept of immutability is the right way, but we will be using the nonimmutable way
// javascript concept that will not work
// petInstrument[1] = "t";
string newInstrument = petInstrument.Replace("Stentor", "Hallmark");
Console.WriteLine(newInstrument);


// DELETE
// String Builder: will allow you manipulate strings without the actual c# compiler creating over and over, because you might not really want to delete strings from the memory.
StringBuilder newPercussion = new StringBuilder();
newPercussion.Append("Complete Drums");
Console.WriteLine(newPercussion);

// To delete things from strings
newPercussion.Remove(0, 9);
Console.WriteLine(newPercussion);