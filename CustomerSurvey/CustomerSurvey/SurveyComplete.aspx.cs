using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace CustomerSurvey
{
    public partial class SurveyComplete : System.Web.UI.Page
    {
        List<Survey> Customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                Survey customerSurvey = (Survey)Session["Customer"];
                string message = "";

                if (customerSurvey.ResponseTime < 4 || customerSurvey.TechEfficiency < 4 || customerSurvey.Resolution < 4)
                {
                    message = $"Thank you for your feedback, {customerSurvey.CustomerName}. We are sorry you are less than completely satisfied.";
                }
                else
                {
                    message = "Thank you for your feedback! We are glad you are completely satisfied!";
                }

                if (customerSurvey.Contact)
                {
                    message += $" Our customer sales representative will contact you by phone at {customerSurvey.Phone}.";
                }

                messageLabel.Text = message;
            }
            else
            {
                messageLabel.Text = "No survey data found.";
            }
        }
    }
}