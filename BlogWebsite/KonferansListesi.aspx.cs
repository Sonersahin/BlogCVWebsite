using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class KonferansListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLKONFERANSTableAdapter dt = new DataSet1TableAdapters.TBLKONFERANSTableAdapter();
            Repeater1.DataSource = dt.KonferansListele();
            Repeater1.DataBind();
        }
    }
}