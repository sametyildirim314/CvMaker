using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVapp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DbCVentityEntities1 db = new DbCVentityEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.ADMIN where x.KULLANICIADI == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any())
            {

                Response.Redirect("Yeteneklerim.aspx");

            }
            else
            {
                Response.Write(TextBox1.Text = "Hata!");

            }
        }
    }
    }