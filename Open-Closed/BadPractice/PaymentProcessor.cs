namespace Open_Closed.BadPractice;

public class PaymentProcessor {
    public void ProcessPayment(string paymentType, decimal amount) {
        switch (paymentType) {
        case "CreditCard":
            ProcessCreditCardPayment(amount);
            break;
        case "PayPal":
            ProcessPayPalPayment(amount);
            break;
        default:
            throw new ArgumentException("Unsupported payment type");
        }
    }

    private void ProcessCreditCardPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }

    private void ProcessPayPalPayment(decimal amount) {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }
}

