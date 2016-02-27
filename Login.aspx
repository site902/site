<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        <%=incor %>
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form name="login" method="post" action="">

        <h3>התחברות:</h3>

        

        <table>
            <tr>
                <td><label>שם משתמש: </label></td>
                <td><input type="text" name="username" /></td>
            </tr>

            <tr>
                <td><label>סיסמא: </label></td>
                <td><input type="password" name="password" /></td><
            </tr>

            <tr>
                <td><input type="submit" name="submit" value="התחברות" /></td>
                <td><input type="reset" name="reset" value="איפוס" /></td>
            </tr>
        </table>

    </form>
</asp:Content>

