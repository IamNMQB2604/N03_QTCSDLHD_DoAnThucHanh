using BUS;
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
using BUS;
using DTO;
using System.Security.Cryptography;

namespace GUI
{
    /// <summary>
    /// Interaction logic for XemGioHang.xaml
    /// </summary>
    public partial class XemGioHang : Window
    {
        GioHang_BUS gioHangBussiness = new GioHang_BUS();
        ChuyenBay_BUS chuyenbayBussiness = new ChuyenBay_BUS();
        int _id;
        List<GioHang> gioHang = new List<GioHang>();
        public XemGioHang(int id)
        {
            InitializeComponent();
            HienThiThongTinGioHang(id);
            _id = id;
            dgvGioHang.Items.Refresh();
        }
        private void HienThiThongTinGioHang(int id)
        {
            List<GioHang> gioHang = new List<GioHang>();
            gioHang = gioHangBussiness.LayThongTinGioHang(id);
            if (gioHang == null)
            {
                MessageBox.Show("Không có chuyến bay nào trong giỏ hàng");
            }
            else
            { 
                dgvGioHang.ItemsSource = gioHang;
            }
        }

        private void btn_DatVe_Click(object sender, RoutedEventArgs e)
        {
            GioHang selectedChuyenBay = new GioHang();
            selectedChuyenBay = dgvGioHang.SelectedItem as GioHang;
            int idChuyenBay = Int32.Parse(selectedChuyenBay.id);
            ChuyenBay chuyenBay = new ChuyenBay();
            chuyenBay = chuyenbayBussiness.LayThongTinChuyenBay(idChuyenBay);
            List<ChuyenBay> dsChuyenBay = new List<ChuyenBay>();
            dsChuyenBay.Add(chuyenBay);
            DatVeMayBay datVeMayBay_UI = new DatVeMayBay(_id, dsChuyenBay);
            datVeMayBay_UI.Show();
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id);
            xemChuyenBay_UI.Show();
            this.Close();
        }

        private void btn_XoaChuyenBay_Click(object sender, RoutedEventArgs e)
        {
            GioHang chuyenBay = dgvGioHang.SelectedItem as GioHang;
            if (gioHangBussiness.XoaGioHang(_id.ToString(), chuyenBay.id))
            {
                MessageBox.Show("Xóa thành công chuyến bay");
               
            }
            else
            {
                MessageBox.Show("Xóa chuyến bay không thành công");
            }
            //dgvGioHang.Items.Refresh();
        }
    }
}
