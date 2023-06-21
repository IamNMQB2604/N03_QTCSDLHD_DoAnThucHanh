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
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for XemChuyenBay.xaml
    /// </summary>
    public partial class XemChuyenBay : Window
    {
        List<string> danhSachTinhThanh = new List<string>
        {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Hồ Chí Minh"
        };
        int _id;
        ChuyenBay_BUS chuyenBayBussiness = new ChuyenBay_BUS();
        public XemChuyenBay(int id)
        {
            InitializeComponent();
            HienThiDanhSachChuyenBay();
            _id=id;
            cb_diemXuatPhat.ItemsSource = danhSachTinhThanh;
            cb_diemDen.ItemsSource = danhSachTinhThanh;

        }
        private void HienThiDanhSachChuyenBay()
        {
            List<ChuyenBay> dsChuyenBay = chuyenBayBussiness.LayDSChuyenBay();
            if (dsChuyenBay == null)
            {
                MessageBox.Show("Không có Data");
            }
            else
            {
                MessageBox.Show("Có data");
                dgvChuyenBay.ItemsSource = dsChuyenBay;
                dgvChuyenBay.Items.Refresh();
            }
        }
        private void btn_ChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChuyenBay? ChuyenBay_Selected = dgvChuyenBay.SelectedItem as ChuyenBay;
            XemChiTietChuyenBay xemChiTietChuyenBay_UI = new XemChiTietChuyenBay(_id,ChuyenBay_Selected);
            xemChiTietChuyenBay_UI.Show();
            this.Close();

        }

        private void btnThemXeDayHang_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnChonChuyenBay_Click(object sender, RoutedEventArgs e)
        {
            ChuyenBay ? ChuyenBay_Selected = dgvChuyenBay.SelectedItem as ChuyenBay;
            DatVeMayBay datVeMayBay_UI = new DatVeMayBay(_id,ChuyenBay_Selected);
            datVeMayBay_UI.Show();
            this.Close();
        }

        private void rb_MotChieuChecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbKhuHoi_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void frBody_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void tbSoKhach_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_TraCuuVe_Click(object sender, RoutedEventArgs e)
        {
            XemThongTinVe xemThongTinVe_UI = new XemThongTinVe();
            xemThongTinVe_UI.Show();
            this.Close();
        }
        private void btn_XemGioHang_Click(object sender, RoutedEventArgs e)
        {
            XemGioHang xemGioHang_UI = new XemGioHang();
            xemGioHang_UI.Show();
            this.Close();
        }

        private void comboBox_diemXuatPhat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgvChuyenBay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
