using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var mesaj = db.tbl_iletisim.Find(id);
            TextBox1.Text = mesaj.AdSoyad;
            TextBox2.Text = mesaj.Mail;
            TextBox3.Text = mesaj.Konu;
            TextBox4.Text = mesaj.Mesaj;
        }
    }
}