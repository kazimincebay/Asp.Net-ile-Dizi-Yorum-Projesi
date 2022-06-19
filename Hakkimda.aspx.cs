using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diziYorum.Entity;

namespace diziYorum
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        diziBlogEntities db = new diziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var hakkimizdayazi = db.tbl_hakkimizda.ToList();
            Repeater1.DataSource = hakkimizdayazi;
            Repeater1.DataBind();

        }
    }
}