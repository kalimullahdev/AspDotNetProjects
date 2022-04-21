using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserTypeSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack) return;



        int uid = Convert.ToInt32(Request.QueryString["UserTypeID"]);

        if (Request.QueryString["UserTypeID"] != null)
        {
            using (var db = new BestMobilePh53Entities())
            {

                tblUserType userType = db.tblUserTypes.FirstOrDefault(v => v.UserTypeID == uid);
                txtUserTypeName.Text = userType.UserTypeName;

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int uid = Convert.ToInt32(Request.QueryString["UserTypeID"]);
        if (Request.QueryString["UserTypeID"] != null)
        {

            using (BestMobilePh53Entities db = new BestMobilePh53Entities())
            {

                tblUserType userType = db.tblUserTypes.FirstOrDefault(v => v.UserTypeID == uid);
                userType.UserTypeName = txtUserTypeName.Text;
                db.SaveChanges();
                Response.Redirect("UserType.aspx");
            }

        }
        else
        {
            using (BestMobilePh53Entities db = new BestMobilePh53Entities())
            {
                tblUserType userType = new tblUserType();
                userType.UserTypeName = txtUserTypeName.Text;
                db.tblUserTypes.Add(userType);
                db.SaveChanges();
                Response.Redirect("UserType.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserType.aspx");
    }

}