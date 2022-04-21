<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RestaurantsPage.aspx.cs" Inherits="RestaurantsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="card container pt-2">
            <div class="row">
                <div class=" col-md-4"> </div>
                <div class=" col-md-3  ">
                    <div class="form-group">
                        <asp:Button runat="server" ID="save_User" OnClick="save_User_Click" Text="Add New" CssClass="form-control btn-primary"/>
                    </div>
                </div>
                <div class=" col-md-5"> </div>
              <div class="col-md-12">
                <div class="table-responsive">
                  <asp:GridView ID="GV" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-condensed" OnRowCommand="GV_RowCommand">
              
                    <Columns>
                    
                    <asp:TemplateField HeaderText="Restaurant ID">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblrestaurantID" Text='<%# Eval("restaurantID") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Restaurant Name">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblrestaurantName" Text='<%# Eval("restaurantName") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Restaurant Description">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblrestaurantDescription" Text='<%# Eval("restaurantDescription") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="City">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblcityID" Text='<%# Eval("cityID") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>                                
                        <asp:Button runat="server" ID="editBtn"  CommandName="editRest" CommandArgument='<%# Eval("restaurantID") %>' Text="Edit" CssClass="btn btn-info"  />
                        <asp:Button runat="server" ID="deleteBtn"  CommandName="deleteRest" CommandArgument='<%# Eval("restaurantID") %>' Text="Delete" CssClass="btn btn-info"   />
                    </ItemTemplate>
                    </asp:TemplateField>


                    </Columns>
                  </asp:GridView>
                </div>
              </div>
            </div>
          </div>
</asp:Content>

