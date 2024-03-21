namespace Budgetmaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            incomeTypesAndAmountsListBox = new ListView();
            incomeType = new ColumnHeader();
            incomeAmont = new ColumnHeader();
            totalIncomeLabel = new Label();
            totalIncomeTextBox = new TextBox();
            monthlyExpensesListBox = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            totalMonthlyEcpensesTextBox = new TextBox();
            totalMonthlyExpensesLabel = new Label();
            totalLeftTextBox = new TextBox();
            totalLeftLabel = new Label();
            weeklyExpensesLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 0;
            label1.Text = "BudgetMaker";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(223, 19);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 1;
            button1.Text = "Setup monthly info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // incomeTypesAndAmountsListBox
            // 
            incomeTypesAndAmountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            incomeTypesAndAmountsListBox.Columns.AddRange(new ColumnHeader[] { incomeType, incomeAmont });
            incomeTypesAndAmountsListBox.Location = new Point(25, 117);
            incomeTypesAndAmountsListBox.Name = "incomeTypesAndAmountsListBox";
            incomeTypesAndAmountsListBox.Size = new Size(364, 168);
            incomeTypesAndAmountsListBox.TabIndex = 4;
            incomeTypesAndAmountsListBox.UseCompatibleStateImageBehavior = false;
            incomeTypesAndAmountsListBox.View = View.Details;
            // 
            // incomeType
            // 
            incomeType.Text = "Income type";
            incomeType.Width = 150;
            // 
            // incomeAmont
            // 
            incomeAmont.Text = "Amount";
            incomeAmont.Width = 150;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalIncomeLabel.Location = new Point(35, 77);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.RightToLeft = RightToLeft.No;
            totalIncomeLabel.Size = new Size(134, 28);
            totalIncomeLabel.TabIndex = 5;
            totalIncomeLabel.Text = "Total Income";
            // 
            // totalIncomeTextBox
            // 
            totalIncomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            totalIncomeTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalIncomeTextBox.Location = new Point(175, 77);
            totalIncomeTextBox.Name = "totalIncomeTextBox";
            totalIncomeTextBox.PlaceholderText = "Total Income";
            totalIncomeTextBox.Size = new Size(152, 34);
            totalIncomeTextBox.TabIndex = 6;
            totalIncomeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // monthlyExpensesListBox
            // 
            monthlyExpensesListBox.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            monthlyExpensesListBox.Location = new Point(418, 117);
            monthlyExpensesListBox.Name = "monthlyExpensesListBox";
            monthlyExpensesListBox.Size = new Size(376, 168);
            monthlyExpensesListBox.TabIndex = 7;
            monthlyExpensesListBox.UseCompatibleStateImageBehavior = false;
            monthlyExpensesListBox.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Expense Type";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 150;
            // 
            // totalMonthlyEcpensesTextBox
            // 
            totalMonthlyEcpensesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            totalMonthlyEcpensesTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalMonthlyEcpensesTextBox.Location = new Point(652, 74);
            totalMonthlyEcpensesTextBox.Name = "totalMonthlyEcpensesTextBox";
            totalMonthlyEcpensesTextBox.PlaceholderText = "Total Monthly Expenses";
            totalMonthlyEcpensesTextBox.Size = new Size(152, 34);
            totalMonthlyEcpensesTextBox.TabIndex = 9;
            totalMonthlyEcpensesTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // totalMonthlyExpensesLabel
            // 
            totalMonthlyExpensesLabel.AutoSize = true;
            totalMonthlyExpensesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalMonthlyExpensesLabel.Location = new Point(418, 77);
            totalMonthlyExpensesLabel.Name = "totalMonthlyExpensesLabel";
            totalMonthlyExpensesLabel.RightToLeft = RightToLeft.No;
            totalMonthlyExpensesLabel.Size = new Size(207, 28);
            totalMonthlyExpensesLabel.TabIndex = 8;
            totalMonthlyExpensesLabel.Text = "Total Fixed Expenses";
            // 
            // totalLeftTextBox
            // 
            totalLeftTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            totalLeftTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalLeftTextBox.Location = new Point(1009, 77);
            totalLeftTextBox.Name = "totalLeftTextBox";
            totalLeftTextBox.PlaceholderText = "Total left after Expenses";
            totalLeftTextBox.Size = new Size(152, 34);
            totalLeftTextBox.TabIndex = 10;
            totalLeftTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // totalLeftLabel
            // 
            totalLeftLabel.AutoSize = true;
            totalLeftLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalLeftLabel.Location = new Point(810, 77);
            totalLeftLabel.Name = "totalLeftLabel";
            totalLeftLabel.RightToLeft = RightToLeft.No;
            totalLeftLabel.Size = new Size(193, 28);
            totalLeftLabel.TabIndex = 11;
            totalLeftLabel.Text = "Left after expenses";
            // 
            // weeklyExpensesLabel
            // 
            weeklyExpensesLabel.AutoSize = true;
            weeklyExpensesLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            weeklyExpensesLabel.Location = new Point(35, 399);
            weeklyExpensesLabel.Name = "weeklyExpensesLabel";
            weeklyExpensesLabel.Size = new Size(173, 28);
            weeklyExpensesLabel.TabIndex = 0;
            weeklyExpensesLabel.Text = "Weekly expenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(25, 453);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1193, 347);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1185, 319);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1185, 319);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1185, 319);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 812);
            Controls.Add(tabControl1);
            Controls.Add(weeklyExpensesLabel);
            Controls.Add(totalLeftLabel);
            Controls.Add(totalLeftTextBox);
            Controls.Add(totalMonthlyEcpensesTextBox);
            Controls.Add(totalMonthlyExpensesLabel);
            Controls.Add(monthlyExpensesListBox);
            Controls.Add(totalIncomeTextBox);
            Controls.Add(totalIncomeLabel);
            Controls.Add(incomeTypesAndAmountsListBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "BugdetMaker";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListView incomeTypesAndAmountsListBox;
        private ColumnHeader incomeType;
        private ColumnHeader incomeAmont;
        private Label totalIncomeLabel;
        private TextBox totalIncomeTextBox;
        private ListView monthlyExpensesListBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox totalMonthlyEcpensesTextBox;
        private Label totalMonthlyExpensesLabel;
        private TextBox totalLeftTextBox;
        private Label totalLeftLabel;
        private Label weeklyExpensesLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
