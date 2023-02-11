using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            TxtId.Enabled = false;
            TxtId.Text = x.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLOGRENIMTableAdapter dt = new DataSet1TableAdapters.TBLOGRENIMTableAdapter();
                TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt32(x))[0].BASLIK;
                TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt32(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt32(x))[0].ACIKLAMA;
                TxtGnot.Text = dt.EgitimGetir(Convert.ToInt32(x))[0].GNOT;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt32(x))[0].TARIH;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENIMTableAdapter dt = new DataSet1TableAdapters.TBLOGRENIMTableAdapter();
            dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text, Convert.ToInt32(TxtId.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}