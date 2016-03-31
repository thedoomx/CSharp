using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int? totalClicks = (int?)Application["totalClicks"];

            if(totalClicks == null)
            {
                Application["totalClicks"] = 0;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length != 0)
            {
                string name = TextBox1.Text;

                Session["name"] = TextBox1.Text;
                Response.Redirect("ClickCounter.aspx");
            }
        }
    }
}