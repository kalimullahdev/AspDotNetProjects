<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileSetup.aspx.cs" Inherits="MobileSetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add or Edit Mobile</title>
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="pt-4">
    <div class="card container">
        <div class="row py-4">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <div class="col-lg-12 pb-2">
                    <h1 id="page_heading">Add New Mobile Phone</h1>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Mobile Name:</label>
                        <asp:TextBox runat="server" ID="txtMobileName" CssClass="form-control" > </asp:TextBox>
                    </div>
                </div>
                            

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Mobile Image:</label>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                </div>
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>  

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Mobile Description:</label>
                        <asp:TextBox runat="server" ID="txtMobileDescription" CssClass="form-control"> </asp:TextBox>
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
