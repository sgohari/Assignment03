<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Comp229_Assign03._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>List of all Students</h1>
    <asp:DataList ID="StudentLS" runat="server" />
   
        <asp:Literal ID="detailLireral" runat="server" />
        <asp:LinkButton ID="detailInfo" runat="server" />


    
    <%#Eval ("LastName") %>
    <%#Eval ("firstMidName") %>
    <%#Eval ("EnrollmentDate") %>

   
 </asp:Content>
