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
        List<ChuyenBay> dschuyenBay = new List<ChuyenBay>();
        List<HanhKhach> dsHanhKhach = new List<HanhKhach>();
        VeMayBay _VeMayBay = new VeMayBay();
        public DatVeMayBay(int id, List<ChuyenBay> chuyenBay)
        {
            InitializeComponent();
            _id_NguoiDung = id; //gan gia tri cua id NguoiDung vao bien cuc bo
            HienThiThongTinChuyenBay(chuyenBay);
            dschuyenBay = chuyenBay;
        
;        }

        private string ThongTinChuyenBay(ChuyenBay chuyenBay)
        {
            string thongTinChuyenBay = "Hãng: " + chuyenBay.hangHangKhong + '\n'
                + "Đi lúc: " + chuyenBay.thoiDiemDi.ngayDi +" "+chuyenBay.thoiDiemDi.gioDi + '\n'
                + "Đến lúc: "  +chuyenBay.thoiDiemDen.ngayDen + " " + chuyenBay.thoiDiemDen.gioDen + '\n'
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
            tempHanhLy.soKg = int.Parse(combobox_soKg.Text);
            tempHanhLy.giaTien = int.Parse(TextBox_hanhLyThanhTien.Text) * tempHanhLy.soKg;

            ChoNgoi tempChoNgoi = new ChoNgoi();
            tempChoNgoi.maGhe = combobox_maGhe.Text;
            tempChoNgoi.giaTien = int.Parse(TextBox_maGheThanhTien.Text);

            HanhKhach tempHanhKhach = new HanhKhach();
            tempHanhKhach.hoTen = TextBox_hoTen.Text;
            tempHanhKhach.quocTich = combobox_maQuocGia.Text;
            tempHanhKhach.hanhLy = tempHanhLy;
            tempHanhKhach.choNgoi = tempChoNgoi;
            tempHanhKhach.gioiTinh = combobox_gioiTinh.Text;
            tempHanhKhach.ngaySinh = datapicker_ngaySinh.Text;

            //MessageBox.Show(tempHanhLy.soKg.ToString());

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
            _VeMayBay.chuyenBay = dschuyenBay;
            _VeMayBay.hanhKhach = dsHanhKhach;

            //MessageBox.Show(_VeMayBay.chuyenBay[0].hangHangKhong);

            ThanhToan thanhToan_UI = new ThanhToan(_id_NguoiDung, _VeMayBay);
            thanhToan_UI.Show();
            this.Close();
        }
    }
}
