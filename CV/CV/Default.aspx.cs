using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class Default : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.tbl_hakkimda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.tbl_hakkimda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.tbl_hakkimda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.tbl_yetenekler.ToList();
            Repeater4.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_iletisim t = new tbl_iletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.tbl_iletisim.Add(t);
            db.SaveChanges();
        }
    }
}