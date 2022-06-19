using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            var deger =(from x in db.tbl_yorum select new {x.yorumId,x.kullaniciAd,x.mail,x.yorumIcerik,x.tbl_blog.blogBaslik}).ToList();
            Repeater1.DataSource = deger;
            Repeater1.DataBind();


        }
    }
}