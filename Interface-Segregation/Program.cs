#define GOOD_PRACTICE

#if BAD_PRACTICE
using Interface_Segregation.BadPractice; 
{
    var vegetarianCustomer = new VegetarianCustomer(new Menu());
    vegetarianCustomer.ShowMenu();
}

#elif GOOD_PRACTICE
using Interface_Segregation.GoodPractice; 
{
    var vegetarianCustomer = new VegetarianCustomer(new VegetarianMenu());
    vegetarianCustomer.ShowMenu();
}
#endif