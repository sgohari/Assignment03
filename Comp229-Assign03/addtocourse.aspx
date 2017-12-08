<%@ Page Title="AddCourse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addtocourse.aspx.cs" Inherits="Comp229_Assign03.addtocourse" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="addCourse">
        <h1>Here you can enroll a student to a course!</h1>
        <h2>Following steps are must.</h2>
       
        <ul id="AddCourseul">
            <li>Enter the Existance StudentID</li>
            <li>Enter the Existance CourseID</li>
        </ul>
         
        <hr />
        <table id="addCourseTable">
            <tr>
                <td>StudentID:</td>
                <td>
                    <asp:TextBox ID="txtBxStudentID" runat="server"></asp:TextBox><br />

                </td>
            </tr>

            <tr>
                <td>CourseID:</td>
                <td>
                    <asp:TextBox ID="txtBxCourseID" runat="server"></asp:TextBox>
<%--                    <asp:DropDownList runat="server" ID="ddlAddCourse" DataTextField="CourseID" DataValueField="CourseID">

                    </asp:DropDownList>--%>
                </td>
            </tr>
            <tr>
                <td >Grade:</td>
                <td>
                    <asp:TextBox ID="txtBxGrade" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div id="BtnDivforAddCourse">
        <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" CssClass="BtnaddCoursePage" />
        <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="BtnaddCoursePage" />
        </div>


        <br />
    </div>
</asp:Content>
