namespace Interface_Segregation.GoodPractice;

public class VegetarianCustomer(IVegetarianMenu vegetarianMenu) {
    private readonly IVegetarianMenu _vegetarianMenu = vegetarianMenu;

    public void ShowMenu() {
        _vegetarianMenu.ShowVegetarianItems();
    }
}