using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityConditiningDF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDbCopntext db = new EmployeeDbCopntext();
            GridView1.DataSource = db.Employees4.ToList();
            GridView1.DataBind();
        }
    }
}