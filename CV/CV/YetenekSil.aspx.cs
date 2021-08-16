using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CV
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        CvEntities db = new CvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Id"]);
            var ytnk = db.tbl_yetenekler.Find(x);
            db.tbl_yetenekler.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}