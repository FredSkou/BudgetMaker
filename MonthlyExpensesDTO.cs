namespace Budgetmaker;

public class MonthlyExpensesDTO
{
    public static Dictionary<string, double> GetMonthyExpenseTypesAndAmount()
    {
        Dictionary<string, double> expenses = [];
        expenses.Add("Husleje", 11_500);
        expenses.Add("Forsikringer", 500);
        return expenses;
    }
}
