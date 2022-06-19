using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["yorumId"]);

            var yorum = db.tbl_yorum.Find(x);
            db.tbl_yorum.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}