using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"]== null)
            {
                Response.Redirect("/Login.aspx");
            }
            var bloglar = db.tbl_blog.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

        }
    }
}