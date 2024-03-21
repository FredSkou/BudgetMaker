namespace Budgetmaker;

public class IncomeDTO
{
    public static Dictionary<string, double> GetIncomeTypesAndAmount()
    {
        //Should come from db, maybe from another class 
        Dictionary<string, double> incomeTypesAndValues = [];
        incomeTypesAndValues.Add("Løn", 20_524.20);
        incomeTypesAndValues.Add("Boligstøtte", 1_200.00);
        return incomeTypesAndValues;
    }

}
