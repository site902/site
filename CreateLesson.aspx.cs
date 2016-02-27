using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateLesson : System.Web.UI.Page
{
    string fileName = "Database1.mdb";
    string table = "Lessons";
  
    public string user = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["username"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        
        user += Session["fname"].ToString() + " " + Session["lname"].ToString();

        string name = user;
        string date = Request.Form["date"];

        string hrsS = Request.Form["hrs"];
        int hrs = int.Parse(hrsS);

        string minS = Request.Form["min"];
        int min = int.Parse(minS);

        string sql = "INSERT INTO " + table + "(studentName,LessonDate,hour,minute) VALUES ('" + name + "','" + date + "','" + hrs + "','" + min + "')";

        MyAdoHelper.DoQuery(fileName, sql);

        Response.Redirect("Default.aspx");
    }
}