using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SpecificationSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;


        int uid = Convert.ToInt32(Request.QueryString["MobileID"]);


        using (var db = new BestMobilePh53Entities())
        {
            tblSpecification aspecification = db.tblSpecifications.FirstOrDefault(v => v.MobileID == uid);
            if (aspecification !=  null)
            {
                tblSpecification specification = db.tblSpecifications.FirstOrDefault(v => v.MobileID == uid);
                txtFrontCamera.Text = specification.FrontCamera;
                txtBackCamera.Text = specification.BackCamera;
                txtBattery.Text = specification.BatteryCapacity;
                txtOS.Text = specification.OS;
                txtRAM.Text = specification.RAM;
                txtStorage.Text = specification.Storage;
                txtProcessor.Text = specification.Processor;
                btn_save.Text = "Update";
            }

        }



    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["MobileID"]);
        using (var db = new BestMobilePh53Entities())
        {
            tblSpecification aspecification = db.tblSpecifications.FirstOrDefault(v => v.MobileID == mid);
            if (aspecification !=  null)
            {
                tblSpecification specification = db.tblSpecifications.FirstOrDefault(v => v.MobileID == mid);
                specification.FrontCamera = txtFrontCamera.Text;
                specification.BackCamera = txtBackCamera.Text;
                specification.BatteryCapacity = txtBattery.Text;
                specification.OS = txtOS.Text;
                specification.RAM = txtRAM.Text;
                specification.Storage = txtStorage.Text;
                specification.Processor = txtProcessor.Text;
                db.SaveChanges();
                Response.Redirect("Mobiles.aspx");
            }
            else
            {
                tblSpecification specification = new tblSpecification();
                specification.FrontCamera = txtFrontCamera.Text;
                specification.BackCamera = txtBackCamera.Text;
                specification.BatteryCapacity = txtBattery.Text;
                specification.OS = txtOS.Text;
                specification.RAM = txtRAM.Text;
                specification.Storage = txtStorage.Text;
                specification.Processor = txtProcessor.Text;
                specification.MobileID = mid;
                db.tblSpecifications.Add(specification);
                db.SaveChanges();
                Response.Redirect("Mobiles.aspx");
            }
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mobiles.aspx");
    }


}