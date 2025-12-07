using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerDisplay
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                custDropDownList.SelectedIndex = 0;
                DataBind();
            }



            //Step 1 -- Create Connection Object

            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TechSupport.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            //Step 2 -- Create Command Object

            string sql = "SELECT name, customerid, address, city, state, zipcode, phone, email FROM customers WHERE name = '" +
                custDropDownList.SelectedItem.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, con);

            //Step 3 -- Open the Connection

            con.Open();

            //Step 4 -- Execute Command

            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            addrLabel.Text = (string)rdr["address"];
            cityLabel.Text = (string)rdr["city"] + ", " + rdr["state"] + " " + rdr["zipcode"];
            phoneLabel.Text = (string)rdr["phone"];
            emailLabel.Text = (string)rdr["email"];

            //Step 5 -- Close Connection

            con.Close();

        }

        protected void custDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}