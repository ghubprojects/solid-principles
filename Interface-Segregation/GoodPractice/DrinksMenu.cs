namespace Interface_Segregation.GoodPractice;

public class DrinksMenu : IDrinksMenu {
    public void ShowDrinks() {
        Console.WriteLine("Showing Drinks");
    }
}