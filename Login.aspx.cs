using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    public string incor = "";
    string fileName = "DB.mdb";
    string tableName = "td";

    public bool IsUserAndPaswordExist(string username, string password)
    {
        string fileName = "DB.mdb";
        string tableName = "td";

        string isExUsername = "SELECT * FROM " + tableName + " WHERE username = '" + username + "' AND pass = '" + password + "'";

        return MyAdoHelper.IsExist(fileName, isExUsername);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string user = Request.Form["username"];
            string password = Request.Form["password"];

            string isExUsername = "SELECT * FROM " + tableName + " WHERE username = '" + user + "' AND pass = '" + password + "'";

             if (IsUserAndPaswordExist(user, password))
             {
                 DataTable dt = MyAdoHelper.ExecuteDataTable(fileName, isExUsername);

                 if (((bool)dt.Rows[0]["isAdmin"]))
                {
                    Session["admin"] = "True";
                }
                else
                {
                    Session["admin"] = "False";
                }

                Session["username"] = user;
                Session["fname"] = dt.Rows[0]["fname"];
                Session["lname"] = dt.Rows[0]["lname"];

                Response.Redirect("Default.aspx");
             }
             else
             {
                 incor = "alert('user or pasword are incorrect')";
             }
        }        
    }
}