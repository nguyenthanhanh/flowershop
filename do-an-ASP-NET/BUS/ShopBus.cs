using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
   public class ShopBus
    {
        public static List<ShopDTO> LayDSHoa()
        {
            return ShopDAO.Lay_DS_Hoa();
        }

        public static List<ShopDTO> LayDSHoaNoiBat()
        {
            return ShopDAO.Lay_DS_Hoa_Noi_Bat();
        }
    }
}
