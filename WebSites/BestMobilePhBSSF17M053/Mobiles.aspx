<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mobiles.aspx.cs" Inherits="Mobiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Mobiles
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">    
    <div class="card container pt-2">
            <div class="row">
                <div class=" col-md-4"> </div>
                <div class=" col-md-3  ">
                    <div class="form-group">
                        <asp:Button runat="server" ID="save_mobile" OnClick="save_mobile_Click" Text="Add New Mobile Phone" CssClass="form-control btn-primary"/>
                    </div>
                </div>
                <div class=" col-md-5"> </div>
              <div class="col-md-12">
                <div class="table-responsive">
                  <asp:GridView ID="GV" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-condensed" OnRowCommand="GV_RowCommand">
              
                    <Columns>
                    
                    <asp:TemplateField HeaderText="MobileID">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lbMobileID" Text='<%# Eval("MobileID") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Mobile Name">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lbMobileName" Text='<%# Eval("MobileName") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Mobile Description">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lbMobileDescription" Text='<%# Eval("MobileDescription") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Specification">
                    <ItemTemplate>                  
                        <asp:Button runat="server" ID="editSpecification" OnCommand="editSpecification_Command" CommandName="editSpecification" CommandArgument='<%# Eval("MobileID") %>' Text="Edit" CssClass="btn btn-primary"  />
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Mobile Image">
                    <ItemTemplate>                                
                        <asp:Image ID="mobileImageID" runat="server" ImageUrl='<%# "~/images/"+Eval("MobileImage") %>' Width="80px" />   
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>                                
                        <asp:Button runat="server" ID="editBtn" OnCommand="editBtn_Command" CommandName="editMobile" CommandArgument='<%# Eval("MobileID") %>' Text="Edit" CssClass="btn btn-primary"  />
                        <asp:Button runat="server" ID="deleteBtn" OnCommand="deleteBtn_Command" CommandName="deleteMobile" CommandArgument='<%# Eval("MobileID") %>' Text="Delete" CssClass="btn btn-danger"   />
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                  </asp:GridView>
                </div>
              </div>
            </div>
          </div>
</asp:Content>

