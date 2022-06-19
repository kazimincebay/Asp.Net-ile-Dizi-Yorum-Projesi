using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum
{
    public partial class blogDetay : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["blogId"]);
            var detay = db.tbl_blog.Where(x => x.blogId == id).ToList();
            Repeater1.DataSource = detay;
            Repeater1.DataBind();


            var yorumlar = db.tbl_yorum.Where(x => x.yorumBlog == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["blogId"]);

            tbl_yorum t = new tbl_yorum();
            t.kullaniciAd = TextBox1.Text;
            t.mail = TextBox2.Text;
            t.yorumIcerik = TextBox3.Text;
            t.yorumBlog = id;
            db.tbl_yorum.Add(t);
            db.SaveChanges();
            Response.Redirect("blogDetay.aspx?blogId=" + id);
        }
    }
}