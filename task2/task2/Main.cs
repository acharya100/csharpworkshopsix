using System;

class Task2_Main
{
    static void Main()
    {
        
        Calculate calc;

        calc = MathOperations.Add;
        Console.WriteLine("Add= " + calc(10, 5));

        calc = MathOperations.Subtract;
        Console.WriteLine("Subtract= " + calc(10, 5));

        
        double price = 1000;

        Console.WriteLine("Festival Discount= " + DiscountProvider.FestivalDiscount(price));
        Console.WriteLine("Seasonal Discount= " + DiscountProvider.SeasonalDiscount(price));
        Console.WriteLine("No Discount= " + DiscountProvider.NoDiscount(price));
    }
}
