using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChuyenBay_BUS
    {
        ChuyenBay_DAO chuyenBayDAO = new ChuyenBay_DAO();
        public List<ChuyenBay> LayDSChuyenBay()
        {
            return chuyenBayDAO.LayDanhSachChuyenBay_DB();
        }
    }
}
