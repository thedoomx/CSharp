using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class ClickCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = "Welcome, " + (string)Session["name"];
            if(!IsPostBack)
            {
                Session["click"] = 0;
                lblTotalClicks.Text = Application["totalClicks"].ToString();
                if(Application[(string)Session["name"]] == null)
                {
                    Application[(string)Session["name"]] = (int)Session["click"];
                }
                else
                {
                    lblUserClicks.Text = Application[(string)Session["name"]].ToString();
                }
                
            }
        }

        protected void btnClicker_Click(object sender, EventArgs e)
        {
            Session["click"] = (int)Session["click"] + 1;
            Application["totalClicks"] = (int)Application["totalClicks"] + 1;
            Application[(string)Session["name"]] = (int)Application[(string)Session["name"]] + 1;

            lblUserClicks.Text = Application[(string)Session["name"]].ToString();
            lblSession.Text = ((int)Session["click"]).ToString();
            lblTotalClicks.Text = Application["totalClicks"].ToString();
        }
    }
}