<%@ Page Title="course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="Comp229_Assign03.enrollment" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1> Welcome to the Course page</h1>
     <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-8">
    <asp:GridView ID="GvCourse" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" DataKeyNames="StudentID"
                    OnRowDeleting="StudentGridView_RowDeleting">
                    <Columns>
                        
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                        <asp:BoundField DataField="StudentID" HeaderText="Student ID" Visible="true" />
                        <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true" />
                    
                     <%--  --%>
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i>Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                        <asp:CommandField HeaderText="Edit" EditText="<i class='fa fa-pencil-square-o'></i>Edit" ShowEditButton="True" ButtonType="Link" ControlStyle-CssClass="btn btn-warning btn-sm" />
                    </Columns>
                </asp:GridView>
                <a id="PageBtns" class="btn-lg" href="update.aspx">To Update Page</a>
                <br />
                <br />
                </div>
           </div>
            
        </div>
</asp:Content>
