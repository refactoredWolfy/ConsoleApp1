using System;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal startingBalance)
    {
        if (startingBalance < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(startingBalance),
                "Starting balance cannot be negative."
            );
        }

        Balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Deposit amount must be greater than zero."
            );
        }

        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Withdrawal amount must be greater than zero."
            );
        }

        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}


public class Inventory
{
    private string[] items = new string[5];

    public bool AddItem(string item)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            throw new ArgumentException(
                "Item cannot be null or whitespace.",
                nameof(item)
            );
        }

        // First check whether the item already exists.
        if (Contains(item))
        {
            return false;
        }

        // Find the first empty slot.
        for (int i = 0; i < items.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(items[i]))
            {
                items[i] = item;
                return true;
            }
        }

        // No empty slot was found.
        return false;
    }

    public bool RemoveItem(string item)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            throw new ArgumentException(
                "Item cannot be null or whitespace.",
                nameof(item)
            );
        }

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                return true;
            }
        }

        return false;
    }

    public bool Contains(string item)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            throw new ArgumentException(
                "Item cannot be null or whitespace.",
                nameof(item)
            );
        }

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                return true;
            }
        }

        return false;
    }

    public void PrintItems()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(items[i]))
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // -------------------------
        // Exercise 1: BankAccount
        // -------------------------

        BankAccount account = new BankAccount(200m);

        Console.WriteLine("Starting balance: " + account.Balance);

        account.Deposit(50m);
        Console.WriteLine("After deposit: " + account.Balance);

        bool withdrew = account.Withdraw(30m);
        Console.WriteLine("Withdrawal successful: " + withdrew);
        Console.WriteLine("Balance: " + account.Balance);


        // -------------------------
        // Exercise 2: CountEven
        // -------------------------

        int[] numbers = { 3, 8, 12, 7, 10, 5 };

        int evenCount = CountEven(numbers);

        Console.WriteLine("Even numbers: " + evenCount);


        // -------------------------
        // Exercise 3: Inventory
        // -------------------------

        Inventory inventory = new Inventory();

        Console.WriteLine(inventory.AddItem("Sword"));   // True
        Console.WriteLine(inventory.AddItem("Shield"));  // True
        Console.WriteLine(inventory.AddItem("Sword"));   // False

        Console.WriteLine("Contains Sword: "
            + inventory.Contains("Sword"));

        inventory.RemoveItem("Shield");

        // The removed slot can be reused.
        inventory.AddItem("Potion");

        Console.WriteLine("Inventory:");
        inventory.PrintItems();
    }


    public static int CountEven(int[] numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers));
        }

        int count = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}