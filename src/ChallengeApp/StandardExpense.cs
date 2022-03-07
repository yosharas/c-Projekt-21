using System;
using System.Collections.Generic;   // dodać aby móc używać LIST


namespace ChallengeApp
{
    public class StandardExpense : Expense
    {
        private static int SerialNumber = 1;
        public int ID { get; private set; }
        public string Category { get; set; }
        public int Month { get; set; }
        private string comment;
        public StandardExpense(string name, double value, DateTime date, string category) : base(name, value, date)
        {
            this.Name = name;
            this.Value = value;
            if (value <= 0)
            {
                throw new Exception("wartość musi być większa od zero");
            }

            this.Date = date;
            this.Category = category;
            this.ID = SerialNumber;
            this.Month = date.Month;
            SerialNumber++;
        }
        public new void AddComment(string a)
        {
            this.comment = a;
        }

        public new string GetComment()
        {
            return comment;
        }
    }
}
