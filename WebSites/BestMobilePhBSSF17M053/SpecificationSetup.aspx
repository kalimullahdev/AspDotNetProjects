<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SpecificationSetup.aspx.cs" Inherits="SpecificationSetup" %>

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
                <div class="col-lg-12 pb-2 text-center">
                    <h1 id="page_heading">Specification Setup</h1>
                </div>

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Front Camera:</label>
                        <asp:TextBox runat="server" ID="txtFrontCamera" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Back Camera:</label>
                        <asp:TextBox runat="server" ID="txtBackCamera" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>
                
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Battery Capacity:</label>
                        <asp:TextBox runat="server" ID="txtBattery" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>RAM:</label>
                        <asp:TextBox runat="server" ID="txtRAM" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Storage:</label>
                        <asp:TextBox runat="server" ID="txtStorage" CssClass="form-control"> </asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <label>Processor:</label>
                        <asp:TextBox runat="server" ID="txtProcessor" CssClass="form-control" > </asp:TextBox>
                    </div>
                </div>

                <div class="col-lg-12">
                    <div class="form-group">
                        <label>OS:</label>
                        <asp:TextBox runat="server" ID="txtOS" CssClass="form-control"> </asp:TextBox>
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
