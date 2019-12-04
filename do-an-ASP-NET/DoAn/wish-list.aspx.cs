using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
using System.Data;

namespace DoAn
{
    public partial class wishlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["TenTK"];
            if (cookie != null)
            {
                string tenTK = cookie.Value;
                if (!Page.IsPostBack)
                {
                    DataTable dtbkb = GioHangBUS.LayGH(tenTK);
                    grvGioHang.DataSource = dtbkb;
                    grvGioHang.DataBind();
                    lblTongTien.Text = GioHangBUS.TinhTongTienGH(tenTK).ToString();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
          
        }
    }
}