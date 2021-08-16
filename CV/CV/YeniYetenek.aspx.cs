using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_yetenekler t = new tbl_yetenekler();
            t.Yetenek = TextBox1.Text;
            t.Derece = Convert.ToByte(TextBox2.Text);
            db.tbl_yetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}