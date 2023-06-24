using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class GioHang_BUS
    {
        GioHang_DAO gioHangDAO = new GioHang_DAO();
        public List<GioHang> LayThongTinGioHang(int id)
        {
            return gioHangDAO.LayTatCaThongTinGioHang_DB(id);
        }
        public bool XoaGioHang(string idKhachHang,string idChuyenBay)
        {
            return gioHangDAO.XoaGioHang_DB(idKhachHang, idChuyenBay);
        }    
    }
}
