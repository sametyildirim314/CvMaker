using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DbCVentityEntities1 db = new DbCVentityEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var ytnk = db.YETENEKLER.Find(id);
                TextBox1.Text = ytnk.YETENEK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var ytnk = db.YETENEKLER.Find(id);
            ytnk.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");


        }
    }
}