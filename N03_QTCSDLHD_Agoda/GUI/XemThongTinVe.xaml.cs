using DTO;
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
namespace GUI
{
    /// <summary>
    /// Interaction logic for XemThongTinVe.xaml
    /// </summary>
    public partial class XemThongTinVe : Window
    {
        int _id;
        VeMayBay_BUS VeMayBay = new VeMayBay_BUS();
        public XemThongTinVe(int id)
        {
            InitializeComponent();
            HienThiThongTinVe(id);
            _id = id;
        }
        private void HienThiThongTinVe(int id)
        {
            List<VeMayBay> dsVeMayBay = new List<VeMayBay>();
            dsVeMayBay = VeMayBay.LayThongTinVeMayBay(id);
            if (dsVeMayBay == null)
            {
                MessageBox.Show("Không có Data");
            }
            else
            {
                dgvThongTinVe.ItemsSource = dsVeMayBay;
                dgvThongTinVe.Items.Refresh();

            }
        }
        private void btn_ChiTietVeMayBay_Click(object sender, RoutedEventArgs e)
        {
            VeMayBay? VMB_Selected = dgvThongTinVe.SelectedItem as VeMayBay;
            XemChiTietVeMayBay xemChiTietVe_UI = new XemChiTietVeMayBay(_id,VMB_Selected);
            xemChiTietVe_UI.Show();
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id);
            xemChuyenBay_UI.Show();
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, RoutedEventArgs e)
        {
            List<VeMayBay> dsVeMayBay = new List<VeMayBay>();
            if (dataPickerNgayDat.SelectedDate==null)
            {
                MessageBox.Show("Nhập ngày đặt vé để tìm kiếm", "Thông Báo", MessageBoxButton.OK);
            }    
            else
            {
                dsVeMayBay = VeMayBay.TimKiemThongTinVeMayBay(dataPickerNgayDat.SelectedDate.ToString());
                dgvThongTinVe.ItemsSource = dsVeMayBay;
                dgvThongTinVe.Items.Refresh();
            }    
        }
    }
}
