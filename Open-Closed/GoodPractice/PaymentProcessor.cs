namespace Open_Closed.GoodPractice;

public class PaymentProcessor(IPaymentProcessor paymentProcessor) {
    private readonly IPaymentProcessor _paymentProcessor = paymentProcessor;

    public void Process(decimal amount) {
        _paymentProcessor.ProcessPayment(amount);
    }
}
