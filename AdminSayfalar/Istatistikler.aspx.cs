using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class Istatistik : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }

            Label1.Text = db.tbl_blog.Count().ToString();
            Label2.Text = db.tbl_yorum.Count().ToString();
            Label3.Text = db.tbl_blog.Where(x=>x.blogTur==2).Count().ToString();
            Label4.Text = db.tbl_blog.Where(x=>x.blogTur==1).Count().ToString();
            Label5.Text = db.tbl_blog.Where(x=>x.blogTur==4).Count().ToString();
            Label6.Text = db.tbl_blog.Where(y=>y.blogId==(db.tbl_yorum.GroupBy(x => x.yorumBlog).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k=>k.blogBaslik).FirstOrDefault();




        }
    }
}