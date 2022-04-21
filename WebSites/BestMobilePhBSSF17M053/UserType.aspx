<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserType.aspx.cs" Inherits="UserType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    User Type
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <div class="card container pt-2">
            <div class="row">
                <div class=" col-md-4"> </div>
                <div class=" col-md-3  ">
                    <div class="form-group">
                        <asp:Button runat="server" ID="save_User" OnClick="save_User_Click" Text="Add User Type" CssClass="form-control btn-primary"/>
                    </div>
                </div>
                <div class=" col-md-5"> </div>
              <div class="col-md-12">
                <div class="table-responsive">
                  <asp:GridView ID="GV" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-condensed" OnRowCommand="GV_RowCommand">
              
                    <Columns>
                    
                    <asp:TemplateField HeaderText="User Type ID">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lbUserTypeID" Text='<%# Eval("UserTypeID") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="User Type">
                    <ItemTemplate>                                
                        <asp:Label runat="server" ID="lbUserType" Text='<%# Eval("UserTypeName") %>' ></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>

                   

                    <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>                                
                        <asp:Button runat="server" ID="editBtn" OnCommand="editBtn_Command" CommandName="editUser" CommandArgument='<%# Eval("UserTypeID") %>' Text="Edit" CssClass="btn btn-primary"  />
                        <asp:Button runat="server" ID="deleteBtn" OnCommand="deleteBtn_Command" CommandName="deleteUser" CommandArgument='<%# Eval("UserTypeID") %>' Text="Delete" CssClass="btn btn-danger"   />
                    </ItemTemplate>
                    </asp:TemplateField>


                    </Columns>
                  </asp:GridView>
                </div>
              </div>
            </div>
          </div>
</asp:Content>

