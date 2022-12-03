using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ThucHanh
{
    internal class SinhVien
    {
        private string _MSSV, _HoTen, _MaLop;

        public SinhVien(string mSSV, string hoTen, string maLop)
        {
            _MSSV = mSSV;
            _HoTen = hoTen;
            _MaLop = maLop;
        }

        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string MaLop { get => _MaLop; set => _MaLop = value; }
    }
}
