using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MobileSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;


        int uid = Convert.ToInt32(Request.QueryString["MobileID"]);

        if (Request.QueryString["MobileID"] != null)
        {
            using (var db = new BestMobilePh53Entities())
            {

                tbleMobile mobile = db.tbleMobiles.FirstOrDefault(v => v.MobileID == uid);
                txtMobileName.Text = mobile.MobileName;
                txtMobileDescription.Text = mobile.MobileDescription;

            }

            btn_save.Text = "Update";

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int uid = Convert.ToInt32(Request.QueryString["MobileID"]);
        if (Request.QueryString["MobileID"] != null)
        {

            using (var db = new BestMobilePh53Entities())
            {
                tbleMobile mobile = db.tbleMobiles.FirstOrDefault(v => v.MobileID == uid);
                mobile.MobileName = txtMobileName.Text;
                mobile.MobileDescription = txtMobileDescription.Text;
                db.SaveChanges();
                Response.Redirect("Mobiles.aspx");
            }

        }
        else
        {
            using (var db = new BestMobilePh53Entities())
            {
                tbleMobile mobile = new tbleMobile();
                mobile.MobileName = txtMobileName.Text;
                mobile.MobileDescription = txtMobileDescription.Text;
                mobile.MobileImage = uploadImage();
                if (mobile.MobileImage != null)
                {
                    db.tbleMobiles.Add(mobile);
                    db.SaveChanges();
                    Response.Redirect("Mobiles.aspx");
                }
            }
        }
    }



    protected string uploadImage()
    {
        string imgName = FileUpload1.FileName;
        string imgPath = "~/images/" + imgName;
        int imgSize = FileUpload1.PostedFile.ContentLength;
        if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
        {
            if (FileUpload1.PostedFile.ContentLength > 10240)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath(imgPath));
            }

        }
        return imgName;
    }

    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mobiles.aspx");
    }
}