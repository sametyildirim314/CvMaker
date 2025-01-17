using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCVentityEntities1 db = new DbCVentityEntities1(); 
            var mesajlar = db.ILETISIM.ToList();
            Repeater1.DataSource = mesajlar;    
            Repeater1.DataBind();   
        }
    }
}