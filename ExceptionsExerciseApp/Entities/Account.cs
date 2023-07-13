using ExceptionsExerciseApp.Entities.Exceptions;

namespace ExceptionsExerciseApp.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() 
        {
        }

        public Account(int number, string holder, double initialBalance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = initialBalance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount) 
        {
            if (amount > Balance)
            {
                throw new AccountExceptions("Not enough balance");
            }
            if (amount > WithdrawLimit) 
            {
                throw new AccountExceptions("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
