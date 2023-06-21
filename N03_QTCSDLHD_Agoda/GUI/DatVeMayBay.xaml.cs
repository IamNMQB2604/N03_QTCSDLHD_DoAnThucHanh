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
        List<HanhKhach> dsHanhKhach = new List<HanhKhach>();
        VeMayBay _VeMayBay = new VeMayBay();
        public DatVeMayBay(int id,List<ChuyenBay> chuyenBay)
        {
            InitializeComponent();
            _id_NguoiDung = id; //gan gia tri cua id NguoiDung vao bien cuc bo
            HienThiThongTinChuyenBay(chuyenBay)
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
        private void HienThiThongTinChuyenBay(List<ChuyenBay> chuyenBay) 
        {
            List<string> thongTinChuyenBay = new List<string>();
            for (int i = 0; i < chuyenBay.Count; i++)
            {
                thongTinChuyenBay.Add(ThongTinChuyenBay(chuyenBay[i]));
            }
            if (thongTinChuyenBay.Count < 2)
            {
                tbChiTietChuyenBay.Text = "Chuyến Bay Đi" + '\n' + thongTinChuyenBay[0];
            }
            else
            {
                tbChiTietChuyenBay.Text = "Chuyến Bay Đi" + '\n' + thongTinChuyenBay[0] + "Chuyến Bay Về" + '\n' + thongTinChuyenBay[1];
            }
        }
        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id_NguoiDung);
            xemChuyenBay_UI.Show();
            this.Close();

        }

        

        private void btn_themHanhKhach_Click(object sender, RoutedEventArgs e)
        {
            HanhLy tempHanhLy = new HanhLy();
            tempHanhLy.soKg = int.Parse(TextBox_hanhLyKg.Text);
            tempHanhLy.giaTien= int.Parse(TextBox_hanhLyThanhTien.Text);

            ChoNgoi tempChoNgoi = new ChoNgoi();
            tempChoNgoi.maGhe = TextBox_maGhe.Text;
            tempChoNgoi.giaTien = int.Parse(TextBox_maGheThanhTien.Text);

            HanhKhach tempHanhKhach = new HanhKhach();
            tempHanhKhach.hoTen = TextBox_hoTen.Text;
            tempHanhKhach.hanhLy = tempHanhLy;
            tempHanhKhach.choNgoi = tempChoNgoi;
            tempHanhKhach.gioiTinh = combobox_gioiTinh.Text;
            tempHanhKhach.ngaySinh = datapicker_ngaySinh.Text;
            
            dsHanhKhach.Add(tempHanhKhach);
            dgvHanhKhach.ItemsSource = dsHanhKhach;
            dgvHanhKhach.Items.Refresh();
            
        }

        private void btn_huyHanhKhach_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < dgvHanhKhach.Items.Count; i++)
            {
                CheckBox mycheckbox = dgvHanhKhach.Columns[4].GetCellContent(dgvHanhKhach.Items[i]) as CheckBox;
                if (mycheckbox.IsChecked == true)
                {
                    dsHanhKhach.RemoveAt(i);
                }
            };
            
            dgvHanhKhach.ItemsSource = dsHanhKhach;
            dgvHanhKhach.Items.Refresh();
            MessageBox.Show(dsHanhKhach.Count.ToString());
        }

        private void btn_ThanhToan_Click(object sender, RoutedEventArgs e)
        {
            _VeMayBay.id_nguoiDung = _id_NguoiDung;
            _VeMayBay.maQuocGia = combobox_maQuocGia.Text;
            _VeMayBay.SDT = TextBox_sdt.Text;
            _VeMayBay.email = TextBox_email.Text;
            _VeMayBay.chuyenBay = _chuyenBay;
            _VeMayBay.hanhKhach = dsHanhKhach;

            ThanhToan thanhToan_UI = new ThanhToan(_id_NguoiDung, _VeMayBay);
            thanhToan_UI.Show();
            this.Close();
        }
    }
}
