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
        public List<ChuyenBay> TimKiemChuyenBay(string ngayDi,string hangVe,string diemXuatPhat,string diemDen)
        {
            return chuyenBayDAO.TimKiemChuyenBay_DB(ngayDi, hangVe, diemXuatPhat, diemDen);
        }
        public void ThemChuyenBayVaoGioHang(string idKhachHang, string idChuyenBay, string thongTinChuyenBay)
        {
            chuyenBayDAO.ThemChuyenBayVaoGioHang_DB(idKhachHang, idChuyenBay, thongTinChuyenBay);
        }    
    }
}
