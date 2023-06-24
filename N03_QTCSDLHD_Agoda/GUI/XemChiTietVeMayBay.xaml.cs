using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for XemChiTietVeMayBay.xaml
    /// </summary>
    public partial class XemChiTietVeMayBay : Window
    {
        int _id;
        public XemChiTietVeMayBay(int id,VeMayBay veMayBay)
        {
            InitializeComponent();
            HienThiThongTinVeMayBay(veMayBay);
            _id = id;
        }
        private void HienThiThongTinVeMayBay(VeMayBay veMayBay)
        {
             List<ChuyenBay> dsChuyenBay= new List<ChuyenBay>();
             
             dsChuyenBay = veMayBay.chuyenBay;
             HienThiThongTinChuyenBay(dsChuyenBay);
             HienThiThongTinChiTietDanhSachChuyenBay(dsChuyenBay);
             HienThiThongTinHanhKhach(veMayBay);
        }
        private void HienThiThongTinHanhKhach(VeMayBay veMayBay)
        {
            
            List<HanhKhach>dsHanhKhach  = veMayBay.hanhKhach;
            // In thông tin các điểm dừng
            List<string> hanhKhachTemp = new List<string>();
            for (int i = 0; i < dsHanhKhach.Count; i++)
            {
                hanhKhachTemp.Add("Mã Chuyến Bay: " + dsHanhKhach[i].maChuyenBay.ToString() +"  " + "Họ Tên: " + dsHanhKhach[i].hoTen.ToString() + "  " + "Giới Tính: " + dsHanhKhach[i].gioiTinh +"  "+ "Ngày Sinh: " +
                " " + dsHanhKhach[i].ngaySinh.ToString() + "  " + "Quốc Tịch: " + dsHanhKhach[i].quocTich.ToString() + "  " + "Hành Lý: "
                + dsHanhKhach[i].hanhLy.soKg.ToString() +" Kg"+ "  " + "Chỗ ngồi: " + dsHanhKhach[i].choNgoi.maGhe.ToString());
            }
            string hanhKhach = string.Join('\n', hanhKhachTemp);
            tbHanhKhach.Text = hanhKhach;
        }    
        private string ThongTinChuyenBay(ChuyenBay chuyenBay)
        {
            string thongTinChuyenBay = "Mã Chuyến Bay: " + chuyenBay._id + '\n'+ "Hãng: " + chuyenBay.hangHangKhong + '\n'
                + "Đi lúc: " + chuyenBay.thoiDiemDi.ngayDi + " " + chuyenBay.thoiDiemDi.gioDi + '\n'
                + "Đến lúc: " + chuyenBay.thoiDiemDen.ngayDen + " " + chuyenBay.thoiDiemDen.gioDen + '\n'
                + "Giá vé: " + chuyenBay.giaVe + '\n'
                + "Xuất phát: " + chuyenBay.diemXuatPhat + '\n'
                + "Dừng: " + chuyenBay.diemDung + '\n'
                + "Đến: " + chuyenBay.diemDen + '\n'
                + "Giờ bay: " + chuyenBay.thoiGianBay + "\n"
                + "Hạng vé: " + chuyenBay.hangVe + "\n";
            return thongTinChuyenBay;
        }
        private void HienThiThongTinChuyenBay(List<ChuyenBay> chuyenBay)
        {
            List<string> thongTinChuyenBay = new List<string>();
            for (int i = 0; i < chuyenBay.Count; i++)
            {
                thongTinChuyenBay.Add(ThongTinChuyenBay(chuyenBay[i]));
            }
            if (thongTinChuyenBay.Count < 2)
            {
                tbChuyenBay.Text = "Chuyến Bay Đi" + '\n' + thongTinChuyenBay[0];
            }
            else
            {
                tbChuyenBay.Text = "Chuyến Bay Đi" + '\n' + thongTinChuyenBay[0] + "Chuyến Bay Về" + '\n' + thongTinChuyenBay[1];
            }
        }
        private string HienThiThongTinChiTietChuyenBay(ChuyenBay chuyenBay)
        {
            string thongTinChiTiet = "Số Hiệu: " + chuyenBay.chiTietChuyenBay.soHieu + '\n' + "Loại Máy Bay: " + chuyenBay.chiTietChuyenBay.loaiMayBay + '\n'
             + "Sân Bay Đi: " + chuyenBay.chiTietChuyenBay.sanBayDi + '\n' + "Sân Bay Đến: " + chuyenBay.chiTietChuyenBay.sanBayDen;
            return thongTinChiTiet;
        }
        private string HienThiThongTinMoTa(ChuyenBay chuyenBay)
        {
            string moTa;
            if (chuyenBay.chiTietChuyenBay.moTa == null)
            {
                moTa = "Không có mô tả";
            }
            else
            { moTa = chuyenBay.chiTietChuyenBay.moTa; }
            return moTa;
        }
        private string HienThiThongTinDiemDung(ChuyenBay chuyenBay)
        {
            string diemDung;
            if (chuyenBay.chiTietChuyenBay.diemDung == null)
            {
                diemDung = "Không có điểm dừng";
            }
            else
            {
                List<DiemDung> diemDungList = chuyenBay.chiTietChuyenBay.diemDung;
                // In thông tin các điểm dừng
                List<string> diemDungTemp = new List<string>();

                for (int i = 0; i < diemDungList.Count; i++)
                {
                    diemDungTemp.Add("Địa Điểm: " + diemDungList[i].DiaDiem.ToString() + '\n' + "Thời Gian: " + diemDungList[i].Date.ToString("dd:MM:yy HH:mm:ss"));
                }
                diemDung = string.Join('\n', diemDungTemp);
            }
            return diemDung;
        }
        private void HienThiThongTinChiTietDanhSachChuyenBay(List<ChuyenBay>dschuyenBay)
        {
            if(dschuyenBay.Count < 2)
            {
                tbThongTinChiTiet.Text = HienThiThongTinChiTietChuyenBay(dschuyenBay[0]); 
                tbMoTa.Text = HienThiThongTinMoTa(dschuyenBay[0]);
                tbDiemDung.Text = HienThiThongTinMoTa(dschuyenBay[0]);
            }
            else
            {
                tbThongTinChiTiet.Text = "Chuyến Bay Đi" + '\n' + HienThiThongTinChiTietChuyenBay(dschuyenBay[0]) +'\n'+ "Chuyến Bay Về" + '\n' + HienThiThongTinChiTietChuyenBay(dschuyenBay[1]);
                tbMoTa.Text = "Chuyến Bay Đi" + '\n' + HienThiThongTinMoTa(dschuyenBay[0]) + '\n' + "Chuyến Bay Về" + '\n' + HienThiThongTinMoTa(dschuyenBay[1]);
                tbDiemDung.Text = "Chuyến Bay Đi" + '\n' + HienThiThongTinDiemDung(dschuyenBay[0]) + '\n' + "Chuyến Bay Về" + '\n' + HienThiThongTinDiemDung(dschuyenBay[1]);
            }    
        }

        private void btnQuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemThongTinVe xemThongTinVe_UI = new XemThongTinVe(_id);
            xemThongTinVe_UI.Show();
            this.Close();
        }
    }
}
