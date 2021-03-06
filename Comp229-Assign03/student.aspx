﻿<%@ Page Title="student" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Comp229_Assign03.student" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContains" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-8">
                <h1> Student's Details</h1>
                <asp:GridView ID="GvStudent" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" DataKeyNames="StudentID"
                    OnRowDeleting="GvStudent_RowDeleting">
                    <Columns>
                        <asp:HyperLinkField DataTextField="StudentID" HeaderText="Student Id" Visible="true" DataNavigateUrlFields="StudentID"
                             DataNavigateUrlFormatString="update.aspx?StudentID={0}" />
                       
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                        <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}"/>
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i>Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
                <%-- GrideView for Course  --%>
                <asp:GridView ID="GvCourseInStudentPage" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" >
                    <Columns>
                        <asp:HyperLinkField DataTextField="Title" HeaderText="Course Name" Visible="true" DataNavigateUrlFields="CourseID"
                             DataNavigateUrlFormatString="Course.aspx?CourseID={0}" />
                        <asp:BoundField DataField="Credits" HeaderText="Credits" Visible="true" />
                       <asp:BoundField DataField="DepartmentID" HeaderText="Department Number" Visible="true" />
                    </Columns>
                </asp:GridView>
                <a id="PageBtns" class="btn-md" href="addstudents.aspx"><i class="fa fa-plus"></i> Add New Student</a>
                <br />
                <br />
            </div>

        </div>
        
    </div>
         

</asp:Content>
