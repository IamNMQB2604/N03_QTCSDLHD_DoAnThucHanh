using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Login_BUS
    {
        Login_DAO login_DAO = new Login_DAO();
        public NguoiDung LayThongTinNguoiDung(string sdt,string matKhau)
        {
            return login_DAO.LayThongTinNguoiDungDB(sdt, matKhau);
        }
    }
}
