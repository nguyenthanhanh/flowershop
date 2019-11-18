using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace DoAn
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string matkhau2 = string.Empty;
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTK.Text;
            tk.MatKhau = txtMK.Text;
            matkhau2 = txtMK2.Text;
            tk.Email = txtEmail.Text;
            tk.HoTen = txtHoTen.Text;
            tk.SoDienThoai = txtSDT.Text;
            tk.DiaChi = txtDC.Text;

           
            if (Page.IsValid)
            {
                TaiKhoanBUS.ThemTK(tk);
                Response.Write("<script>alert('Đăng ký thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Đăng ký thất bại')</script>");
            }

            
        }

        protected void cusTenTK_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            string tenTK= txtTK.Text;
            if(TaiKhoanBUS.KT_TK(tenTK))
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