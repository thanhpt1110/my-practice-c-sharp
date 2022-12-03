using SQL_ThucHanh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ThucHanh.BUS
{
    internal class LopBUS
    {
        private LopDAO _LopDAO;
        public LopBUS()
        {
            _LopDAO = new LopDAO();
        }

        [Obsolete]
        public List<Lop> getAllLop()
        {
            return _LopDAO.getAllLop();
        }

        public void deleteLop(string ID)
        {
            _LopDAO.DeleteLopByID(ID);
        }

        public void addLop(string ID, string Name)
        {
            _LopDAO.AddLop(ID, Name);
        }

        public void updateLop(string ID, string Name)
        {
            _LopDAO.UpdateLop(ID, Name);
        }
    }
}
