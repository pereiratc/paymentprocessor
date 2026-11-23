using paymentprocessor;

// Create one instance of each payment method.
// All objects are accessed through the IPayment interface.
List<IPayment> payments = new()
{
    new CreditCardPayment(),
    new PayPalPayment(),
    new CashPayment()
};

bool running = true;

Console.WriteLine("=== PAYMENT PROCESSOR ===");

while (running)
{
    Console.WriteLine("\n===== MAIN MENU =====");
    Console.WriteLine("1. Pay with Credit Card");
    Console.WriteLine("2. Pay with PayPal");
    Console.WriteLine("3. Pay with Cash");
    Console.WriteLine("4. Demonstrate Polymorphism");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option (1-5): ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
        case "2":
        case "3":
            // Validate the payment amount entered by the user.
            Console.Write("Enter payment amount: ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal amount)
                || amount <= 0)
            {
                Console.WriteLine("Invalid payment amount.");
                break;
            }

            // Select a payment implementation through the interface.
            int index = int.Parse(choice) - 1;

            IPayment selectedPayment = payments[index];

            selectedPayment.Pay(amount);
            break;

        case "4":
            Console.WriteLine("\n=== POLYMORPHISM DEMONSTRATION ===");

            // Each implementation executes its own Pay() method.
            foreach (IPayment payment in payments)
            {
                payment.Pay(100m);
            }
            break;

        case "5":
            running = false;
            Console.WriteLine("Thank you for using Payment Processor!");
            break;

        default:
            Console.WriteLine("Invalid option. Please choose 1-5.");
            break;
    }
}
