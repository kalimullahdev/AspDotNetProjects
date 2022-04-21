using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CitiesPageSetup : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        using (var db = new TourNinjasDatabaseEntities())
        {
            var countries = db.getCountry();
            ddlCityCountry.DataSource = countries;
            ddlCityCountry.DataTextField = "cityCountryName";
            ddlCityCountry.DataValueField = "cityCountry";
            ddlCityCountry.DataBind();
        }

        int cid = Convert.ToInt32(Request.QueryString["cityid"]);

        if (Request.QueryString["cityid"] != null)
        {
            using (var db = new TourNinjasDatabaseEntities())
            {

                tableCity city = db.tableCities.FirstOrDefault(v => v.cityID == cid);
                txtCityName.Text = city.cityName;
                txtCityDescription.Text = city.cityDescription;
                ddlCityCountry.SelectedValue = city.cityCountry.ToString();

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Request.QueryString["cityid"]);
        if (Request.QueryString["cityid"] != null)
        {

            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableCity city = db.tableCities.FirstOrDefault(v => v.cityID == cid);
                city.cityName = txtCityName.Text;
                city.cityDescription = txtCityDescription.Text;
                city.cityCountry = Convert.ToInt32(ddlCityCountry.SelectedValue);
                db.SaveChanges();
                Response.Redirect("CitiesPage.aspx");
            }

        }
        else
        {
            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableCity city = new tableCity();
                city.cityName = txtCityName.Text;
                city.cityDescription = txtCityDescription.Text;
                city.cityCountry = Convert.ToInt32(ddlCityCountry.SelectedValue);
                db.tableCities.Add(city);
                db.SaveChanges();
                Response.Redirect("CitiesPage.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CitiesPage.aspx");
    }
}