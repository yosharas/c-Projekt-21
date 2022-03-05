namespace ChallengeApp
{
    public interface IBudgetController
    {
       bool IsSingleExpenseExceedingMonthlyBudget(Expense expense);
       bool IsMonthlyListOfExpensesExceedingMonthlyBudget(Expenses expenses);
       
    }
    
}