using Name_Sorter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Program
{
    public static void Main()
    {
        ReadFromTextFile();

        Console.WriteLine();

        SortNames();
    }

    // The ReadFromTextFile function reads a list of names from a text file and returns it in an array
    public static void ReadFromTextFile()
    {
        Console.WriteLine("This is the ReadFromTextFile function.");

        string path = @".\Text_Files\unsorted-names-list.txt";

        var x = FileReaderAndWriter.ReadFromFile(path);

        Console.WriteLine(string.Join("\n", x));

        return;
    }

    // The SortNames function sorts a list of unsorted names alphabetically and returns a list of sorted names.
    public static void SortNames()
    {
        Console.WriteLine("This is the SortNames function.");

        List<Person> peopleArray = new List<Person>
        {
            new Person { GivenNames = new List<string> { "Janet" }, LastName = "Parsons" },
            new Person { GivenNames = new List<string> { "Vaugh" }, LastName = "Lewis" },
            new Person { GivenNames = new List<string> { "Adonis", "Julius" }, LastName = "Archer" },
            new Person { GivenNames = new List<string> { "Shelby", "Nathan" }, LastName = "Yoder" },
            new Person { GivenNames = new List<string> { "Marin" }, LastName = "Alvarez" },
            new Person { GivenNames = new List<string> { "Carin" }, LastName = "Alvarez" },
            new Person { GivenNames = new List<string> { "London" }, LastName = "Lindsey" },
            new Person { GivenNames = new List<string> { "Beau", "Tristan" }, LastName = "Bentley" },
            new Person { GivenNames = new List<string> { "Leo" }, LastName = "Gardner" },
            new Person { GivenNames = new List<string> { "Hunter", "Mathew" }, LastName = "Clarke" },
            new Person { GivenNames = new List<string> { "Hunter", "Uriah", "Mathew" }, LastName = "Clarke" },
            new Person { GivenNames = new List<string> { "Mikayla" }, LastName = "Lopez" },
            new Person { GivenNames = new List<string> { "Frankie", "Conner" }, LastName = "Ritter" },
            new Person { GivenNames = new List<string> { "Beth", "Conner" }, LastName = "Ritter" }
        };

        List<Person> sortedPeople = SortNames(peopleArray);
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{string.Join(" ", person.GivenNames)} {person.LastName}");
        }
    }

    public static List<Person> SortNames(List<Person> peopleArray)
    {
        return peopleArray.OrderBy(p => p.LastName)
                          .ThenBy(p => p.GivenNames.Count > 0 ? p.GivenNames[0] : "")
                          .ThenBy(p => p.GivenNames.Count > 1 ? p.GivenNames[1] : "")
                          .ThenBy(p => p.GivenNames.Count > 2 ? p.GivenNames[2] : "")
                          .ThenBy(p => p.GivenNames.Count)
                          .ToList();
    }
}