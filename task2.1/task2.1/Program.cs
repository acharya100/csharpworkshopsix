public delegate double DiscountStrategy(double price);

public static class FinalPriceCalculator
{
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        => strategy(originalPrice);
}

public static class StrategyLibrary
{
    public static double FestivalDiscount(double price) => price * 0.8;
    public static double SeasonalDiscount(double price) => price * 0.9;
    public static double NoDiscount(double price) => price;
}
