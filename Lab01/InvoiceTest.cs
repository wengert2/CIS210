/**
 * @author      Joseph Wengert
 * @date        2/8/2022
 * 
 * The InvoiceTest class is used to test the Invoice class
 * 
 */

using System;
namespace Lab01
{
    public class InvoiceTest
    {
        static void Main(string[] args)
        {

            {
                // Initial test with an invoice object 
                Invoice invoice1 = new Invoice("1234", "Hammer", 2, 14.95m);
                Console.WriteLine($"Original invoice information\n{invoice1}");

                // changing some values to see if they are updated in the 
                // invoice object                                         
                invoice1.PartNum = "001234";
                invoice1.PartDesc = "Yellow Hammer";
                invoice1.Quantity = 3;
                invoice1.Price = 19.49m;
                Console.WriteLine($"\nUpdated invoice information\n{invoice1}");


                // Second test with an invoice object with some values set to 0
                Invoice invoice2 = new Invoice("5678", "PaintBrush", 0, 0.00m);
                Console.WriteLine($"\nOriginal invoice information\n{invoice2}");
                invoice2.Quantity = 3;
                invoice2.Price = 9.49m;
                Console.WriteLine($"\nUpdated invoice information\n{invoice2}");

                // Testing the case of trying to set a negative value in the
                // price and quantity fields
                Console.WriteLine("\n\n-----------------");
                Console.WriteLine(" Additional Test\n"
                    + "-----------------"
                    + "\nTesting negative price and quant\n");
                Console.WriteLine("Original invoice information\n" + invoice2.ToString());
                Console.WriteLine("\nAttempting to change the values to negatives");
                invoice2.Price = -100;
                invoice2.Quantity = -50;
                Console.WriteLine("\nThe invoice remains unchanged\n" + invoice2.ToString());
            }
        }
    }
}

