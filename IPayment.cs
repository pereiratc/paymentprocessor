namespace paymentprocessor;

//Defines the contract that all payment methods must follow.
public interface IPayment
{
    void Pay(decimal amount);
}