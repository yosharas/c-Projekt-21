using System;
using System.Collections.Generic;   // dodać aby móc używać LIST


namespace ChallengeApp
{
    public class Expense
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        private static int SerialNumber = 1;

        public int ID { get; private set; }

        public string Category { get; set; }
        public int Month { get; set;}

        public Expense(string name, double value, DateTime date, string category)
        {
            this.Name = name;
            this.Value = value;
            if (value <= 0)
            {
                Console.WriteLine("wartość musi być większa od zero");
            }

            this.Date = date;
            this.Category = category;
            this.ID = SerialNumber;
            this.Month = date.Month;
            SerialNumber++;
        }

        public int ExpenseMonth()
        {
            return Date.Month;
        }

    }

}

