using System;
using System.Collections.Generic;   // dodać aby móc używać LIST
using System.IO;

namespace ChallengeApp
{
    // public interface IListOfExpenses
    // {
    // Statistics getStats();
    // void AddExpenseToList(Expense expense);
    // }
    // public class ListOfExeptionalExpenses : IListOfExpenses
    // {
    // public void AddExpenseToList()
    // {
    // throw new NotImplementedException();
    // }

    // public Statistics getStats()
    // {
    // throw new NotImplementedException();
    // }
    // }
    public class ListOfStandardExpenses
    {
        public List<Expense> ListOfExpenses = new List<Expense>();

        public void AddExpenseToList(StandardExpense expense)
        {
            this.ListOfExpenses.Add(expense);
        }
        public Statistics getStats()
        {
            var result = new Statistics();

            result.Avg = 0.0;
            result.Sum = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var expense in this.ListOfExpenses)
            {
                result.Low = Math.Min(result.Low, expense.Value);
                result.High = Math.Max(result.High, expense.Value);
                result.Sum += expense.Value;
            }
            
            result.Avg = result.Sum / this.ListOfExpenses.Count;

            Console.WriteLine("Najniższa ocena to " + result.Low.ToString("N2"));
            Console.WriteLine("Najwyższa ocena to " + result.High.ToString("N2"));
            Console.WriteLine("Średnia ocen to " + result.Avg.ToString("N2"));

            return result;
        }
    }
}