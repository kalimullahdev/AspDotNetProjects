using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserTypePageSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack) return;



        int uid = Convert.ToInt32(Request.QueryString["UserTypeID"]);

        if (Request.QueryString["UserTypeID"] != null)
        {
            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {

                tableUsersType userType = db.tableUsersTypes.FirstOrDefault(v => v.userTypeID == uid);
                txtUserTypeName.Text = userType.userTypeName;

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int uid = Convert.ToInt32(Request.QueryString["UserTypeID"]);
        if (Request.QueryString["UserTypeID"] != null)
        {

            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {

                tableUsersType userType = db.tableUsersTypes.FirstOrDefault(v => v.userTypeID == uid);
                userType.userTypeName = txtUserTypeName.Text;
                db.SaveChanges();
                Response.Redirect("UserTypePage.aspx");
            }

        }
        else
        {
            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableUsersType userType = new tableUsersType();
                userType.userTypeName = txtUserTypeName.Text;
                db.tableUsersTypes.Add(userType);
                db.SaveChanges();
                Response.Redirect("UserTypePage.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserTypePage.aspx");
    }

}