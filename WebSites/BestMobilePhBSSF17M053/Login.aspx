<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="card container">
        <div class="row py-4">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <div class="col-lg-12 pb-2">
                    <h1 id="page_heading">Admin Login</h1>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Email:</label>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"  TextMode="Email"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Password:</label>
                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"  TextMode="Password"> </asp:TextBox>
                    </div>
                </div>


                <div class="col-lg-12">
                    <div class="form-group">
                        <asp:Button runat="server" ID="btn_login" OnClick="btn_login_Click" Text="Login" CssClass="form-control btn-primary"/>
                    </div>
                </div>

                <asp:Label Text="" ID="lbErrorMsg" runat="server" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
