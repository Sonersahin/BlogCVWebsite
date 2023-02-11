using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKINDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKINDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYİMTableAdapter dt2 = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLOGRENIMTableAdapter dt3 = new DataSet1TableAdapters.TBLOGRENIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt4 = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLHOBILERTableAdapter dt5 = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            Repeater5.DataSource = dt5.HobiListesi();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBLKONFERANSTableAdapter dt6 = new DataSet1TableAdapters.TBLKONFERANSTableAdapter();
            Repeater6.DataSource = dt6.KonferansListele();
            Repeater6.DataBind();

            DataSet1TableAdapters.TBLHAKKINDATableAdapter dt7 = new DataSet1TableAdapters.TBLHAKKINDATableAdapter();
            Repeater7.DataSource = dt7.HakkimdaListele();
            Repeater7.DataBind();
        }
    }
}