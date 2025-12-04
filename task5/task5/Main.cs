using System;
using System.Linq;
using System.Collections.Generic;

class Task5_Main
{
    static void Main()
    {
        // Sales Aggregation
        var salesData = new List<CashierSales>
        {
            new CashierSales{Name="Ram", Sales=5000},
            new CashierSales{Name="Sita", Sales=7000},
            new CashierSales{Name="Hari", Sales=3000}
        };

        Console.WriteLine("Total Cashiers: " + salesData.Count());
        Console.WriteLine("Total Sales: " + salesData.Sum(c => c.Sales));
        Console.WriteLine("Highest: " + salesData.Max(c => c.Sales));
        Console.WriteLine("Lowest: " + salesData.Min(c => c.Sales));
        Console.WriteLine("Average: " + salesData.Average(c => c.Sales));

        // Applicants
        var applicants = new List<Applicant>
        {
            new Applicant{Name="Aman", Age=20},
            new Applicant{Name="Sita", Age=17},
            new Applicant{Name="Hari", Age=19}
        };

        Console.WriteLine("Any under 18? " + applicants.Any(a => a.Age < 18));
        Console.WriteLine("All above 16? " + applicants.All(a => a.Age > 16));

        // Music durations
        var songs = new List<Music>
        {
            new Music{Title="Song1", DurationInSeconds=120},
            new Music{Title="Song2", DurationInSeconds=300},
            new Music{Title="Song3", DurationInSeconds=480}
        };

        Console.WriteLine("First: " + songs.First().Title);
        Console.WriteLine("Last: " + songs.Last().Title);
        Console.WriteLine("First > 4 min: " + songs.First(s => s.DurationInSeconds > 240).Title);

        var safe = songs.FirstOrDefault(s => s.DurationInSeconds > 600);
        Console.WriteLine("Safe 10-min: " + (safe?.Title ?? "None"));
    }
}

