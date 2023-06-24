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
using System.Security.Cryptography;
using BUS;
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
        VeMayBay_BUS _VeMayBay_BUS = new VeMayBay_BUS();

        int temp_maChuyenBay = 0;
        public DatVeMayBay(int id, List<ChuyenBay> chuyenBay)
        {
            InitializeComponent();

            if(dsHanhKhach.Count == 0)
            {
                btn_huyHanhKhach.IsEnabled = false;
            }
            btn_ThanhToan.IsEnabled = false;
            

            _id_NguoiDung = id; //gan gia tri cua id NguoiDung vao bien cuc bo
            
            dschuyenBay = chuyenBay;
            HienThiThongTinChuyenBay(dschuyenBay[0]);
            
            
            btn_datVeKhuHoi.IsEnabled = false;
            
            temp_maChuyenBay = dschuyenBay[0]._id;
            //TextBox_maChuyenBay.Text = dschuyenBay[0]._id.ToString();
        
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
        private void HienThiThongTinChuyenBay(ChuyenBay chuyenBay) 
        {
            string thongTinChuyenBay;
            
            
            thongTinChuyenBay = ThongTinChuyenBay(chuyenBay);
            
            
            
            tbChiTietChuyenBay.Text = "Chuyến Bay " + '\n' + thongTinChuyenBay;
            
           
        }
        private void btn_QuayLai_Click(object sender, RoutedEventArgs e)
        {
            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id_NguoiDung);
            xemChuyenBay_UI.Show();
            this.Close();

        }
        private void btn_themHanhKhach_Click(object sender, RoutedEventArgs e)
        {



            if (TextBlock_hoTen.Text != "" && TextBlock_gioiTinh.Text != "" && datapicker_ngaySinh.SelectedDate != null && combobox_maQuocGia.SelectedItem != null
                && combobox_maGhe.SelectedItem != null && combobox_soKg.SelectedItem != null)
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
                tempHanhKhach.maChuyenBay = temp_maChuyenBay;

                //MessageBox.Show(tempHanhLy.soKg.ToString());

                dsHanhKhach.Add(tempHanhKhach);
                dgvHanhKhach.ItemsSource = dsHanhKhach;
                dgvHanhKhach.Items.Refresh();
            }
            else
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN");
            }

            if(dschuyenBay.Count < 2) {
                if (dsHanhKhach.Count > 0 && temp_maChuyenBay == dschuyenBay[0]._id)
                {
                    btn_ThanhToan.IsEnabled = true;
                    btn_huyHanhKhach.IsEnabled = true;
                }
            }
            else
            {
                if(dsHanhKhach.Count > 0)
                {
                    btn_datVeKhuHoi.IsEnabled = true;
                    btn_huyHanhKhach.IsEnabled=true; 
                }
                if (temp_maChuyenBay == dschuyenBay[1]._id)
                {
                    for (int i = 0; i < dsHanhKhach.Count; i++)
                    {
                        if (dsHanhKhach[i].maChuyenBay == temp_maChuyenBay)
                        {
                            btn_ThanhToan.IsEnabled = true; break;
                        }
                    }
                }
            }
            


           

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
            if (dsHanhKhach.Count == 0)
            {
                temp_maChuyenBay = dschuyenBay[0]._id;
                HienThiThongTinChuyenBay(dschuyenBay[0]);
                btn_huyHanhKhach.IsEnabled = false;
                btn_ThanhToan.IsEnabled = false;
                btn_datVeKhuHoi.IsEnabled = false;
            }
        }

        private void btn_ThanhToan_Click(object sender, RoutedEventArgs e)
        {
            
            List<VeMayBay> dsVeMayBay= new List<VeMayBay>();
            dsVeMayBay = _VeMayBay_BUS.LayTatCaThongTinVe();
            List<int>idVe=new List<int>();

            for(int i=0;i<dsVeMayBay.Count;i++)
            {
                idVe.Add(dsVeMayBay[i]._id);
            }
            int maxNumber=idVe.Max();
            _VeMayBay._id = maxNumber+1;
            _VeMayBay.id_nguoiDung = _id_NguoiDung;
            _VeMayBay.maQuocGia = combobox_maQuocGia.Text;
            _VeMayBay.SDT = TextBox_sdt.Text;
            _VeMayBay.email = TextBox_email.Text;
            _VeMayBay.chuyenBay = dschuyenBay;
            _VeMayBay.hanhKhach = dsHanhKhach;

            for (int i = 0; i < dsHanhKhach.Count; i++)
            {
                _VeMayBay.tongGiaTien = _VeMayBay.tongGiaTien + dsHanhKhach[i].choNgoi.giaTien
                                        + dsHanhKhach[i].hanhLy.soKg * dsHanhKhach[i].hanhLy.giaTien;
            };



            //MessageBox.Show(_VeMayBay.chuyenBay[0].hangHangKhong);

            ThanhToan thanhToan_UI = new ThanhToan(_id_NguoiDung, _VeMayBay);
            thanhToan_UI.Show();
            this.Close();
        }

        private void btn_QuayLaiGioHang_Click(object sender, RoutedEventArgs e)
        {
            XemGioHang xemGioHang_UI = new XemGioHang(_id_NguoiDung);
            xemGioHang_UI.Show();
            this.Close();
        }

        private void btn_datVeKhuHoi_Click(object sender, RoutedEventArgs e)
        {
            
            HienThiThongTinChuyenBay(dschuyenBay[1]);
            temp_maChuyenBay = dschuyenBay[1]._id;
            //TextBlock_MaChuyenBay.Text = dschuyenBay[1]._id.ToString();
            btn_ThanhToan.IsEnabled = true;
            
        }
    }
}
