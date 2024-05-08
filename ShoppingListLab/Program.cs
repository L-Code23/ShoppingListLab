// See https://aka.ms/new-console-template for more information


//Create a dictonary with 8 items

using System;
using System.ComponentModel.Design;

Dictionary<string, decimal> GroceryInventory = new Dictionary<string, decimal>();
GroceryInventory.Add("chips",(decimal)1.25);
GroceryInventory.Add("soda", (decimal)0.99);
GroceryInventory.Add("laundry detergent",(decimal)12.99);
GroceryInventory.Add("asparagus", (decimal)2.99);
GroceryInventory.Add("rice crispies", (decimal)4.99);
GroceryInventory.Add("bread", (decimal)3.99);
GroceryInventory.Add("milk", (decimal)4.99);
GroceryInventory.Add("yogurt", (decimal)5.99);

//List
List<string> ShoppingList = new List<string>();


//Console.WriteLine(GroceryInventory["Asparagus"]); Save for later


//List<int> values = new List<int>();
//values.Add(5);
//values.Add(3);
//Console.WriteLine(values[0]);

//foreach (int i in values)
//{
//    Console.WriteLine(i);
//} for reference
//foreach (string i in GroceryInventory)
//{
//    Console.WriteLine(i);
//}


while (true)
{


    foreach (string i in GroceryInventory.Keys)
    {
        Console.WriteLine(i);

    }
    Console.WriteLine("Enter an item name.");


    string itemName = Console.ReadLine().ToLower();








    if (GroceryInventory.ContainsKey(itemName))
    {
        ShoppingList.Add(itemName);

    }

    else
    {
        Console.WriteLine("Invald input. Please choose an item from the list.");
    }


    Console.WriteLine("Would you like to add more? Enter y/n." );
    string addMore = Console.ReadLine();

    if( addMore == "n")
    {
        break;
    }
}
    Console.WriteLine($"Item\t    Price");
foreach (string i in ShoppingList)
{
    
    Console.WriteLine($"{i}      ${GroceryInventory[i]}");// {i} represents items in list created by user input {GroceryInventory[i]} reperesents the prices from original list
    

    //Console.WriteLine($" Here is the sum of your order: {ShoppingTotal}");
    //break;
}
static decimal ShoppingTotal(decimal GroceryInventory)
{
    return GroceryInventory;
    
}
