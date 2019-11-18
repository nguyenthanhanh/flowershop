﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

namespace DoAn
{
    public partial class shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                load();
            }
        }


        protected void ddtLoaiHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiHoa = ddtLoaiHoa.SelectedValue;
            rptHoa.DataSource = ShopBus.LayDSHoa(maLoaiHoa);
            rptHoa.DataBind();

        }
        private void load()
        {
            rptHoa.DataSource = ShopBus.LayDSHoa();
            rptHoa.DataBind();

            ddtLoaiHoa.DataSource = LoaiHoaBUS.LayDSLoaiHoa();
           
            ddtLoaiHoa.DataTextField = "TenLoaiHoa";
            ddtLoaiHoa.DataValueField = "MaLoaiHoa";
            ddtLoaiHoa.AutoPostBack = true;
            ddtLoaiHoa.DataBind();
        }
    }
}