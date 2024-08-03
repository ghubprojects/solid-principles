namespace Interface_Segregation.GoodPractice;

public class VegetarianMenu : IVegetarianMenu {
    public void ShowVegetarianItems() {
        Console.WriteLine("Showing Vegetarian Items");
    }
}
