using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            int z = int.Parse(Request.QueryString["blogId"]);
            if (Page.IsPostBack == false)
            {
                
                var turler = (from x in db.tbl_tur select new { x.turAdi, x.turId }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from y in db.tbl_kategori select new { y.kategoriAd, y.kategoriId }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();

                var deger = db.tbl_blog.Find(z);
                TextBox1.Text = deger.blogBaslik;
                TextBox2.Text = deger.blogTarih.ToString();
                TextBox3.Text = deger.blogGorsel;
                TextBox4.Text = deger.blogIcerik;
                DropDownList1.SelectedValue = deger.blogTur.ToString();
                DropDownList2.SelectedValue = deger.blogKategori.ToString();

            }




            




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int z = int.Parse(Request.QueryString["blogId"]);
            var blog = db.tbl_blog.Find(z);
            blog.blogBaslik = TextBox1.Text;
            blog.blogTarih =DateTime.Parse(TextBox2.Text);
            blog.blogGorsel = TextBox3.Text;
            blog.blogIcerik = TextBox4.Text;
            blog.blogTur = byte.Parse(DropDownList1.SelectedValue);
            blog.blogKategori = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}