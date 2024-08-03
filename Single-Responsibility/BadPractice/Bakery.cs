namespace Single_Responsibility.BadPractice;

public class Bakery {
    public void BakeBread() {
        Console.WriteLine("Baking bread...");
    }

    public void ManageInventory() {
        Console.WriteLine("Managing inventory...");
    }

    public void OrderSupplies() {
        Console.WriteLine("Ordering supplies...");
    }

    public void ServeCustomers() {
        Console.WriteLine("Serving customers...");
    }

    public void CleanBakery() {
        Console.WriteLine("Cleaning the bakery...");
    }
}
