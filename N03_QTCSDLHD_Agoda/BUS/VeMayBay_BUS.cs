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
    }
}
