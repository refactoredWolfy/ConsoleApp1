# C# Fundamentals Practice

A small console application containing three exercises I completed while
practicing the fundamentals of C# and object-oriented programming.

The project is compatible with C# 6.

## Exercises

### 1. Bank Account

A simple `BankAccount` class that demonstrates:

- Constructors
- Properties and encapsulation
- Input validation
- Depositing and withdrawing money
- Boolean return values
- Exception handling

The account prevents withdrawals when the available balance is insufficient.

### 2. Number Analyzer

The `CountEven` method receives an integer array and returns the number of
even values contained in the array.

This exercise practices:

- Arrays
- `foreach` loops
- Conditional statements
- Modulo operations
- Method parameters and return values

### 3. Inventory System

A small inventory system that can store up to five items.

The `Inventory` class supports:

- Adding items
- Removing items
- Checking whether an item exists
- Preventing duplicate items
- Reusing empty inventory slots
- Printing the current inventory

The inventory uses a fixed-size `string[]` rather than `List<T>` to practice
working directly with arrays.

## Concepts Practiced

- Classes and objects
- Constructors
- Properties
- Encapsulation
- Arrays
- Loops
- Methods
- Parameters
- Return values
- Exceptions and validation
- Basic object-oriented design

## Running the Project

Compile and run the program using a C# compiler that supports C# 6 or later.

The `Main` method contains example calls for all three exercises.

## Example

```csharp
Inventory inventory = new Inventory();

inventory.AddItem("Sword");
inventory.AddItem("Shield");

Console.WriteLine(inventory.Contains("Sword"));

inventory.RemoveItem("Shield");
inventory.AddItem("Potion");

inventory.PrintItems();
