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
        ChuyenBay_BUS chuyenBayBussiness = new ChuyenBay_BUS();
        public XemChuyenBay()
        {
            InitializeComponent();
            HienThiDanhSachChuyenBay();
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
                //dgvChuyenBay.Items.Refresh();
            }
        }
        private void btn_ChiTiet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThemXeDayHang_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnChonChuyenBay_Click(object sender, RoutedEventArgs e)
        {
            ChuyenBay ? ChuyenBay_Selected = dgvChuyenBay.SelectedItem as ChuyenBay;
            DatVeMayBay datVeMayBay_UI = new DatVeMayBay(ChuyenBay_Selected);
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
    }
}
