#define GOOD_PRACTICE

#if BAD_PRACTICE
using Liskov_Substitution.BadPractice; 
{
    Rectangle rect = new Rectangle();
    rect.Width = 4;
    rect.Height = 5;
    Console.WriteLine($"Rectangle Area: {rect.Area()}");

    Rectangle square = new Square();
    square.Width = 5;
    square.Height = 10;
    Console.WriteLine($"Square Area: {square.Area()}");  // This will not produce correct behavior 
}

#elif GOOD_PRACTICE
using Liskov_Substitution.GoodPractice; 
{
    IShape rect = new Rectangle { Width = 4, Height = 5 };
    Console.WriteLine($"Rectangle Area: {rect.Area()}");

    IShape square = new Square { SideLength = 5 };
    Console.WriteLine($"Square Area: {square.Area()}");
}
#endif