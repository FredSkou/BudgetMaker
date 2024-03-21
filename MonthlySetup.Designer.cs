namespace Budgetmaker
{
    partial class MonthlySetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newIncomeAmountTextBox = new TextBox();
            newIncomeTextBox = new TextBox();
            button1 = new Button();
            incomeOverviewListBox = new ListView();
            incomeTypes = new ColumnHeader();
            incomeAmount = new ColumnHeader();
            monthlyExpenseListBox = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            newMonthlyExpenseTextBox = new TextBox();
            newMonthlyExpenseAmountTextBox = new TextBox();
            newMonthlyExpenseButton = new Button();
            totalIncomeLabel = new Label();
            totalMonthlyExpensesLabel = new Label();
            totalMonthlyExpensesTextBox = new TextBox();
            totalIncomeTextBox = new TextBox();
            SuspendLayout();
            // 
            // newIncomeAmountTextBox
            // 
            newIncomeAmountTextBox.Location = new Point(138, 134);
            newIncomeAmountTextBox.Name = "newIncomeAmountTextBox";
            newIncomeAmountTextBox.PlaceholderText = "Amount";
            newIncomeAmountTextBox.Size = new Size(120, 23);
            newIncomeAmountTextBox.TabIndex = 3;
            newIncomeAmountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // newIncomeTextBox
            // 
            newIncomeTextBox.Location = new Point(12, 134);
            newIncomeTextBox.Name = "newIncomeTextBox";
            newIncomeTextBox.PlaceholderText = "New Income";
            newIncomeTextBox.Size = new Size(129, 23);
            newIncomeTextBox.TabIndex = 4;
            newIncomeTextBox.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(264, 134);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // incomeOverviewListBox
            // 
            incomeOverviewListBox.Columns.AddRange(new ColumnHeader[] { incomeTypes, incomeAmount });
            incomeOverviewListBox.Location = new Point(12, 163);
            incomeOverviewListBox.Name = "incomeOverviewListBox";
            incomeOverviewListBox.Size = new Size(246, 150);
            incomeOverviewListBox.TabIndex = 6;
            incomeOverviewListBox.UseCompatibleStateImageBehavior = false;
            incomeOverviewListBox.View = View.Details;
            // 
            // incomeTypes
            // 
            incomeTypes.Text = "Income type";
            incomeTypes.Width = 150;
            // 
            // incomeAmount
            // 
            incomeAmount.Text = "Amount";
            incomeAmount.Width = 150;
            // 
            // monthlyExpenseListBox
            // 
            monthlyExpenseListBox.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            monthlyExpenseListBox.Location = new Point(12, 406);
            monthlyExpenseListBox.Name = "monthlyExpenseListBox";
            monthlyExpenseListBox.Size = new Size(246, 150);
            monthlyExpenseListBox.TabIndex = 9;
            monthlyExpenseListBox.UseCompatibleStateImageBehavior = false;
            monthlyExpenseListBox.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Expense type";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 150;
            // 
            // newMonthlyExpenseTextBox
            // 
            newMonthlyExpenseTextBox.Location = new Point(12, 377);
            newMonthlyExpenseTextBox.Name = "newMonthlyExpenseTextBox";
            newMonthlyExpenseTextBox.PlaceholderText = "New Monthly Expense";
            newMonthlyExpenseTextBox.Size = new Size(129, 23);
            newMonthlyExpenseTextBox.TabIndex = 8;
            // 
            // newMonthlyExpenseAmountTextBox
            // 
            newMonthlyExpenseAmountTextBox.Location = new Point(138, 377);
            newMonthlyExpenseAmountTextBox.Name = "newMonthlyExpenseAmountTextBox";
            newMonthlyExpenseAmountTextBox.PlaceholderText = "Amount";
            newMonthlyExpenseAmountTextBox.Size = new Size(120, 23);
            newMonthlyExpenseAmountTextBox.TabIndex = 7;
            newMonthlyExpenseAmountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // newMonthlyExpenseButton
            // 
            newMonthlyExpenseButton.Location = new Point(264, 377);
            newMonthlyExpenseButton.Name = "newMonthlyExpenseButton";
            newMonthlyExpenseButton.Size = new Size(89, 23);
            newMonthlyExpenseButton.TabIndex = 10;
            newMonthlyExpenseButton.Text = "Add";
            newMonthlyExpenseButton.UseVisualStyleBackColor = true;
            newMonthlyExpenseButton.Click += newMonthlyExpenseButton_Click;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Location = new Point(12, 104);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(123, 15);
            totalIncomeLabel.TabIndex = 11;
            totalIncomeLabel.Text = "Total Monthly Income";
            // 
            // totalMonthlyExpensesLabel
            // 
            totalMonthlyExpensesLabel.AutoSize = true;
            totalMonthlyExpensesLabel.Location = new Point(12, 349);
            totalMonthlyExpensesLabel.Name = "totalMonthlyExpensesLabel";
            totalMonthlyExpensesLabel.Size = new Size(131, 15);
            totalMonthlyExpensesLabel.TabIndex = 12;
            totalMonthlyExpensesLabel.Text = "Total monthly expenses";
            // 
            // totalMonthlyExpensesTextBox
            // 
            totalMonthlyExpensesTextBox.Location = new Point(158, 349);
            totalMonthlyExpensesTextBox.Name = "totalMonthlyExpensesTextBox";
            totalMonthlyExpensesTextBox.PlaceholderText = "Amount";
            totalMonthlyExpensesTextBox.ReadOnly = true;
            totalMonthlyExpensesTextBox.Size = new Size(100, 23);
            totalMonthlyExpensesTextBox.TabIndex = 13;
            totalMonthlyExpensesTextBox.TextAlign = HorizontalAlignment.Right;
            totalMonthlyExpensesTextBox.TextChanged += textBox1_TextChanged;
            // 
            // totalIncomeTextBox
            // 
            totalIncomeTextBox.Location = new Point(158, 104);
            totalIncomeTextBox.Name = "totalIncomeTextBox";
            totalIncomeTextBox.PlaceholderText = "Amount";
            totalIncomeTextBox.ReadOnly = true;
            totalIncomeTextBox.Size = new Size(100, 23);
            totalIncomeTextBox.TabIndex = 14;
            totalIncomeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // MonthlySetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 776);
            Controls.Add(totalIncomeTextBox);
            Controls.Add(totalMonthlyExpensesTextBox);
            Controls.Add(totalMonthlyExpensesLabel);
            Controls.Add(totalIncomeLabel);
            Controls.Add(newMonthlyExpenseButton);
            Controls.Add(monthlyExpenseListBox);
            Controls.Add(newMonthlyExpenseTextBox);
            Controls.Add(newMonthlyExpenseAmountTextBox);
            Controls.Add(incomeOverviewListBox);
            Controls.Add(button1);
            Controls.Add(newIncomeTextBox);
            Controls.Add(newIncomeAmountTextBox);
            Name = "MonthlySetup";
            Text = "MonthlySetup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox newIncomeAmountTextBox;
        private TextBox newIncomeTextBox;
        private Button button1;
        private ListView incomeOverviewListBox;
        private ColumnHeader incomeTypes;
        private ColumnHeader incomeAmount;
        private ListView monthlyExpenseListBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox newMonthlyExpenseTextBox;
        private TextBox newMonthlyExpenseAmountTextBox;
        private Button newMonthlyExpenseButton;
        private Label totalIncomeLabel;
        private Label totalMonthlyExpensesLabel;
        private TextBox totalMonthlyExpensesTextBox;
        private TextBox totalIncomeTextBox;
    }
}