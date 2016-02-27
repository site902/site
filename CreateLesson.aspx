<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateLesson.aspx.cs" Inherits="CreateLesson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form name="lesson_C">

        <h3>צור שיעור חדש: </h3>

        <table>
            <tr>                
                <td>שם התלמיד:</td>
                <td><input type="text" value="<%=user %>" id="studentsName"/></td>
            </tr>
            <tr>
                <td>תאריך שיעור:</td>
                <td><input type="date" id="date" name="date" /></td>
            </tr>

            <tr>
                <td>שעת שיעור:</td>
                <td><input type="time" name="time" /></td>
            </tr>

            <tr>
                <td><input type="submit" id="submit" name="submit" value="צור שיעור"/></td>
                <td><input type="reset" value="איפוס" /></td>
            </tr>
        </table>

    </form>

</asp:Content>

