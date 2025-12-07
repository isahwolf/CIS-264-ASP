using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quotation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal salesPrice = Convert.ToDecimal(priceTextBox.Text);
            decimal discountPercent = Convert.ToDecimal(percentTextBox.Text) / 100;

            decimal discountAmount = salesPrice * discountPercent;
            decimal totalPrice = salesPrice - discountAmount;

            discountLabel.Text = discountAmount.ToString("c");
            totalLabel.Text = totalPrice.ToString("c");

            Session["s"] = salesPrice.ToString("c");
            Session["d"] = discountAmount.ToString("c");
            Session["t"] = totalPrice.ToString("c");
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            if (!(Session["s"] == null) || !(Session["d"] == null) || !(Session["t"] == null))
            {
                Response.Redirect("Confirm.aspx");
            }
            else
            {
                messageLabel.Text = "Click the Calculate button before you confirm.";
            }
        }
    }
}