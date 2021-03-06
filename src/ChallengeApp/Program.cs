using System;
using System.Collections.Generic;   // dodać aby móc używać LIST

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exp1 = new StandardExpense("kawa", 2100.0, new DateTime(2022, 12, 22), "Food");
            var exp2 = new StandardExpense("n2", 1400.0, new DateTime(2022, 5, 22), "Bills");
            var exp3 = new StandardExpense("n3", 6000, new DateTime(2022, 2, 19), "Bills");

            exp1.Name = "n1";
            exp3.Name = exp2.Name;
            exp2.Name = "haha";


            Console.WriteLine($"1 - {exp1.Name}");
            Console.WriteLine($"2 - {exp2.Name}");
            Console.WriteLine($"3 - {exp3.Name}");
            Console.WriteLine($"sn - {exp3.ID}");


            var explist = new ListOfStandardExpenses();
            explist.AddExpenseToList(exp1);
            explist.AddExpenseToList(exp2);
            explist.AddExpenseToList(exp3);

            explist.getStats();

            var monthlybudget = new MonthlyBudget();
            monthlybudget.IsSingleExpenseExceedingMonthlyBudget(exp1);
            monthlybudget.IsSingleExpenseExceedingMonthlyBudget(exp2);
            monthlybudget.IsSingleExpenseExceedingMonthlyBudget(exp3);
            monthlybudget.Food.IsSingleExpenseExceedingMonthlyBudget(exp1);
            monthlybudget.Bills.IsSingleExpenseExceedingMonthlyBudget(exp2);


        }
    }

}
