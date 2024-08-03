namespace Open_Closed.GoodPractice;

public class PayPalPaymentProcessor : IPaymentProcessor {
    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }
}
