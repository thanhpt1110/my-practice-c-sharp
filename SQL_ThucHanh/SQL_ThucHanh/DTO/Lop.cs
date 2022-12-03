using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ThucHanh
{
    internal class Lop
    {
        private string _MaLop, _TenLop;
        private int _SL;

        public Lop() { } 

        public Lop(string maLop, string tenLop, int sL)
        {
            _MaLop = maLop;
            _TenLop = tenLop;
            _SL = sL;
        }

        public string MaLop { get => _MaLop; set => _MaLop = value; }
        public string TenLop { get => _TenLop; set => _TenLop = value; }
        public int SL { get => _SL; set => _SL = value; }
    }
}
