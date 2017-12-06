<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addtocourse.aspx.cs" Inherits="Comp229_Assign03.addtocourse" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div id="addCourse">
         <table>
              <tr>
                 <td class="WidthForColunms">Title:</td>
                 <td>
                 <asp:TextBox ID="txtBxTitle" runat="server"></asp:TextBox><br />
                             
                 </td>
             </tr>
     
             <tr>
                 <td class="WidthForColunms">Credit:</td>
                 <td>
                 <asp:TextBox ID="txtBxCredit" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="WidthForColunms">DepartmentID:</td>
                 <td>
                 <asp:TextBox ID="txtBxDepartmentID" runat="server" ></asp:TextBox>
                 </td>
             </tr>
             </table>
         <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" CssClass="PageBtns"  />
         <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="PageBtns" />
     
         <br />
         <br />
     </div>
</asp:Content>
