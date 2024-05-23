using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterpage2
{
    public partial class danhsach : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThi();
            }
            
        }
        
        private void HienThi()
        {
            grdDs.DataSource = data.dsnhanvien();
            DataBind();
        }

        protected void Xoa_CLick(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int m = Convert.ToInt32(e.CommandArgument);
                data.Xoasv(m);
                HienThi();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int m = Convert.ToInt32(e.CommandArgument);
                Employees s = data.laynv(m);
                Session["nv"] = s;
                Response.Redirect("suanv.aspx");
            }
        }

        
    }
}