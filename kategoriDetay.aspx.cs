using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum
{
    public partial class kategoriDetay : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            int z = int.Parse(Request.QueryString["kategoriId"]);
            var bloglar = db.tbl_blog.Where(x=>x.blogKategori==z).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.tbl_kategori.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var bloglar3 = db.tbl_blog.Take(5).OrderByDescending(x=>x.blogBaslik).ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();

        }
    }
}