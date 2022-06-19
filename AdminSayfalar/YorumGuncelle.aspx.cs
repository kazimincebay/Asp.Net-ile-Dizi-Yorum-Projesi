using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int z = int.Parse(Request.QueryString["yorumId"]);
            if (Page.IsPostBack == false)
            {

                var deger = db.tbl_yorum.Find(z);
                TextBox1.Text = deger.tbl_blog.blogBaslik;
                TextBox2.Text = deger.kullaniciAd;
                TextBox4.Text = deger.yorumIcerik;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int z = int.Parse(Request.QueryString["yorumId"]);
            var yorum = db.tbl_yorum.Find(z);
            yorum.kullaniciAd = TextBox2.Text;
            yorum.yorumIcerik = TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");

        }
    }
}