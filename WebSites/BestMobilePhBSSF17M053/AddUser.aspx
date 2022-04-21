<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserSetup</title>
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    
   <form id="form1" runat="server" class="pt-4">
    <div class="card container">
        <div class="row py-4">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <div class="col-lg-12 pb-2">
                    <h1 id="page_heading">Add New User</h1>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Email Address:</label>
                        <asp:TextBox runat="server" ID="txtEmailAddress" CssClass="form-control" TextMode="Email"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>FirstName:</label>
                        <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>LastName:</label>
                        <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Password:</label>
                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password" > </asp:TextBox>
                    </div>
                </div>


                <div class="col-lg-12">
                    <div class="form-group">
                        <label>User Type:</label>
                        <asp:DropDownList runat="server" ID="ddlUserType" CssClass="custom-select" >

                        </asp:DropDownList>
                    </div>
                </div>

               <div class="col-lg-12">
                    <div class="form-group">
                        <label>Phone Number:</label>
                        <asp:TextBox runat="server" ID="txtPhoneNo" CssClass="form-control" > </asp:TextBox>
                    </div>
                </div>

                <div class="col-lg-12">
                    <div class="form-group">
                        <asp:Button runat="server" ID="btn_save" OnClick="btn_save_Click" Text="Save" CssClass="form-control btn-primary"/>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <asp:Button runat="server" ID="btn_cancel" OnClick="btn_cancel_Click" Text="Cancel" CssClass="form-control btn-primary"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>
</body>
</html>
