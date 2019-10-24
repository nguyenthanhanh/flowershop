using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> LayDSSanPhamTrangChu()
        {
            String query = "SELECT TOP(8) id, TenSP, GiaTien, AnhSanPham FROM sanpham";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbSanPham = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            foreach (DataRow dr in dtbSanPham.Rows)
            {
                lstSanPham.Add(ConvertSanPhamDTO(dr));
            }
            return lstSanPham;
        }

        public static SanPhamDTO ConvertSanPhamDTO(DataRow dr)
        {
            SanPhamDTO sanpham = new SanPhamDTO();
            sanpham.ID = Convert.ToInt32(dr["ID"]);
            sanpham.TenSP = dr["TenSP"].ToString();
            sanpham.GiaTien = Convert.ToInt32(dr["GiaTien"]);
            sanpham.AnhSanPham = dr["AnhSanPham"].ToString();
            sanpham.LoaiSP = 1;
            return sanpham;
        }
    }
}
