using System;
using System.Linq;
using System.Collections.Generic;

class Project
{

    public static void Main(String[] args)
    {
        Compute list= new Compute();
        Console.ReadKey();
    }
}

class Compute
{

    List<int> num = new List<int>();

    // Constructor method
    public Compute()
    {
        // TAKE INPUT
        int amount;
        Console.WriteLine("How many numbers do you want to enter:");
        string inpt = Console.ReadLine();
        amount = Convert.ToInt32(inpt);

        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Enter input " + (i + 1));

            string inp = Console.ReadLine();
            num.Add(Convert.ToInt32(inp));
        }

        // Call the calculate method
        calculate();
    }

    // Private calculate method
    private void calculate()
    {
        // SORT LIST
        num.Sort();

        // Computation of each number in an increment of index 1
        Console.WriteLine("Computing each number in an increment of 1");
        int prevCalc = 0;
        foreach(int i in num)
        {
            prevCalc += i;
            display(prevCalc.ToString());
        }

        // Display count
        display("Total count of entered number is " + (num.Count).ToString());

        // Display Max
        display("Maximum number entered is " + (num.Max()).ToString());

        // Display Min
        display("Minimum number entered is " + (num.Min()).ToString());

        // Display average
        display("Average of the entered number is " + (num.Average()).ToString());
    }

    // Display method
    public void display(string toDisplay)
    {
        Console.WriteLine(toDisplay);
    }
}
