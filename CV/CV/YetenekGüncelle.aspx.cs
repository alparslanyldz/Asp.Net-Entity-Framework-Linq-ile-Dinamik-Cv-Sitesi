using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CV
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            if(Page.IsPostBack==false)
            { 
            var ytnk = db.tbl_yetenekler.Find(id);
            TextBox1.Text = ytnk.Yetenek;
                TextBox2.Text = ytnk.Derece.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var ytnk = db.tbl_yetenekler.Find(id);
            ytnk.Yetenek = TextBox1.Text;
            ytnk.Derece = Convert.ToByte(TextBox2.Text);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx"); 
        }
    }
}