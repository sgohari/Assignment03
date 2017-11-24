<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Comp229_Assign03._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>List of all Students</h1>
     <div id="TableDiv">
     
     <asp:Repeater runat="server" ID="MyRepeater">
        
    <ItemTemplate>
        <table >
        <tr>
            <td>
                <strong><%# Eval("LastName") %></strong>

            </td>
            <td>
              <strong> <%# Eval("FirstMidName") %></strong> 

            </td>
        </tr>
            </table>
    </ItemTemplate>
         <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
</asp:Repeater>  
         <br /> 
    <%--     <asp:Button ID="btnInsert" runat="server" Text="Add New Student" OnLoad=""/>--%>
         <a class="btn btn-primary btn-lg" href="addstudents.aspx">Add New Student</a>
    
         <br />
         <br />
         </div>
 </asp:Content>
