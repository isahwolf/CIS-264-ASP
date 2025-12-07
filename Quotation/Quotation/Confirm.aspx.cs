using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["s"] == null) || !(Session["d"] == null) || !(Session["t"] == null))
            {
                priceLabel.Text = (string)Session["s"];
                discountLabel.Text = (string)Session["d"];
                totalLabel.Text = (string)Session["t"];
            }
        }

        protected void quotationButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = $"Quotation sent to {nameTextBox.Text} at {emailTextBox.Text}.";
            Session["s"] = null;
            Session["d"] = null;
            Session["t"] = null;
        }
    }
}