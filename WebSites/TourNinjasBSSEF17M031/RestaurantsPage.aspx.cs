using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RestaurantsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        int rid = Convert.ToInt32(Request.QueryString["cityid"]);

        displayCities(rid);

    }

    protected void displayCities(int cid)
    {
        using (var db = new TourNinjasDatabaseEntities())
        {
            var users = db.getCityRestaurants(cid);
            GV.DataSource = users;
            GV.DataBind();
        }
    }

    protected void save_User_Click(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Request.QueryString["cityid"]);
        Response.Redirect("RestaurantSetup.aspx?cityid=" + cid);
    }
   

    protected void GV_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        int rid = Convert.ToInt32(Request.QueryString["cityid"]);
        int id = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "deleteRest")
        {
            using (var db = new TourNinjasDatabaseEntities())
            {
                db.deleteRestaurants(id);
            }
            displayCities(rid);
        }
        else if (e.CommandName == "editRest")
        {
            int cid = Convert.ToInt32(Request.QueryString["cityid"]);
            Response.Redirect("RestaurantSetup.aspx?restaurantID=" + id+"&cityid="+cid);
        }
       



    }
}