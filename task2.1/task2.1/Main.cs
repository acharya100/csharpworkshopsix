using System;

class Task2_1_Main
{
    static void Main()
    {
        double price = 1000;

        Console.WriteLine("Festival Final Price= " +
            FinalPriceCalculator.CalculateFinalPrice(price, StrategyLibrary.FestivalDiscount));

        Console.WriteLine("Seasonal Final Price= " +
            FinalPriceCalculator.CalculateFinalPrice(price, StrategyLibrary.SeasonalDiscount));

        Console.WriteLine("No Discount Final Price= " +
            FinalPriceCalculator.CalculateFinalPrice(price, StrategyLibrary.NoDiscount));

        // 30% discount
        Console.WriteLine("30% Discount= " +
            FinalPriceCalculator.CalculateFinalPrice(price, p => p * 0.7));
    }
}
