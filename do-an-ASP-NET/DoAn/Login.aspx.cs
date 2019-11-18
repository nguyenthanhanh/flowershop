using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

namespace DoAn
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTenDN.Text;
            tk.MatKhau = txtDN_MK.Text;
            if (Page.IsValid)
            {
                Response.Redirect("index.aspx");
            }

            else
            {
                Response.Write("<script>alert('Đăng nhập thất bại')</script>");
            }

        }

        protected void cusTenDN_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string tenDN = txtTenDN.Text;
            if(!TaiKhoanBUS.KT_TK(tenDN))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

        }

        protected void cusDN_MK_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string MK = txtDN_MK.Text;
            if (!TaiKhoanBUS.KT_MK(MK))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}