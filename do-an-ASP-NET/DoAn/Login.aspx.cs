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
            string tenTK=txtTenDN.Text;
            if (Page.IsValid)
            {
                HttpCookie cookie = new HttpCookie("TenTK");
             cookie.Value= tenTK;
             cookie.Expires=DateTime.Now.AddDays(14);
             Response.Cookies.Add(cookie);
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