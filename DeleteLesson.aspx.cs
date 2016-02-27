using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteLesson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];

        string sql = "DELETE FROM Lessons WHERE ID='" + id + "'";

        MyAdoHelper.DoQuery("DB.mdb", sql);

        Response.Redirect("EditLesson.aspx");
    }
}