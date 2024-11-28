using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tx2tx2
{
    public partial class Add : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drPhuongTien.DataSource = data.DSPhuongTien();
                drPhuongTien.DataTextField = "tenpt";
                drPhuongTien.DataValueField = "mapt";
                DataBind();
            }
        }

        protected void butthem_Click(object sender, EventArgs e)
        {
            try
            {
                tblChuyenDi cd = new tblChuyenDi();
                cd.tencd = txtTenChuyenDi.Text;
                cd.songaydi = int.Parse(txtSoNgayDi.Text);
                cd.songuoidi = int.Parse(txtSoNguoiDi.Text);
                //cd.mapt = int.Parse(txtMaPT.Text);
                cd.mapt = int.Parse(drPhuongTien.SelectedValue);
                data.ThemCD(cd);
                error.Text = "Thêm thành công";

            }
            catch (Exception e1)
            {

                error.Text = "Có lỗi khi thêm sinh viên!" + e1.Message;
            }
        }
    }
}