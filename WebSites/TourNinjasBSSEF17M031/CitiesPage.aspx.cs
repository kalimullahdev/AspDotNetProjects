using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CitiesPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        displayCities();
    }

    protected void displayCities()
    {
        using (var db = new TourNinjasDatabaseEntities())
        {
            var users = db.getCities();
            GV.DataSource = users;
            GV.DataBind();
        }
    }

    protected void save_User_Click(object sender, EventArgs e)
    {
        Response.Redirect("CitiesPageSetup.aspx");
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
        if (e.CommandName == "deleteCity")
        {
            using (var db = new TourNinjasDatabaseEntities())
            {
                db.DeleteUser(id);
            }
            displayCities();
        }
        else if (e.CommandName == "editCity")
        {
            Response.Redirect("CitiesPageSetup.aspx?cityid=" + id);
        }
        else if (e.CommandName == "editRest")
        {
            Response.Redirect("RestaurantSetup.aspx?cityid=" + id);
        }
        else if (e.CommandName == "viewRest")
        {
            Response.Redirect("RestaurantsPage.aspx?cityid=" + id);
        }


        
    }
}