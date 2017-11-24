<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addstudents.aspx.cs" Inherits="Comp229_Assign03.addstudents" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div>
         <table>
             <tr>
                 <td>Enter StudentID</td>
                 <td>
                 <asp:TextBox ID="txtBxStID" runat="server"></asp:TextBox>
                 </td>
             </tr>
              <tr>
                 <td>Enter Firt Name</td>
                 <td>
                 <asp:TextBox ID="txtBxFname" runat="server"></asp:TextBox>
                 </td>
             </tr>
     
             <tr>
                 <td>Enter Last Name</td>
                 <td>
                 <asp:TextBox ID="txtBxLname" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>Enter Enrollment Date</td>
                 <td>
                 <asp:TextBox ID="txtBxEnrDate" runat="server"></asp:TextBox>
                 </td>
             </tr>
             </table>
         <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
     </div>
</asp:Content>
