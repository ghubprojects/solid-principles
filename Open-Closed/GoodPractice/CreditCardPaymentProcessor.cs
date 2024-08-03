namespace Open_Closed.GoodPractice;

public class CreditCardPaymentProcessor : IPaymentProcessor {
    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }
}
