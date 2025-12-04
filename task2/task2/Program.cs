public delegate int Calculate(int a, int b);
public delegate double DiscountStrategy(double price);

public static class MathOperations
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}

public static class DiscountProvider
{
    public static double FestivalDiscount(double price) => price * 0.80;
    public static double SeasonalDiscount(double price) => price * 0.90;
    public static double NoDiscount(double price) => price;
}

