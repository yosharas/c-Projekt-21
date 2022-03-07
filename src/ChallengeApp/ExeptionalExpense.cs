using System;
using System.Collections.Generic;   // dodać aby móc używać LIST


namespace ChallengeApp
{
    public class ExeptionalExpense : Expense
    {
        private static int SerialNumber = 1;

        public int ID { get; private set; }
        public string Category { get; set; }
        public int Month { get; set; }

        public ExeptionalExpense(string name, double value, DateTime date) : base(name, value, date)
        {
            this.Name = name;
            this.Value = value;
            if (value <= 0)
            {
                throw new Exception("wartość musi być większa od zero");
            }
            this.Date = date;
            this.ID = SerialNumber;
            this.Month = date.Month;
            SerialNumber++;
        }
    }
    public new void AddComment(string a)
    {
        //using( file.append)
    }
    public new string GetComment()
    {
        // using (File Read)
    }
}

