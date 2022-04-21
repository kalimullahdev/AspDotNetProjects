using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users : System.Web.UI.Page
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
            var users = db.GetAllUsers();
            GV.DataSource = users;
            GV.DataBind();
        }
    }

    protected void save_User_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddUser.aspx");
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
                db.DeleteUser(id);
            }
            displayUsers();
        }
        else if (e.CommandName == "editUser")
        {
            Response.Redirect("AddUser.aspx?UsersID=" + id);
        }
    }
}