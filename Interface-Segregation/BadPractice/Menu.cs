namespace Interface_Segregation.BadPractice;

public class Menu : IMenu {
    public void ShowVegetarianItems() {
        Console.WriteLine("Showing Vegetarian Items");
    }

    public void ShowNonVegetarianItems() {
        Console.WriteLine("Showing Non-Vegetarian Items");
    }

    public void ShowDrinks() {
        Console.WriteLine("Showing Drinks");
    }

    public void ShowSweets() {
        Console.WriteLine("Showing Sweets");
    }
}
