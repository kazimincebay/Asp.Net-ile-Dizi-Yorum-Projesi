using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["blogId"]);

            var blog = db.tbl_blog.Find(x);
            db.tbl_blog.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}