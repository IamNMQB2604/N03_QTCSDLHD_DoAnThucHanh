using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class VeMayBay_BUS
    {
        DatVeMayBay_DAO datVeMayBay = new DatVeMayBay_DAO();
        public void themCacVeMayBay(VeMayBay veMayBay)
        {
            datVeMayBay.ThemCacVeMayBay_DB(veMayBay);
        }
        public List<VeMayBay> LayTatCaThongTinVe()
        {
            return datVeMayBay.LayTatCaThongTinVe_DB();
        }
        public List<VeMayBay>LayThongTinVeMayBay(int id)
        {
            return datVeMayBay.LayThongTinVeMayBay_DB(id);
        }
        public List<VeMayBay>TimKiemThongTinVeMayBay(string ngayDat)
        {
            return datVeMayBay.TimKiemThongTinVeMayBay_DB(ngayDat);
        }
    }
}
