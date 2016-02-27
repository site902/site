using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{

    string fileName = "DB.mdb";
    string tableName = "td";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            List<KeyValuePair<string, string>> fields = new List<KeyValuePair<string, string>>();

            string[] keys = 
        {
            "username",
            "fname",
            "lname",
            "phone",
            "[password]",
            "gender"
        };            

            for (int i = 0; i < 6; i++)
            {
                string key = keys[i];
                string value = Request.Form[key];

                KeyValuePair<string, string> temp = new KeyValuePair<string, string>(key, value);

                fields.Add(temp);                
            }

            string sql = "INSERT INTO " + tableName + " (" + fields[0].Key;

            for (int i = 1; i < fields.Count; i++)
            {
                sql += "," + fields[i].Key;
            }

            sql += ") VALUES ('" + fields[0].Value + "'";

            for (int i = 1; i < fields.Count; i++)
            {
                sql += ",'" + fields[i].Value + "'";
            }

            sql += ")";

            MyAdoHelper.DoQuery(fileName, sql);
        }        
    }
}