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
    /// Interaction logic for ThanhToan.xaml
    /// </summary>
    public partial class ThanhToan : Window
    {
        TheTinDung _theTinDung = new TheTinDung();
        VeMayBay _veMayBay = new VeMayBay();
        public ThanhToan(int id_NguoiDung, VeMayBay veMayBay )
        {
            InitializeComponent();
            _veMayBay = veMayBay;
        }

        private void btn_thanhToan_Click(object sender, RoutedEventArgs e)
        {
            _theTinDung.tenThe = textbox_TenThe.Text;
            _theTinDung.soThe = textbox_SoThe.Text;
            _theTinDung.ngayHetHan = datepicker_ngayHetHan.Text;
            _veMayBay.theTinDung = _theTinDung;
            _veMayBay.ngayDatVe = DateTime.Today.ToString();

            MessageBox.Show("THANH TOÁN THÀNH CÔNG");
        }
    }
}
