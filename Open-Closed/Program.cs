#define GOOD_PRACTICE

#if BAD_PRACTICE
using Open_Closed.BadPractice; 
{
    var paymentProcessor = new PaymentProcessor();
    paymentProcessor.ProcessPayment("CreditCard", 100.00m);
    paymentProcessor.ProcessPayment("PayPal", 150.00m);
}

#elif GOOD_PRACTICE
using Open_Closed.GoodPractice; 
{
    var paymentProcessor = new PaymentProcessor(new CreditCardPaymentProcessor());
    paymentProcessor.Process(100.00m);
    paymentProcessor = new PaymentProcessor(new PayPalPaymentProcessor());
    paymentProcessor.Process(150.00m);
}
#endif