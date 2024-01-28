using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Olaoye
{
    internal class DeskQuote
    {
        // Attributes
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteTotal { get; private set; }

        // Constructor
        public DeskQuote(Desk desk, int rushDays, string customerName, DateTime quoteDate)
        {
            Desk = desk;
            RushDays = rushDays;
            CustomerName = customerName;
            QuoteDate = quoteDate;

            // Calculate quote total when creating a new DeskQuote
            CalculateQuoteTotal();
        }

        // Method to calculate the quote total
        private void CalculateQuoteTotal()
        {
            // Your logic for calculating the quote total goes here
            // For example, you can use the attributes of Desk to calculate the total based on your pricing formula
            // QuoteTotal = ...;
        }
    }
}
