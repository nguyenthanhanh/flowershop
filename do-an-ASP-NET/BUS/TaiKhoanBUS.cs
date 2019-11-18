using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static bool ThemTK(TaiKhoanDTO tk)
        {
            if(TaiKhoanDAO.KT_TK(tk.TenTaiKhoan))
            {
                return false;
            }

            else
            {
                return TaiKhoanDAO.Them_TK(tk);
            }
        }

        public static bool KT_TK(string tenTK)
        {
            if(TaiKhoanDAO.KT_TK(tenTK))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KT_MK(string MK)
        {
            if (TaiKhoanDAO.KT_MK(MK))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
