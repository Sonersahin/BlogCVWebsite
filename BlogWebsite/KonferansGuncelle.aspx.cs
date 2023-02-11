using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class KonferansGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["ID"]);
            TxtId.Text = s.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLKONFERANSTableAdapter dt = new DataSet1TableAdapters.TBLKONFERANSTableAdapter();
                TxtKonferans.Text = dt.KonferansGetir(Convert.ToInt32(s))[0].KONFERANS;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLKONFERANSTableAdapter dt = new DataSet1TableAdapters.TBLKONFERANSTableAdapter();
            dt.KonferansGuncelle(TxtKonferans.Text, Convert.ToInt32(TxtId.Text));
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}