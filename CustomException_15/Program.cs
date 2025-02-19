namespace CustomException_15;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(5000);
        try{
            System.Console.WriteLine("Attempting to withdraw 8000");
            account.withdraw(8000);
        }
        catch(InsufficientBalanceException e){
            System.Console.WriteLine("InsufficientBalanceException:{0}",e.Message);
        }
         Console.ReadKey();
    }
}
public class InsufficientBalanceException:Exception
{
    public InsufficientBalanceException(string message):base(message){}

}

public class BankAccount
{
    private int balance;

    public BankAccount(int initialBalance)
    {
        balance = initialBalance;
    }

    public void withdraw(int amount)
    {
        if(amount>balance){
            throw new InsufficientBalanceException("Withdrawal amount exceeds the available balance!");
        }
         else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful! Remaining balance: {0}", balance);
            }
    }
}