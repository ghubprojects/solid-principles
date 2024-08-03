#define GOOD_PRACTICE

#if BAD_PRACTICE
using Single_Responsibility.BadPractice; 
{
    Bakery bakery = new();
    bakery.BakeBread();
    bakery.ManageInventory();
    bakery.OrderSupplies();
    bakery.ServeCustomers();
    bakery.CleanBakery();
}

#elif GOOD_PRACTICE
using Single_Responsibility.GoodPractice; 
{
    Baker baker = new();
    InventoryManager inventoryManager = new();
    SupplyOrderManager supplyOrderManager = new();
    CustomerService customerService = new();
    CleaningStaff cleaningStaff = new();

    baker.BakeBread();
    inventoryManager.ManageInventory();
    supplyOrderManager.OrderSupplies();
    customerService.ServeCustomers();
    cleaningStaff.CleanBakery();
}
#endif