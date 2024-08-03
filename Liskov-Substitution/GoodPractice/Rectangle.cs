namespace Liskov_Substitution.GoodPractice;

public class Rectangle : IShape {
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area() {
        return Width * Height;
    }
}