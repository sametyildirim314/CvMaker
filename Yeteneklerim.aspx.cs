using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCVentityEntities1 db = new DbCVentityEntities1();
            Repeater1.DataSource = db.YETENEKLER.ToList();
            Repeater1.DataBind();
        }
    }
}