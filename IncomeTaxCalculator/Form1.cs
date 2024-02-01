namespace IncomeTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);

            decimal taxOwed = CalculateTaxBurden(taxableIncome);

            txtTaxableIncomeOwed.Text = taxOwed.ToString();
        }

        private static decimal CalculateTaxBurden(decimal income)
        {
            decimal taxOwed = 0m;

            if (income <= 11000)
            {
                taxOwed = income * .10m;
            }
            else if (income <= 44735 && income > 11000)
            {
                taxOwed = ((income - 11000) * .12m) + 1100;
            }
            else if (income <= 95375 && income > 44735)
            {
                taxOwed = ((income - 44735) * .22m) + 5147;
            }
            else
            {
                taxOwed = ((income - 95375) * 1m) + 16290;
            }

            return taxOwed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaxableIncome_TextChanged(object sender, EventArgs e)
        {
            txtTaxableIncomeOwed.Clear();
        }
    }
}