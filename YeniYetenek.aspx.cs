using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbCVentityEntities1 db = new DbCVentityEntities1 ();
        protected void Button1_Click(object sender, EventArgs e)
        {
            YETENEKLER t = new YETENEKLER ();
            t.YETENEK = TextBox1.Text;
            db.YETENEKLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}