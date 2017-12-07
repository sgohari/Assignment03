<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addtocourse.aspx.cs" Inherits="Comp229_Assign03.addtocourse" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div id="addCourse">
                <h1>Here you can enroll student to a course!</h1>
                <h2>Following steps are must.</h2>
                <ul id="AddCourseul">
                    <li>Know the studentID</li>
                    <li>Know the CourseID</li>
                </ul>
         <table>
              <tr>
                 <td class="WidthForColunms">StudentID:</td>
                 <td>
                 <asp:TextBox ID="txtBxStudentID" runat="server"></asp:TextBox><br />
                             
                 </td>
             </tr>
     
             <tr>
                 <td class="WidthForColunms">CourseID:</td>
                 <td>
                 <asp:TextBox ID="txtBxCourseID" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="WidthForColunms">Grade:</td>
                 <td>
                 <asp:TextBox ID="txtBxGrade" runat="server" ></asp:TextBox>
                 </td>
             </tr>
             </table>
         <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" CssClass="PageBtns"  />
         <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" CssClass="PageBtns" />
     
         <br />
         <br />
     </div>
</asp:Content>
