using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        using (var db = new BestMobilePh53Entities())
        {
            var userType = db.GetUserType();
            ddlUserType.DataSource = userType;
            ddlUserType.DataTextField = "UserTypeName";
            ddlUserType.DataValueField = "UserTypeID";
            ddlUserType.DataBind();
        }

        int uid = Convert.ToInt32(Request.QueryString["UsersID"]);

        if (Request.QueryString["UsersID"] != null)
        {
            using (var db = new BestMobilePh53Entities())
            {

                tblUser user = db.tblUsers.FirstOrDefault(v => v.UsersID == uid);
                txtEmailAddress.Text = user.EmailAddress;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtPassword.Text = user.Password;
                txtPhoneNo.Text = user.MobileNo;
                ddlUserType.SelectedValue = user.UserTypeID.ToString();

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int uid = Convert.ToInt32(Request.QueryString["MobileID"]);
        if (Request.QueryString["MobileID"] != null)
        {

            using (BestMobilePh53Entities db = new BestMobilePh53Entities())
            {
                tblUser user = db.tblUsers.FirstOrDefault(v => v.UsersID == uid);
                user.EmailAddress = txtEmailAddress.Text;
                user.Password = txtPassword.Text;
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.MobileNo = txtPhoneNo.Text;
                user.Status = true;
                user.UserTypeID = Convert.ToInt32(ddlUserType.SelectedValue);
                db.SaveChanges();
                Response.Redirect("Users.aspx");
            }

        }
        else
        {
            using (BestMobilePh53Entities db = new BestMobilePh53Entities())
            {
                tblUser user = new tblUser();
                user.EmailAddress = txtEmailAddress.Text;
                user.Password = txtPassword.Text;
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.MobileNo = txtPhoneNo.Text;
                user.Status = true;
                user.UserTypeID = Convert.ToInt32(ddlUserType.SelectedValue);
                db.tblUsers.Add(user);
                db.SaveChanges();
                Response.Redirect("Users.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Users.aspx");
    }
}