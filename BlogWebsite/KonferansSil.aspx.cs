using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class KonferansSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBLKONFERANSTableAdapter dt = new DataSet1TableAdapters.TBLKONFERANSTableAdapter();
            dt.KonferansSil(Convert.ToInt32(x));
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}