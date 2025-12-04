public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    
    public double Area => Length * Width;

    
    public double Perimeter() => 2 * (Length + Width);

    public override string ToString() =>
        $"Length= {Length}\n" +
        $" Width= {Width}\n" +
        $"Area= {Area}\n" +
        $" Perimeter= {Perimeter()}\n";
}
