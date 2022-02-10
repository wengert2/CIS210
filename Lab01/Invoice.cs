/**
 * @author Joseph Wengert
 * @date 2/8/22
 * 
 * The invoice class creates an invoice object that holds the part number, description,
 * quantity, and price of an item the store carries.
 * 
 * 
 */

namespace Lab01
{
    class Invoice
    {
        // public vars
        public string PartNum { get; set; }
        public string PartDesc { get; set; }

        // private vars 
        private int quantity = 0;
        private decimal price = 0.00m;

        // constructor
        public Invoice(string partNumber, string desc, int quant, decimal partPrice)
        {
            PartNum = partNumber;
            PartDesc = desc;
            if (quant >= 0)
            {
                quantity = quant;
            }
            if (partPrice >= 0)
            {
                price = partPrice;
            }
        }

        // no arg constructor
        public Invoice()
        {
            PartNum = "";
            PartDesc = "";
            quantity = 0;
            price = 0.00m;
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                // a negative quantity is not permitted
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                // a negative price is not permitted
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        //Calculates the invoice amount (quant * pricePer) & returns
        //the amount as a decimal value
        public decimal InvoiceAmount
        {
            get => price * quantity;
        }

        override
        public string ToString()
        {
            return "Part Number: " + PartNum + "\nDescription: " + PartDesc + "\nQuantity: " +
                quantity + "\nPrice: $" + price + "\nInvoice amount: $" + InvoiceAmount;
        }
    }
}
