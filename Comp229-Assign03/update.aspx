﻿<%@ Page Title="update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Comp229_Assign03.update" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1> Update pages</h1>
  <div id="addStudent">
         <table>
              <tr>
                 <td class="WidthForColunms">First Name:</td>
                 <td>
                 <asp:TextBox ID="txtBxFname" runat="server"></asp:TextBox><br />
                 </td>
             </tr>
     
             <tr>
                 <td class="WidthForColunms">Last Name:</td>
                 <td>
                 <asp:TextBox ID="txtBxLname" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="WidthForColunms">Enrollment Date:</td>
                 <td>
                 <asp:TextBox ID="txtBxEnrDate" runat="server" ></asp:TextBox>
                 </td>
             </tr>
             </table>

         <br />
         <br />
     </div>
</asp:Content>
