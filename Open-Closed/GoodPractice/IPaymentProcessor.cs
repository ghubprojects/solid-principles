namespace Open_Closed.GoodPractice;

public interface IPaymentProcessor {
    void ProcessPayment(decimal amount);
}