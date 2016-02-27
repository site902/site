using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateLesson : System.Web.UI.Page
{

    public string user = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        user += Session["fname"].ToString() + " " + Session["lname"].ToString();
    }
}