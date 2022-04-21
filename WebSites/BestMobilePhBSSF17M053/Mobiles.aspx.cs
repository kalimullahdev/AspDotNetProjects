using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mobiles : System.Web.UI.Page
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
            var mobiles = db.GetAllMobiles();
            GV.DataSource = mobiles;
            GV.DataBind();
        }
    }
    protected void save_mobile_Click(object sender, EventArgs e)
    {

        Response.Redirect("MobileSetup.aspx");
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
        if (e.CommandName == "deleteMobile")
        {
            using (var db = new BestMobilePh53Entities())
            {
                db.DeleteMobile(id);
            }
            displayUsers();
        }
        else if (e.CommandName == "editMobile")
        {
            Response.Redirect("MobileSetup.aspx?MobileID=" + id);
        }
    }

    protected void editSpecification_Command(object sender, CommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        Response.Redirect("SpecificationSetup.aspx?MobileID=" + id);
    }


}