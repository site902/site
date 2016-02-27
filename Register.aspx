<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form action="" method="post" runat="server">
    <table border="0">
        <tr>
            <th>שם משתמש</th>
            <td><input type="text" name="username" id="username" /></td>
        </tr>
        <tr>
            <th>שם פרטי</th>
            <td><input type="text" name="fname" id="fname" /></td>
        </tr>
        <tr>
            <th>טלפון נייד</th>
            <td><input type="text" name="phone" id="phone" /></td>
        </tr>
        <tr>
            <th>סיסמא</th>
            <td><input type="password" name="password" id="password" /></td>
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