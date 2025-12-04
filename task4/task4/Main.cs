using System;
using System.Linq;
using System.Collections.Generic;

class Task4_Main
{
    static void Main()
    {
        // Projection
        var nums = new List<int> { 1, 2, 3, 4, 5 };
        var squares = nums.Select(n => n * n);
        Console.WriteLine("Squares: " + string.Join(", ", squares));

        // Filtering
        var books = new List<Book>
        {
            new Book {Title="C sharp Mastery", Price=1500},
            new Book {Title="Python 101", Price=900},
            new Book {Title="AI Basics", Price=2000},
        };

        var premium = books.Where(b => b.Price > 1000);
        Console.WriteLine("Premium Books:");
        foreach (var b in premium)
            Console.WriteLine($"{b.Title}: Rs. {b.Price}");

        // Sorting
        var students = new List<Student>
        {
            new Student{Name="Karan"},
            new Student{Name="Anita"},
            new Student{Name="Bishal"}
        };

        var sorted = students.OrderBy(s => s.Name);
        Console.WriteLine("Sorted Students are ");
        foreach (var s in sorted)
            Console.WriteLine(s.Name);
    }
}
