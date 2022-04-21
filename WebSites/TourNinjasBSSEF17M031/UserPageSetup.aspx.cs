using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserPageSetup : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

            using (var db = new TourNinjasDatabaseEntities())
            {
                var userType = db.GetAllUserTypes();
                ddlUserType.DataSource = userType;
                ddlUserType.DataTextField = "userTypeName";
                ddlUserType.DataValueField = "userTypeID";
                ddlUserType.DataBind();
            }

            int uid = Convert.ToInt32(Request.QueryString["UserID"]);

            if (Request.QueryString["UserID"] != null)        
        {
            using (var db = new TourNinjasDatabaseEntities())
            {

                tableUser user = db.tableUsers.FirstOrDefault(v => v.userID == uid);
                txtEmailAddress.Text = user.email;
                txtFirstName.Text = user.firstName;
                txtLastName.Text = user.lastName;
                txtPassword.Text = user.password;
                txtPhoneNo.Text = user.phoneNumber;
                ddlUserType.SelectedValue = user.userTypeID.ToString();
       
            }

            btn_save.Text = "Update";

        }


        
    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int uid = Convert.ToInt32(Request.QueryString["UserID"]);
        if (Request.QueryString["UserID"] != null)
        {

            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableUser user = db.tableUsers.FirstOrDefault(v => v.userID == uid); 
                user.email = txtEmailAddress.Text;
                user.password = txtPassword.Text;
                user.firstName = txtFirstName.Text;
                user.lastName = txtLastName.Text;
                user.phoneNumber = txtPhoneNo.Text;
                user.userTypeID = Convert.ToInt32(ddlUserType.SelectedValue);
                db.SaveChanges();
                Response.Redirect("UserPage.aspx");
            }

        }
        else
        {
            using (TourNinjasDatabaseEntities db = new TourNinjasDatabaseEntities())
            {
                tableUser user = new tableUser();
                user.email = txtEmailAddress.Text;
                user.password = txtPassword.Text;
                user.firstName = txtFirstName.Text;
                user.lastName = txtLastName.Text;
                user.phoneNumber = txtPhoneNo.Text;
                user.userTypeID = Convert.ToInt32(ddlUserType.SelectedValue);
                db.tableUsers.Add(user);
                db.SaveChanges();
                Response.Redirect("UserPage.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserPage.aspx");
    }
}