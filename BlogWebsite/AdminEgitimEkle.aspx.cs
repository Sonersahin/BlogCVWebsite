using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENIMTableAdapter dt = new DataSet1TableAdapters.TBLOGRENIMTableAdapter();
            dt.EgitimEkle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text);
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}