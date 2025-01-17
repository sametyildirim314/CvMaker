using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCVentityEntities1 db = new DbCVentityEntities1();
            int x = Convert.ToInt32(Request.QueryString["ID"]);

            var ytnk = db.YETENEKLER.Find(x);
            db.YETENEKLER.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}