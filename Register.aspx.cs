using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public string cor = "";
    string fileName = "DB.mdb";
    string tableName = "td";

    public bool IsUSerExist(string username, string phone)
    {
        string sql = "SELECT username FROM td WHERE phone='" + phone + "'";

        return MyAdoHelper.IsExist(fileName, sql);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            List<KeyValuePair<string, string>> fields = new List<KeyValuePair<string, string>>();

            string[] keys = 
        {
            "username",//0
            "fname",//1
            "lname",//2
            "phone",//3
            "pass",//4
            "gender"//5
        };            

            for (int i = 0; i < 6; i++)
            {
                string key = keys[i];
                string value = Request.Form[key];

                KeyValuePair<string, string> temp = new KeyValuePair<string, string>(key, value);

                fields.Add(temp);                
            }

            if (IsUSerExist(fields[0].Value, fields[3].Value))
            {
                cor = "שם משתמש כבר קיים,  אנא בחר  אחד אחר";
            }
            else
            {
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
}