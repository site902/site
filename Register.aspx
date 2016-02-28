<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="jquery/jquery-register.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<<<<<<< HEAD
    <form onsubmit="return CheckForm()" action="" method="post" runat="server">
=======
    <form action="" method="post" runat="server">

        <p><%=cor %></p>

>>>>>>> 482f9969de4000cfc0739f88bf5104eb3c47bd1e
    <table border="0">
        <tr>
            <th>שם משתמש</th>
            <td><input type="text" name="username" id="username" /></td>
            <td><b class="regError" id="e-username"></b></td>
        </tr>
        <tr>
            <th>שם פרטי</th>
            <td><input type="text" name="fname" id="fname" /></td>
            <td><b class="regError" id="e-fname"></b></td>
        </tr>

        <tr>
            <th>שם משפחה</th>
            <td><input type="text" name="lname" id="lname" /></td>
            <td><b class="regError" id="e-lname"></b></td>
        </tr>

        <tr>
            <th>טלפון נייד</th>
            <td dir="ltr">05 <input type="text" name="phone" id="phone" /></td>
            <td><b class="regError" id="e-phone"></b></td>
        </tr>
        <tr>
            <th>סיסמא</th>
            <td><input type="password" name="pass" id="pass" /></td>
            <td><b class="regError" id="e-pass"></b></td>
        </tr>
        <tr>
            <th>מין</th>
            <td>
                <select name="gender" id="gender">
                    <option selected="selected">זכר</option>
                    <option>נקבה</option>
                </select>
            </td>
        </tr>
        <tr><td></td></tr>
        <tr>
            <td><input type="submit" name="submit" value="הרשמה" /></td>
            <td><input type="reset" value="נקה" /></td>
        </tr>
    </table>
    </form>
</asp:Content>