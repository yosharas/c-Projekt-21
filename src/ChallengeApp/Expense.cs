using System;

namespace ChallengeApp
{
    public abstract class Expense : ICommentable

    {
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public Expense(string name, double value, DateTime date)
        {
            this.Name = name;
            this.Value = value;
            if (value <= 0)
            {
                throw new Exception("wartość musi być większa od zero");
            }
            this.Date = date;
        }

        public void AddComment(string a)
        {
            throw new NotImplementedException();
        }

        public string GetComment()
        {
            throw new NotImplementedException();
        }
    }

}