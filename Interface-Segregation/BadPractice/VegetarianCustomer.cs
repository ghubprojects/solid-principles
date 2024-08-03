namespace Interface_Segregation.BadPractice;

public class VegetarianCustomer(IMenu menu) {
    private readonly IMenu _menu = menu;

    public void ShowMenu() {
        _menu.ShowVegetarianItems();
        // _menu.ShowNonVegetarianItems(); // Unnecessary for vegetarian customer
        // _menu.ShowDrinks();             // Unnecessary for vegetarian customer
        // _menu.ShowSweets();             // Unnecessary for vegetarian customer
    }
}