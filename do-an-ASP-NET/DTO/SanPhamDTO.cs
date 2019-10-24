using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _tenSP;

        public String TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }
        private int _giaTien;

        public int GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }
        private String _anhSanPham;

        public String AnhSanPham
        {
            get { return _anhSanPham; }
            set { _anhSanPham = value; }
        }
        private int _loaiSP;

        public int LoaiSP
        {
            get { return _loaiSP; }
            set { _loaiSP = value; }
        }

        public SanPhamDTO()
        {
            this.LoaiSP = 1;
        }
    }
}
