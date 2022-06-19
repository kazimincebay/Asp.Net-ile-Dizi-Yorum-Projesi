using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum
{
    public partial class Iletisim : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            tbl_iletisim t = new tbl_iletisim();
            t.adSoyad = TextBox1.Text;
            t.mail = TextBox2.Text;
            t.telefon = TextBox3.Text;
            t.konu = TextBox3.Text;
            t.mesajIcerik = TextBox5.Text;
            db.tbl_iletisim.Add(t);
            db.SaveChanges();
        }
    }
}