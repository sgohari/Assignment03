<%@ Page Title="update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Comp229_Assign03.update" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1> Update pages</h1>
    <ul>
        <asp:Repeater ID="myRepeater" runat="server" OnItemCommand="myRepeater_ItemCommand" >
            <ItemTemplate>
                <li>
                    <span id="class"><%# Eval("Title") %></span>
                    <asp:Button runat="server" Text="Update" CommandName="updateCommand" CommandArgument='<%# Eval("Title") %>' /> | 
                    <asp:Button runat="server" Text="Delete" CommandName="deleteCommand" CommandArgument='<%# Eval("CourseID") %>' />
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>   
</asp:Content>
