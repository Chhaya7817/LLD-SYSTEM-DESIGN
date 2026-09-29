public interface IPaymentStrategy
{
    void pay(double amount);
}

public class CreditCard : IPaymentStrategy
{
    public void pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}

public class UPI: IPaymentStrategy
{
    public void pay(double amount)
    {
        Console.WriteLine($"Paid {amount} via UPI");
    }
}
