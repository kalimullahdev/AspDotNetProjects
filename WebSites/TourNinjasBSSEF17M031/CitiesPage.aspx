
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CitiesPage.aspx.cs" Inherits="CitiesPage" %>

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

                    <asp:TemplateField HeaderText="City Name">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblCityName" Text='<%# Eval("cityName") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Restaurants">
                    <ItemTemplate>                                
                        <asp:Button runat="server" ID="viewRest" CommandName="viewRest" CommandArgument='<%# Eval("cityID") %>' Text="View" CssClass="btn btn-info"  />
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City Description">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lblcityDescription" Text='<%# Eval("cityDescription") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>                                
                        <asp:Button runat="server" ID="editBtn" OnCommand="editBtn_Command" CommandName="editCity" CommandArgument='<%# Eval("cityID") %>' Text="Edit" CssClass="btn btn-info"  />
                        <asp:Button runat="server" ID="deleteBtn" OnCommand="deleteBtn_Command" CommandName="deleteCity" CommandArgument='<%# Eval("cityID") %>' Text="Delete" CssClass="btn btn-info"   />
                    </ItemTemplate>
                    </asp:TemplateField>


                    </Columns>
                  </asp:GridView>
                </div>
              </div>
            </div>
          </div>
</asp:Content>

