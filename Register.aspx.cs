using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<KeyValuePair<string, string>> fields = new List<KeyValuePair<string, string>>(6);

        string[] keys = 
        {
            "username",
            "fname",
            "lname",
            "phone",
            "password",
            "gender"
        };

        for (int i = 0; i < fields.Count; i++)
        {
            string key = keys[i];
            string value = Request.Form[key];

            fields[i] = new KeyValuePair<string, string>(key, value);
        }
    }
}