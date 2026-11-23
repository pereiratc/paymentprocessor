namespace paymentprocessor;

//Implements payments processing using PayPal.
public class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {Console.WriteLine(
        $"Processing PayPal payment of ${amount:F2}.");
    }
}