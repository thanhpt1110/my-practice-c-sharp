using SQL_ThucHanh.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ThucHanh.BUS
{
    internal class SinhVienBUS
    {
        private SinhVienDAO _SinhVienDAO;
        public SinhVienBUS() 
        {
            _SinhVienDAO = new SinhVienDAO();
        }

        [Obsolete]
        public List<SinhVien> _getAllSVByMaLop(string MaLop)
        {
            return _SinhVienDAO.getAllSVByMaLop(MaLop);
        }

        public void deleteSVByID(string ID)
        {
            _SinhVienDAO.DeleteSVByID(ID);
        }

        public void updateSV(string ID, string Name, string MaLop)
        {
            _SinhVienDAO.UpdateSV(ID, Name, MaLop);
        }

        public void addSV(string ID, string Name, string MaLop)
        {
            _SinhVienDAO.AddSV(ID, Name, MaLop);
        }
    }
}
