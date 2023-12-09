using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system_assi
{
    class Bank
    {
        private List<Customer> customers;

        public Bank()
        {
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DisplayCustomerAccountDetails(string customerId)
        {
            Customer customer = FindCustomer(customerId);

            if (customer != null)
            {
                customer.DisplayAccountDetails();
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        private Customer FindCustomer(string customerId)
        {
            return customers.Find(c => c.CustomerId == customerId);
        }
    }

    class Customer
    {
        private static int nextCustomerId = 1;

        public string CustomerId { get; set; }
        public string Name { get; set; }
        private List<Account> accounts;

        public Customer(string name)
        {
            CustomerId = "C" + nextCustomerId++;
            Name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine("Account Details:");

            foreach (var account in accounts)
            {
                Console.WriteLine($"Account ID: {account.AccountId}, Type: {account.Type}, Balance: {account.Balance:C}");
            }

            Console.WriteLine($"Total Balance: {GetTotalBalance():C}");
            Console.WriteLine();
        }

        private decimal GetTotalBalance()
        {
            decimal totalBalance = 0;

            foreach (var account in accounts)
            {
                totalBalance += account.Balance;
            }

            return totalBalance;
        }
    }

    class Account
    {
        private static int nextAccountId = 1;

        public string AccountId { get; }
        public enum AccountType { Savings, Checking }
        public AccountType Type { get; }
        private decimal balance;

        public Account(AccountType type)
        {
            AccountId = "A" + nextAccountId++;
            Type = type;
            balance = 0;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C} to {Type} account. New balance: {balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C} from {Type} account. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in {Type} account. Withdrawal failed.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();

            Customer customer1 = new Customer("John Doe");
            Account account1 = new Account(Account.AccountType.Savings);
            Account account2 = new Account(Account.AccountType.Checking);

            customer1.AddAccount(account1);
            customer1.AddAccount(account2);

            bank.AddCustomer(customer1);

            bank.DisplayCustomerAccountDetails(customer1.CustomerId);

            account1.Deposit(1000);
            account2.Deposit(500);

            bank.DisplayCustomerAccountDetails(customer1.CustomerId);

            account1.Withdraw(200);
            account2.Withdraw(700);

            bank.DisplayCustomerAccountDetails(customer1.CustomerId);
        }
    }
}