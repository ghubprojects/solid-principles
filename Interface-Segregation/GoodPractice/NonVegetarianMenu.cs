namespace Interface_Segregation.GoodPractice;

public class NonVegetarianMenu : INonVegetarianMenu {
    public void ShowNonVegetarianItems() {
        Console.WriteLine("Showing Non-Vegetarian Items");
    }
}
