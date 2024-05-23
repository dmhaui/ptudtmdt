using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterpage2
{
    public partial class suanv : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Employees s = (Employees)Session["nv"];
                txtempid.Text = s.empid.ToString();
                txtname.Text = s.name;
                txtgender.Text = s.gender;
                txtaddress.Text = s.address;
                txtemail.Text = s.email;

                ddlMaphong.DataSource = data.dsPhong();
                ddlMaphong.DataTextField = "name";
                ddlMaphong.DataValueField = "titleid";
                DataBind();
                ddlMaphong.SelectedValue = s.titleid.ToString();


            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
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

                data.suanv(s);
                msg.Text = "Sua thanh cong";
            }
            catch (Exception e1)
            {
                msg.Text = "Co loi khi sua " + e1.Message;

            }
        }

    }
}