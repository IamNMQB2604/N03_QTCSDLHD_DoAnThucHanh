using System;
using System.Collections.Generic;
using System.Linq;
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
using DTO;
using DAO;
namespace GUI
{
    /// <summary>
    /// Interaction logic for DatVeMayBay.xaml
    /// </summary>
    public partial class DatVeMayBay : Window
    {
        int _id_NguoiDung; // tao bien cuc bo nhan id NguoiDung 
        ChuyenBay _chuyenBay;
        public DatVeMayBay(int id,List<ChuyenBay> chuyenBay)
        {
            InitializeComponent();
            List<string> thongTinChuyenBay = new List<string>();
            _id_NguoiDung = id; //gan gia tri cua id NguoiDung vao bien cuc bo
            for (int i = 0; i < chuyenBay.Count; i++)
            {
                thongTinChuyenBay.Add(ThongTinChuyenBay(chuyenBay[i]));
            }
            tbChiTietChuyenBay.Text = "Chuyến Bay Đi" + '\n' + thongTinChuyenBay[0] + "Chuyến Bay Về" + '\n' + thongTinChuyenBay[1];
;        }

        private string ThongTinChuyenBay(ChuyenBay chuyenBay)
        {
            string thongTinChuyenBay = "Hãng hàng không: " + chuyenBay.hangHangKhong + '\n'
                + "Thời điểm đi: " + chuyenBay.thoiDiemDi.ToString("dd/MM/yy HH:mm:ss") + '\n'
                + "Thời điểm đến: " + chuyenBay.thoiDiemDen.ToString("dd/MM/yy HH:mm:ss") + '\n'
                + "Gía vé mỗi hành khách: " + chuyenBay.giaVe + '\n'
                + "Điểm xuất phát: " + chuyenBay.diemXuatPhat + '\n'
                + "Điểm dừng: " + chuyenBay.diemDung + '\n'
                + "Điểm đến: " + chuyenBay.diemDen + '\n'
                + "Thời gian bay: " + chuyenBay.thoiGianBay + "\n"
                + "Hạng vé: " + chuyenBay.hangVe + "\n";
            return thongTinChuyenBay;
        }
        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id_NguoiDung);
            xemChuyenBay_UI.Show();
            this.Close();

        }

        private void btn_tiepTuc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_themHanhKhach_Click(object sender, RoutedEventArgs e)
        {
            //HanhLy tempHanhLy = new HanhLy(TextBox_hanhLyKg, TextBox_hanhLyThanhTien);
            //HanhKhach tempHanhKhach = new HanhKhach(TextBox_hoTen.Text, TextBox_gioiTinh.Text, datapicker_ngaySinh, combobox_quocTich.Text, );
            //List<HanhKhach> dsHanhKhach;
            //dsHanhKhach.Add()
        }
    }
}
