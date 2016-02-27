using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class EditLessons : System.Web.UI.Page
{

    public string show = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM Lessons";

        DataTable dt = MyAdoHelper.ExecuteDataTable("DB.mdb", sql);        

        if (dt.Rows.Count > 0)
        {
            show += "<table>";
            show += "<tr>";
            show += "<th>שם תלמיד</th>";
            show += "<th>תאריך שיעור</th>";
            show += "<th>שעת שיעור</th>";
            show += "<th>עדכן שיעור</th>";
            show += "<th>מחק שיעור</th>";
            show += "</tr>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                show += "<tr>";
                show += "<form method='post' action='AdminEditLesson.aspx'>";

                show += "<td><input type='text' value='" + dt.Rows[i]["studentName"] + "'/></td>";
                show += "<td><input type='text' value='" + dt.Rows[i]["LessonDate"] + "'/></td>";
                show += "<td><input type='text' value='" + dt.Rows[i]["Time"] + "'/></td>";
                show += "<td><input type='sumbit' value='עדכן' name='submit'/></td>";
<<<<<<< HEAD
                show += "<td><input type='button' value='מחק' onclick='window.location.href=\"DeleteLesson.aspx?id=" + dt.Rows[i]["ID"] + "\' />"
=======
                show += "<td><input type='button' value='מחק' onclick='window.location.href=\"DeleteLesson.aspx?date=" + dt.Rows[i]["LessonDate"] + "\' />";
>>>>>>> bf68a864a408c75c7149bb97290d56d935e9b7fc
                
                show += "</form>";
                show += "</tr>";
            }

            show += "</table>";
        }
    }
}