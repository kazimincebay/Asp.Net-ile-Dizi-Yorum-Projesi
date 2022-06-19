using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum
{
    public partial class Login : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var sorgu = from x in db.tbl_admin where x.kullanici == TextBox1.Text && x.sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Session.Add("Kullanıcı", TextBox1.Text);
                Response.Redirect("/AdminSayfalar/Bloglar.aspx");
            }
            else
            {
                Response.Write("Hataa");
            }

        }
    }
}