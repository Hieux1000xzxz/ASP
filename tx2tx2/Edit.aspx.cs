using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tx2tx2
{
    public partial class Edit : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tblChuyenDi cd = (tblChuyenDi)Session["cd1"];
                txtMaChuyenDi.Text = cd.macd.ToString();
                txtTenChuyenDi.Text = cd.tencd;
                txtSoNgayDi.Text = cd.songaydi.ToString();
                txtSoNguoiDi.Text = cd.songuoidi.ToString();
                txtPhuongTien.Text = cd.mapt.ToString();
                DataBind();
            }
        }

        protected void butsua_Click(object sender, EventArgs e)
        {
            try
            {
                tblChuyenDi cd = new tblChuyenDi();
                cd.macd = int.Parse(txtMaChuyenDi.Text);
                cd.tencd = txtTenChuyenDi.Text;
                cd.songaydi = int.Parse(txtSoNgayDi.Text);
                cd.songuoidi = int.Parse(txtSoNguoiDi.Text);
                cd.mapt = int.Parse(txtPhuongTien.Text);
                data.CapnhatCD(cd);
                error.Text = "Cập nhật thành công";

            }
            catch (Exception e1)
            {

                error.Text = "Có lỗi khi sửa sinh viên!" + e1.Message;
            }
        }
    }
}