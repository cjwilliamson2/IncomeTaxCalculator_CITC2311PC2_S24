namespace IncomeTaxCalculator
{
    partial class Form1
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
            btnCalculate = new Button();
            btnExit = new Button();
            lblTaxableIncome = new Label();
            lblIncomeTaxOwed = new Label();
            txtTaxableIncome = new TextBox();
            txtTaxableIncomeOwed = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(144, 180);
            btnCalculate.Margin = new Padding(2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(78, 20);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(345, 180);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 20);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTaxableIncome
            // 
            lblTaxableIncome.AutoSize = true;
            lblTaxableIncome.Location = new Point(144, 61);
            lblTaxableIncome.Margin = new Padding(2, 0, 2, 0);
            lblTaxableIncome.Name = "lblTaxableIncome";
            lblTaxableIncome.Size = new Size(92, 15);
            lblTaxableIncome.TabIndex = 4;
            lblTaxableIncome.Text = "Taxable Income:";
            // 
            // lblIncomeTaxOwed
            // 
            lblIncomeTaxOwed.AutoSize = true;
            lblIncomeTaxOwed.Location = new Point(130, 114);
            lblIncomeTaxOwed.Margin = new Padding(2, 0, 2, 0);
            lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            lblIncomeTaxOwed.Size = new Size(104, 15);
            lblIncomeTaxOwed.TabIndex = 5;
            lblIncomeTaxOwed.Text = "Income Tax Owed:";
            // 
            // txtTaxableIncome
            // 
            txtTaxableIncome.Location = new Point(300, 59);
            txtTaxableIncome.Margin = new Padding(2);
            txtTaxableIncome.Name = "txtTaxableIncome";
            txtTaxableIncome.Size = new Size(106, 23);
            txtTaxableIncome.TabIndex = 0;
            txtTaxableIncome.TextChanged += txtTaxableIncome_TextChanged;
            // 
            // txtTaxableIncomeOwed
            // 
            txtTaxableIncomeOwed.Location = new Point(300, 114);
            txtTaxableIncomeOwed.Margin = new Padding(2);
            txtTaxableIncomeOwed.Name = "txtTaxableIncomeOwed";
            txtTaxableIncomeOwed.ReadOnly = true;
            txtTaxableIncomeOwed.Size = new Size(106, 23);
            txtTaxableIncomeOwed.TabIndex = 6;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(560, 270);
            Controls.Add(txtTaxableIncomeOwed);
            Controls.Add(txtTaxableIncome);
            Controls.Add(lblIncomeTaxOwed);
            Controls.Add(lblTaxableIncome);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label lblTaxableIncome;
        private Label lblIncomeTaxOwed;
        private TextBox txtTaxableIncome;
        private TextBox txtTaxableIncomeOwed;
    }
}