using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        displayUsers();
    }

    protected void displayUsers()
    {
        using (var db = new BestMobilePh53Entities())
        {
            var users = db.GetUserType();
            GV.DataSource = users;
            GV.DataBind();
        }
    }

    protected void save_User_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserTypeSetup.aspx");
    }
    protected void editBtn_Click(object sender, EventArgs e)
    {

    }
    protected void deleteBtn_Command(object sender, CommandEventArgs e)
    {

    }
    protected void editBtn_Command(object sender, CommandEventArgs e)
    {

    }
    protected void GV_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        int id = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "deleteUser")
        {
            using (var db = new BestMobilePh53Entities())
            {
                db.DeleteUserType(id);
            }
            displayUsers();
        }
        else if (e.CommandName == "editUser")
        {
            Response.Redirect("UserTypeSetup.aspx?UserTypeID=" + id);
        }
    }
}