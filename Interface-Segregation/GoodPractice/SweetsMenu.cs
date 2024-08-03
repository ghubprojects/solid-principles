namespace Interface_Segregation.GoodPractice;

public class SweetsMenu : ISweetsMenu {
    public void ShowSweets() {
        Console.WriteLine("Showing Sweets");
    }
}