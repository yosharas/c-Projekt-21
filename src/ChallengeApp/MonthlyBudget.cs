using System;

namespace ChallengeApp
{
    public class MonthlyBudget : Budget
    {
        public BudgetBills Bills = new BudgetBills();
        public BudgetFood Food = new BudgetFood();
        public BudgetPleasures Pleasures = new BudgetPleasures();

        public MonthlyBudget()
        {
            Category = "MonthlyBudget";
            MonthlyCategoryBudget = Bills.MonthlyCategoryBudget + Food.MonthlyCategoryBudget + Pleasures.MonthlyCategoryBudget;
        }

        public override bool IsSingleExpenseExceedingMonthlyBudget(StandardExpense expense)
        {
            return expense.Value > MonthlyCategoryBudget;
        }
    }
}