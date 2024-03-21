namespace Budgetmaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            totalLeftTextBox.Text = (LoadIncome() - LoadMonthlyExpenses()).ToString(); 
        }

        private double LoadMonthlyExpenses()
        {
            double totalMonthlyExpenses = 0;
            var values = MonthlyExpensesDTO.GetMonthyExpenseTypesAndAmount();
            foreach (var key in values.Keys)
            {
                ListViewItem item = new(key);
                item.SubItems.Add(values[key].ToString());
                monthlyExpensesListBox.Items.Add(item);
                totalMonthlyExpenses += values[key];
            }
            totalMonthlyEcpensesTextBox.Text = totalMonthlyExpenses.ToString();
            return totalMonthlyExpenses;
        }

        private double LoadIncome()
        {
            double totalIncome = 0;
            var values = IncomeDTO.GetIncomeTypesAndAmount();
            foreach (var key in values.Keys)
            {
                ListViewItem item = new(key);
                item.SubItems.Add(values[key].ToString());
                incomeTypesAndAmountsListBox.Items.Add(item);
                totalIncome += values[key];
            }
            totalIncomeTextBox.Text = totalIncome.ToString();
            return totalIncome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form monthlySetupForm = new MonthlySetup();
            monthlySetupForm.Show();
        }
    }
}
