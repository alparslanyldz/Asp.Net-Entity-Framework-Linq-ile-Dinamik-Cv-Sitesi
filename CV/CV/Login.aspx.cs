using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class Login : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tbl_Admin where x.KullanıcıAdı == TextBox1.Text && x.Sifre == TextBox2.Text select x;
            if(sorgu.Any())
            {
                Response.Redirect("Yeteneklerim.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı  ya da Şifre");
            }
        }
    }
}