using System;

namespace ChallengeApp
{
    public class BudgetBills : Budget
    {
        public BudgetBills() : base()
        {
            Category = "Bills";
            MonthlyCategoryBudget = 1500.0;
        }
    }
}
