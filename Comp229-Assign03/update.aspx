<%@ Page Title="update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Comp229_Assign03.update" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContains" runat="server">
        <h1> Update pages</h1>
  <div id="UpdateStudent">
         <table id="UpdateStudentTable">
              <tr>
                 <td>First Name:</td>
                 <td>
                 <asp:TextBox ID="txtBxFname" runat="server"></asp:TextBox><br />
                 </td>
             </tr>
     
             <tr>
                 <td>Last Name:</td>
                 <td>
                 <asp:TextBox ID="txtBxLname" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>Enrollment Date:</td>
                 <td>
                 <asp:TextBox ID="txtBxEnrDate" runat="server" ></asp:TextBox>
                 </td>
             </tr>
             </table>
     <div id="BtnUpdateDiv">
   <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="BtnUpdateStudent" />
         <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" CssClass="BtnUpdateStudent" />
     </div>
      
         <br />

     </div>
</asp:Content>
