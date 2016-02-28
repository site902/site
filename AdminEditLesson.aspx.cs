using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEditLesson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string name = Request.Form["name"];
            string date = Request.Form["date"];
            string time = Request.Form["time"];

            string sql = "UPDATE Lessons (studentName,LessonDate,Time) VALUES ('" + name + "','" + date + "','" + time + "')";

            MyAdoHelper.DoQuery("DB.mdb", sql);

            Response.Redirect("EditLessons.aspx");

        }
    }
}