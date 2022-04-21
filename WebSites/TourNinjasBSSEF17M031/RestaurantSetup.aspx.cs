using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RestaurantSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;



        int rid = Convert.ToInt32(Request.QueryString["restaurantID"]);

        if (Request.QueryString["restaurantID"] != null)
        {
            using (var db = new TourNinjasDatabaseEntities())
            {

                tableRestaurant restaurant = db.tableRestaurants.FirstOrDefault(v => v.restaurantID == rid);
                txtRestaurantName.Text = restaurant.restaurantName;
                txtRestaurantDescription.Text = restaurant.restaurantDescription;

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int rid = Convert.ToInt32(Request.QueryString["restaurantID"]);
        if (Request.QueryString["restaurantID"] != null)
        {

            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableRestaurant restaurant = db.tableRestaurants.FirstOrDefault(v => v.restaurantID == rid);
                restaurant.restaurantName = txtRestaurantName.Text;
                restaurant.restaurantDescription = txtRestaurantDescription.Text;
                db.SaveChanges();
                int cid = Convert.ToInt32(Request.QueryString["cityid"]);
                Response.Redirect("RestaurantsPage.aspx?cityid=" + cid);
            }

        }
        else
        {

            int cid = Convert.ToInt32(Request.QueryString["cityid"]);
            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableRestaurant restaurant = new tableRestaurant();
                restaurant.restaurantName = txtRestaurantName.Text;
                restaurant.restaurantDescription = txtRestaurantDescription.Text;
                restaurant.cityID = cid;
                db.tableRestaurants.Add(restaurant);
                db.SaveChanges();
                Response.Redirect("RestaurantsPage.aspx?cityid=" + cid);
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Request.QueryString["cityid"]);
        Response.Redirect("RestaurantsPage.aspx?cityid=" + cid);
    }
}