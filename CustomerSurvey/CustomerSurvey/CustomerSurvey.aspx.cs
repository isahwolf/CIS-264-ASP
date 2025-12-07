using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CustomerSurvey
{
    public partial class CustomerSurvey : System.Web.UI.Page
    {
        Survey selectedSurvey = new Survey();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataBind();
            }

            //string cs = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            ////Create connection
            //SqlConnection con = new SqlConnection(cs);

            ////Create command
            //string sql = "select name, phone FROM customers WHERE customerID = '" + 
            //    customersListBox.SelectedItem.Value + "'";
            //SqlCommand cmd = new SqlCommand(sql, con);

            ////Open connection
            //con.Open();

            ////Execute command
            //SqlDataReader rdr = cmd.ExecuteReader();

            //rdr.Read();
            //selectedSurvey.CustomerID = ((int)rdr["CustomerID"]);
            //selectedSurvey.CustomerName = rdr["Name"].ToString();
            //selectedSurvey.ResponseTime = ((int)rdr["ResponseTime"]);
            //selectedSurvey.TechEfficiency = ((int)rdr["TechEfficiency"]);
            //selectedSurvey.Resolution = ((int)rdr["Resolution"]);
            //selectedSurvey.Comments = rdr["Comments"].ToString();
            //selectedSurvey.Phone = rdr["Phone"].ToString();
            //selectedSurvey.Contact = ((bool)rdr["UnitPrice"]);
            //rdr.Close();
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            //Create connection
            SqlConnection con = new SqlConnection(cs);

            //Create command
            string sql = "select Name, Phone FROM Customers WHERE CustomerID = '" +
                customersListBox.SelectedItem.Value + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            //Open connection
            con.Open();

            //Execute command
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            selectedSurvey.CustomerID = int.Parse(customersListBox.SelectedValue);
            selectedSurvey.CustomerName = rdr["Name"].ToString();
            selectedSurvey.ResponseTime = int.Parse(responseTimeRBL.SelectedValue);
            selectedSurvey.TechEfficiency = int.Parse(efficiencyRBL.SelectedValue);
            selectedSurvey.Resolution = int.Parse(resolutionRBL.SelectedValue);
            selectedSurvey.Comments = commentsTextBox.Text;
            selectedSurvey.Phone = rdr["Phone"].ToString();
            selectedSurvey.Contact = contactCheckBox.Checked;
            rdr.Close();

            Session["Customer"] = selectedSurvey;

            Response.Redirect("SurveyComplete.aspx");
        }
    }
}