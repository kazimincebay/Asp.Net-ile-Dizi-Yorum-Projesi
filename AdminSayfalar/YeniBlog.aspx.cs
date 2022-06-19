using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.tbl_tur select new { x.turAdi, x.turId }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from y in db.tbl_kategori select new { y.kategoriAd, y.kategoriId }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_blog t = new tbl_blog();
            t.blogBaslik = TextBox1.Text;
            t.blogTarih = DateTime.Parse(TextBox2.Text);
            t.blogGorsel = TextBox3.Text;
            t.blogTur = byte.Parse(DropDownList1.SelectedValue);
            t.blogKategori = byte.Parse(DropDownList2.SelectedValue);
            t.blogIcerik = TextBox4.Text;
            db.tbl_blog.Add(t);
            db.SaveChanges();
            Response.Redirect("/AdminSayfalar/Bloglar.aspx");
        }
    }
}