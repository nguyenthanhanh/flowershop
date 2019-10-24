using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> LayDSSanPham()
        {
            return SanPhamDAO.LayDSSanPhamTrangChu();
        }
    }
}
