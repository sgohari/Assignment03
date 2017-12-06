<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Comp229_Assign03._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
  <h1>We educate, train and connect our students to the best employers in the country.</h1>
    <div class="container">
        
        <div class="row">
            <div class="col-md-offset-1 col-md-8">
                <h1>Students list</h1>
                <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" DataKeyNames="StudentID"
                    OnRowDeleting="StudentGridView_RowDeleting">
                    <Columns>
                        <asp:HyperLinkField DataTextField="LastName" HeaderText="Last Name" Visible="true" DataNavigateUrlFields="StudentID"
                             DataNavigateUrlFormatString="student.aspx?StudentID={0}" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />

                    </Columns>
                    <AlternatingRowStyle BackColor="Menu"/>
     
                </asp:GridView>
                <%-- this button is taking user to add student page.
                     I created the student page because of simplacity.
                    I could not do all the functinality of the requirmet in the same page. --%>
                <a id="PageBtns" class="btn-lg, " href="addstudents.aspx"><i class="fa fa-plus"></i> Add New Student</a>
                <br />
                <br />
            </div>
        </div>
    </div>
 </asp:Content>

