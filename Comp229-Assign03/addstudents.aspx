<%@ Page Title="AddStudent" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addstudents.aspx.cs" Inherits="Comp229_Assign03.addstudents" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="addStudent">
        <h1>add new student here!</h1>
        <table id="addStudentTable">

            <tr>
                <td>First Name:<br />
                </td>
                <td>
                    <asp:TextBox ID="txtBxFname" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>

            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="txtBxLname" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Enrollment Date:</td>
                <td>
                    <asp:TextBox ID="txtBxEnrDate" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div id="BtnDiv">

            <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" CssClass="PageBtnsforAddStudentPage" />
             <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="PageBtnsforAddStudentPage" />
        </div>      
        <br />
    </div>
</asp:Content>


