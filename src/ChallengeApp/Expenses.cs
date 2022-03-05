using System;
using System.Collections.Generic;   // dodać aby móc używać LIST

namespace ChallengeApp
{
    public class Expenses
    {
        public List<Expense> ExpensesList = new List<Expense>();

        public void AddValues(Expense expense)
        {
            this.ExpensesList.Add(expense);
        }
        public Statistics getStats()
        {
            var result = new Statistics();

            result.Avg = 0.0;
            result.Sum = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var expense in this.ExpensesList)
            {
                result.Low = Math.Min(result.Low, expense.Value);
                result.High = Math.Max(result.High, expense.Value);
                result.Sum += expense.Value;
            }
            result.Avg = result.Sum / this.ExpensesList.Count;

            Console.WriteLine("Najniższa ocena to " + result.Low.ToString("N2"));
            Console.WriteLine("Najwyższa ocena to " + result.High.ToString("N2"));
            Console.WriteLine("Średnia ocen to " + result.Avg.ToString("N2"));

            return result;
        }
    }
}