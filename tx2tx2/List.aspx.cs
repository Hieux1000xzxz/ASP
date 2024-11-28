using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tx2tx2
{
    public partial class List : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                HienThi();
        }
        private void HienThi()
        {
            gr1.DataSource = data.DSChuyenDi();
            DataBind();
        }

        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                data.XoaCD(m);
                HienThi();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                tblChuyenDi cd = data.Lay1ChuyenDi(m);
                Session["cd1"] = cd;
                Response.Redirect("Edit.aspx");
            }
        }
    }
}