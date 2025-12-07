using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuotationAppP1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            double sales = double.Parse(salesTextBox.Text);
            double percent = double.Parse(percentTextBox.Text);
            double amount;
            double total;

            amount = sales * (percent / 100);
            total = sales - amount;

            amountLabel.Text = amount.ToString("c");
            totalLabel.Text = total.ToString("c");

        }
    }
}