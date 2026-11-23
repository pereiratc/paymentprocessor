namespace paymentprocessor;

//Implement payment processing using cash.
public class CashPayment : IPayment
{
    public void Pay (decimal amount)
    {
        Console.WriteLine(
            $"Receiving cash payment of ${amount:F2}."
                   );
    }
}