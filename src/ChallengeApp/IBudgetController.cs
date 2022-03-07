namespace ChallengeApp
{
    public interface IBudgetController
    {
       bool IsSingleExpenseExceedingMonthlyBudget(StandardExpense expense);
       bool IsMonthlyListOfExpensesExceedingMonthlyBudget(ListOfStandardExpenses expenses);
       
    }
    
}