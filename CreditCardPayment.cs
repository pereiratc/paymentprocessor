namespace paymentprocessor;

//Implements payment processing using a credit card.
public class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Processing credit card payment of ${amount:f2}.");
    }
}