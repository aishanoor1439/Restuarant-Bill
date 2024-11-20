﻿using System;

namespace RestaurantBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predefined values for the bill
            string itemName1 = "Burger";
            double price1 = 5.99;
            int quantity1 = 2;
            string itemName2 = "Pizza";
            double price2 = 7.50;
            int quantity2 = 3;

            // Calculating totals
            double total1 = price1 * quantity1;
            double total2 = price2 * quantity2;
            double grandTotal = total1 + total2;

            // Displaying the formatted bill with better alignment
            Console.WriteLine("|--------------------------------------------------------");
            Console.WriteLine("|                   RESTAURANT BILL                      ");
            Console.WriteLine("|--------------------------------------------------------");
            Console.WriteLine("| Item Name             | Quantity | Price  | Total");
            Console.WriteLine("|--------------------------------------------------------");
            Console.WriteLine("| {0}                   | {1}      | {2:C}  | {3:C}", itemName1, quantity1, price1, total1);
            Console.WriteLine("| {0}                   | {1}      | {2:C}  | {3:C}", itemName2, quantity2, price2, total2);
            Console.WriteLine("|--------------------------------------------------------");
            Console.WriteLine("|                                      Grand Total: {0,8:C}", grandTotal);
            Console.WriteLine("|--------------------------------------------------------");

        }
    }
}
