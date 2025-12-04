using System;
using System.Linq;
using System.Collections.Generic;

class Task6_Main
{
    static void Main()
    {
        var bookings = new List<TourBooking>
        {
            new TourBooking {CustomerName="John", Destination="Tokyo", Price=20000, DurationInDay=7, IsInternational=true},
            new TourBooking {CustomerName="Sita", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false},
            new TourBooking {CustomerName="Ram", Destination="Bangkok", Price=15000, DurationInDay=5, IsInternational=true}
        };

        var filtered = bookings
            .Where(b => b.Price > 10000 && b.DurationInDay > 4)
            .Select(b => new TransformedBooking
            {
                CustomerName = b.CustomerName,
                Destination = b.Destination,
                Category = b.IsInternational ? "International" : "Domestic",
                Price = b.Price
            })
            .OrderBy(b => b.Category)
            .ThenBy(b => b.Price);

        Console.WriteLine("Filtered & Sorted:");
        foreach (var b in filtered)
            Console.WriteLine($"{b.CustomerName} | {b.Destination} | {b.Category} | Rs. {b.Price}");
    }
}
