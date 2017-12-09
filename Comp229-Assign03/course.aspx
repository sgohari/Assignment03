<%@ Page Title="course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="Comp229_Assign03.enrollment" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContains" runat="server">
        <h1> Welcome to the Course page</h1>
     <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-8">
                <%-- The delete button here only remove student from the course not entirely from database. --%>
    <asp:GridView ID="GvCourse" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" DataKeyNames="StudentID"
                    OnRowDeleting="GvCourse_RowDeleting">
                    <Columns>
                        
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                        <asp:BoundField DataField="StudentID" HeaderText="Student ID" Visible="true" />
                        <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true" />
                    
                     <%--  --%>
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i>Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                        
                    </Columns>
                </asp:GridView>
                <a id="PageBtns" href="update.aspx">To Update Page</a>
                <%-- Adding New students Required two steps
                    First You must enter the existent StudentID
                    2nd You must enter existent CourseID
                    3rd it has been done on saparate page, because it was easy for me to 
                    run my queries. it was done for simplicity. I could not
                    come with idea of doing everything in one page. --%>
                <a id="PageBtn" href="addtocourse.aspx"><i class="fa fa-plus"></i>Add a Course</a>
                <br />
                <br />
                </div>
           </div>
            
        </div>
</asp:Content>
