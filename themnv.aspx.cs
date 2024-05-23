using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterpage2
{
    public partial class themnv : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlMaphong.DataSource = data.dsPhong();
            ddlMaphong.DataTextField = "name";
            ddlMaphong.DataValueField = "titleid";
            DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Employees s = new Employees();

                s.empid = int.Parse(txtempid.Text);
                s.name = txtname.Text;
                s.address = txtaddress.Text;
                s.gender = txtgender.Text;
                s.email = txtemail.Text;
                s.titleid = int.Parse(ddlMaphong.SelectedValue);

                data.themnv(s);
                msg.Text = "Them thanh cong";
            }
            catch (Exception e1)
            {
                msg.Text = "Co loi khi them " +e1.Message;

            }
        }

       
    }
}