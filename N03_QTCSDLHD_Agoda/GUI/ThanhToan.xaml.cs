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
using BUS;

namespace GUI
{
    /// <summary>
    /// Interaction logic for ThanhToan.xaml
    /// </summary>
    public partial class ThanhToan : Window
    {
        TheTinDung _theTinDung = new TheTinDung();
        VeMayBay _veMayBay = new VeMayBay();
        int _idNguoiDung;
        List<ChuyenBay> danhSachChuyenBayTemp = new List<ChuyenBay>();
        VeMayBay_BUS _VeMayBay_BUS = new VeMayBay_BUS();



        public ThanhToan(int id_NguoiDung, VeMayBay veMayBay)
        {
            InitializeComponent();
            _veMayBay = veMayBay;
            _idNguoiDung = id_NguoiDung;
            //danhSachChuyenBayTemp = chuyenBay;
        }

        private void btn_thanhToan_Click(object sender, RoutedEventArgs e)
        {
            _theTinDung.tenThe = textbox_TenThe.Text;
            _theTinDung.soThe = textbox_SoThe.Text;
            _theTinDung.ngayHetHan = datepicker_ngayHetHan.Text;
            _veMayBay.theTinDung = _theTinDung;
            _veMayBay.ngayDatVe = DateTime.Today.ToString();


            _VeMayBay_BUS.themCacVeMayBay(_veMayBay);
            MessageBox.Show(_veMayBay.chuyenBay[0].hangHangKhong);

            
            
        }

        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            DatVeMayBay datVeMayBay_UI = new DatVeMayBay(_idNguoiDung, danhSachChuyenBayTemp);
            datVeMayBay_UI.Show();
            this.Close();
        }
    }
}
