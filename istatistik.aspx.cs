using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        DbCVentityEntities1 db = new DbCVentityEntities1 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.YETENEKLER.Count().ToString();
            Label2.Text = db.ILETISIM.Count().ToString();
            Label3.Text = db.YETENEKLER.Average(x => x.DERECE ).ToString();
            Label4.Text = db.YETENEKLER.Max(x => x.DERECE ).ToString();
            

        }
    }
}