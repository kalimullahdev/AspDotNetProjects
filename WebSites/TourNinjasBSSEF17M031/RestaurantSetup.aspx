<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RestaurantSetup.aspx.cs" Inherits="RestaurantSetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="BootstrapCss/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="card container">
        <div class="row py-4">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <div class="col-lg-12 pb-2">
                    <h1 id="page_heading">Add New City</h1>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Restaurant Name:</label>
                        <asp:TextBox runat="server" ID="txtRestaurantName" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>


                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Restaurant Description:</label>
                        <asp:TextBox runat="server" ID="txtRestaurantDescription" CssClass="form-control" TextMode="MultiLine"> </asp:TextBox>
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
