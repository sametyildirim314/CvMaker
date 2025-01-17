using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm7 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DbCVentityEntities1 db = new DbCVentityEntities1();
            var x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.ILETISIM.Find(x);
            AdSoyad.Text = mesaj.ADSOYAD;
            Mail.Text = mesaj.MAIL;
            Konu.Text = mesaj.KONU;
            Mesaj.Text=mesaj.MESAJ;

        }
    }
}