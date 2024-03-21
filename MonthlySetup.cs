using System.Security.Principal;

namespace Budgetmaker
{
    public partial class MonthlySetup : Form
    {
        public MonthlySetup()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            totalIncomeTextBox.Text = LoadIncome().ToString();
            totalMonthlyExpensesTextBox.Text = LoadMonthlyExpenses().ToString();

        }
        private double LoadMonthlyExpenses()
        {
            monthlyExpenseListBox.Items.Clear();
            double monthlyExpenses = 0;
            var values = MonthlyExpensesDTO.GetMonthyExpenseTypesAndAmount();
            foreach (var key in values.Keys)
            {
                ListViewItem item = new(key);
                item.SubItems.Add(values[key].ToString());
                monthlyExpenseListBox.Items.Add(item);
                monthlyExpenses += values[key];
            }
            return monthlyExpenses;
        }

        private double LoadIncome()
        {
            incomeOverviewListBox.Items.Clear();
            double income = 0;
            var values = IncomeDTO.GetIncomeTypesAndAmount();
            foreach (var key in values.Keys)
            {
                ListViewItem item = new(key);
                item.SubItems.Add(values[key].ToString());
                incomeOverviewListBox.Items.Add(item);
                income += values[key];
            }
            return income;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newIncomeType = newIncomeTextBox.Text;
            var newIncomeAmount = newIncomeAmountTextBox.Text;

            ListViewItem item = new(newIncomeType);
            item.SubItems.Add(newIncomeAmount.ToString());
            incomeOverviewListBox.Items.Add(item);

            totalIncomeTextBox.Text = (double.Parse(totalIncomeTextBox.Text) + double.Parse(newIncomeAmount)).ToString();
            newIncomeTextBox.Clear();
            newIncomeAmountTextBox.Clear();
        }

        private void newMonthlyExpenseButton_Click(object sender, EventArgs e)
        {
            var newExpenseType = newMonthlyExpenseTextBox.Text;
            var newExpenseAmount = newMonthlyExpenseAmountTextBox.Text;
            ListViewItem item = new(newExpenseType);
            item.SubItems.Add(newExpenseAmount.ToString());
            monthlyExpenseListBox.Items.Add(item);

            totalMonthlyExpensesTextBox.Text = (double.Parse(totalMonthlyExpensesTextBox.Text) + double.Parse(newExpenseAmount)).ToString();
            newMonthlyExpenseTextBox.Clear();
            newMonthlyExpenseAmountTextBox.Clear();
        }








        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void incomeAmountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
