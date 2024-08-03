namespace Interface_Segregation.BadPractice;

public interface IMenu {
    void ShowVegetarianItems();
    void ShowNonVegetarianItems();
    void ShowDrinks();
    void ShowSweets();
}