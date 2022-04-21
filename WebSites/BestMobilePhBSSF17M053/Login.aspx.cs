using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
        using (var db = new BestMobilePh53Entities())
        {
            var query = db.DoLogin(txtEmail.Text, txtPassword.Text);




            if (query != null) 
            {
                Response.Redirect("Default.aspx");

            }
            else
            {
                lbErrorMsg.Text = "Auth error";
            }
        }
    }
}