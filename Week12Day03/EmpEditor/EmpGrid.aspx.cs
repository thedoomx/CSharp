using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpEditor
{
    public partial class EmpGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["Week08Day03Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand("SELECT Name FROM Employees"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        command.Connection = con;
                        sda.SelectCommand = command;
                        using(DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            this.ddlEmployees.DataSource = dt;
                            this.ddlEmployees.DataBind();
                        }
                    }
                }
            }
        }

        //protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.ddlEmployees.SelectedValue
        //}
    }
}