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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadSanPham();
        }

        private void LoadSanPham()
        {
            rptSanPham.DataSource = SanPhamBUS.LayDSSanPham();
            rptSanPham.DataBind();
        }
    }
}