using System;

namespace ChallengeApp
{
    public abstract class Budget : IBudgetController
    {
        public string Category;
        public double MonthlyCategoryBudget;
        virtual public bool IsMonthlyListOfExpensesExceedingMonthlyBudget(ListOfStandardExpenses expenses)
        {
            throw new NotImplementedException();
        }

        virtual public bool IsSingleExpenseExceedingMonthlyBudget(StandardExpense expense)
        {
            if (expense.Category == this.Category)
            {
                return expense.Value > MonthlyCategoryBudget;
            }
            throw new Exception($"{expense.Name} doesn't belong to this category");
        }
    }
}