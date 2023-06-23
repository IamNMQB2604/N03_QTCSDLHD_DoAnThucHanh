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
using static System.Net.Mime.MediaTypeNames;

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
            "TP.Hồ Chí Minh"
        };
        int _id;
        ChuyenBay_BUS chuyenBayBussiness = new ChuyenBay_BUS();
        List<ChuyenBay> danhSachChuyenBay = new List<ChuyenBay>();
        public XemChuyenBay(int id)
        {
            InitializeComponent();
            HienThiDanhSachChuyenBay();
            _id = id;
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
        private void btnThemXeDayHang_Click(object sender, RoutedEventArgs e)
        {
            //Màng ChuyenBay temp để lưu danh sách chuyến bay người dùng chọn
            // Truy xuất thêm vào giỏ hàng từ mảng danhsachChuyenBayTemp
            List<ChuyenBay> danhSachChuyenBayTemp = new List<ChuyenBay>();
            MessageBox.Show("Giỏ hàng chỉ lưu chuyến bay Một Chiều");
            int j = 0;
            for (int i = 0; i < dgvChuyenBay.Items.Count; i++)
            {
                CheckBox mycheckbox = dgvChuyenBay.Columns[0].GetCellContent(dgvChuyenBay.Items[i]) as CheckBox;
                if (mycheckbox.IsChecked == true)
                {
                    ChuyenBay chuyenBay = dgvChuyenBay.Items[i] as ChuyenBay;
                    danhSachChuyenBayTemp.Add(chuyenBay);
                }
            }
            string idKH = _id.ToString();
            string hangVe = "";
            for (int i = 0; i < danhSachChuyenBayTemp.Count; i++)
            {
                if (danhSachChuyenBayTemp[i].hangVe.ToString() == "Hạng Nhất")
                {
                    hangVe = "First";
                }
                if (danhSachChuyenBayTemp[i].hangVe.ToString() == "Phổ Thông Cao Cấp")
                {
                    hangVe = "Premium Economy";
                }
                if (danhSachChuyenBayTemp[i].hangVe.ToString() == "Phổ Thông")
                {
                    hangVe = "Economy";
                }
                else
                {
                    hangVe = "Business";
                }
                string ttCB = danhSachChuyenBayTemp[i].thoiDiemDi.ngayDi.ToString() + " "
                                + danhSachChuyenBayTemp[i].thoiDiemDi.gioDi.ToString() + " "
                               + danhSachChuyenBayTemp[i].thoiDiemDen.ngayDen.ToString() + " "
                                + danhSachChuyenBayTemp[i].thoiDiemDen.gioDen.ToString() + " "
                                + danhSachChuyenBayTemp[i].thoiGianBay.ToString() + " "
                                + danhSachChuyenBayTemp[i].hangHangKhong.ToString() + " "
                                + hangVe + " "
                                + danhSachChuyenBayTemp[i].giaVe.ToString();

                string idCB = danhSachChuyenBayTemp[i]._id.ToString();

                if (chuyenBayBussiness.ThemChuyenBayVaoGioHang(idKH, idCB, ttCB))
                {
                    MessageBox.Show("Thêm Vào Giỏ Hàng Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Vào Giỏ Hàng Thất Bại");
                }
            }
        }

        private void btnChonChuyenBay_Click(object sender, RoutedEventArgs e)
        {
            //Mảng danhSachChuyenBayTemp để lưu danh sách chuyến bay người dùng chọn
            // Truy xuất thêm dữ liệu vé từ mảng này
            List<ChuyenBay> danhSachChuyenBayTemp = new List<ChuyenBay>();
            int j = 0;
            for (int i = 0; i < dgvChuyenBay.Items.Count; i++)
            {
                CheckBox mycheckbox = dgvChuyenBay.Columns[0].GetCellContent(dgvChuyenBay.Items[i]) as CheckBox;
                if (mycheckbox.IsChecked == true)
                {
                    ChuyenBay chuyenBay = dgvChuyenBay.Items[i] as ChuyenBay;
                    danhSachChuyenBayTemp.Add(chuyenBay);
                }
            }
            if (rbMotChieu.IsChecked == true)
            {
                if (dataPicker_ngayDi.SelectedDate == null || cb_HangGhe.SelectedItem == null || cb_diemXuatPhat.SelectedItem == null || cb_diemDen.SelectedItem == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin Ngày Đi, Hạng Vé, Điểm Xuất Phát, Điểm Đến . Nhấn nút Tìm Kiếm để lọc thông tin", "Thông Báo", MessageBoxButton.OK);
                }
                else
                {
                    if (danhSachChuyenBayTemp.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn chuyến bay", "Thông Báo", MessageBoxButton.OK);
                    }
                    else if (danhSachChuyenBayTemp.Count > 1)
                    {
                        MessageBox.Show("Bạn đang chọn chuyến bay một chiều không thể chọn hơn 1 chuyến bay", "Thông Báo", MessageBoxButton.OK);

                    }
                    else
                    {
                        XemChiTietChuyenBay xemChiTiet_UI = new XemChiTietChuyenBay(_id, danhSachChuyenBayTemp);
                        xemChiTiet_UI.Show();
                        this.Close();
                    }
                }
            }
            else if (rbKhuHoi.IsChecked == true)
            {
                if (dataPicker_ngayDi.SelectedDate == null || cb_HangGhe.SelectedItem == null || cb_diemXuatPhat.SelectedItem == null || cb_diemDen.SelectedItem == null || dataPicker_ngayVe.SelectedDate == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin Ngày Đi, Ngày Về, Hạng Vé, Điểm Xuất Phát, Điểm Đến. Nhấn nút Tìm Kiếm để lọc thông tin", "Thông Báo", MessageBoxButton.OK);
                }
                else
                {
                    if (danhSachChuyenBayTemp.Count == 0)
                    {
                        MessageBox.Show("Bạn chưa chọn chuyến bay", "Thông Báo", MessageBoxButton.OK);
                    }
                    else if (danhSachChuyenBayTemp.Count == 1)
                    {
                        MessageBox.Show("Bạn đang chọn chuyến bay Khứ Hồi phải chọn đủ cả chuyến bay đi và chuyến bay về", "Thông Báo", MessageBoxButton.OK);
                    }
                    else if (danhSachChuyenBayTemp.Count > 2)
                    {
                        MessageBox.Show("Bạn đang chọn chuyến bay Khứ Hồi Chỉ được chọn 2 chuyến bay", "Thông Báo", MessageBoxButton.OK);

                    }
                    else
                    {
                        if (danhSachChuyenBayTemp[0].diemXuatPhat == danhSachChuyenBayTemp[1].diemXuatPhat)
                        {
                            MessageBox.Show("Bạn chưa chọn chuyến bay về", "Thông Báo", MessageBoxButton.OK);
                        }
                        else
                        {
                            if (danhSachChuyenBayTemp[0].hangHangKhong != danhSachChuyenBayTemp[1].hangHangKhong)
                            {
                                MessageBox.Show("Chuyến bay Khứ Hồi không cho phép chọn 2 chuyến bay không cùng hãng.   Nhập từ khóa tìm kiếm hãng hàng không và chọn lại", "Thông Báo", MessageBoxButton.OK);
                            }
                            else
                            {
                                XemChiTietChuyenBay xemChiTiet_UI = new XemChiTietChuyenBay(_id, danhSachChuyenBayTemp);
                                xemChiTiet_UI.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thông tin Một Chiều Hoặc Khứ Hồi", "Thông Báo", MessageBoxButton.OK);
            }
        }

        private void rb_MotChieuChecked(object sender, RoutedEventArgs e)
        {
            dataPicker_ngayVe.IsEnabled = false;
            txtNgayVe.IsEnabled = false;
        }

        private void rbKhuHoi_Checked(object sender, RoutedEventArgs e)
        {
            dataPicker_ngayVe.IsEnabled = true;
        }
        private void frBody_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void tbSoKhach_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            List<ChuyenBay> dsChuyenBay = new List<ChuyenBay>();
            if (rbMotChieu.IsChecked == true)
            {
                if (dataPicker_ngayDi.SelectedDate == null || cb_HangGhe.SelectedItem == null || cb_diemXuatPhat.SelectedItem == null || cb_diemDen.SelectedItem == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin Ngày Đi, Hạng Vé, Điểm Xuất Phát, Điểm Đến", "Thông Báo", MessageBoxButton.OK);
                }
                else
                {
                    DateTime selectedDate = (DateTime)dataPicker_ngayDi.SelectedDate;
                    string ngayDi = selectedDate.ToString("dd-MM-yyyy");
                    dsChuyenBay = chuyenBayBussiness.TimKiemChuyenBay(ngayDi, cb_HangGhe.Text, cb_diemXuatPhat.Text, cb_diemDen.Text);
                    if (dsChuyenBay == null)
                    {
                        MessageBox.Show("Không có chuyến bay nào đúng với yêu cầu");
                    }
                    else
                    {
                        dgvChuyenBay.ItemsSource = dsChuyenBay;
                        dgvChuyenBay.Items.Refresh();
                        danhSachChuyenBay = dsChuyenBay;
                    }
                }
            }
            else if (rbKhuHoi.IsChecked == true)
            {
                List<ChuyenBay> dsChuyenBayVe = new List<ChuyenBay>();
                if (dataPicker_ngayDi.SelectedDate == null || cb_HangGhe.SelectedItem == null || cb_diemXuatPhat.SelectedItem == null || cb_diemDen.SelectedItem == null || dataPicker_ngayVe.SelectedDate == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin Ngày Đi, Ngày Về, Hạng Vé, Điểm Xuất Phát, Điểm Đến", "Thông Báo", MessageBoxButton.OK); 
                }
                else
                {
                    if (dataPicker_ngayDi.SelectedDate > dataPicker_ngayVe.SelectedDate)
                    {
                        MessageBox.Show("Ngày Về phải lớn hơn Ngày Đi", "Thông Báo", MessageBoxButton.OK);
                    }
                    else
                    {
                        DateTime selectedNgayDi = (DateTime)dataPicker_ngayDi.SelectedDate;
                        DateTime selectedNgayVe = (DateTime)dataPicker_ngayVe.SelectedDate;
                        string ngayDi = selectedNgayDi.ToString("dd-MM-yyyy");
                        string ngayVe = selectedNgayVe.ToString("dd-MM-yyyy");
                        dsChuyenBay = chuyenBayBussiness.TimKiemChuyenBay(ngayDi, cb_HangGhe.Text, cb_diemXuatPhat.Text, cb_diemDen.Text);
                        if (dsChuyenBay == null)
                        {
                            MessageBox.Show("Không có chuyến bay nào đúng với yêu cầu");
                        }
                        else
                        {
                            dsChuyenBayVe = chuyenBayBussiness.TimKiemChuyenBay(ngayVe, cb_HangGhe.Text, cb_diemDen.Text, cb_diemXuatPhat.Text);
                            if (dsChuyenBayVe == null)
                            {
                                MessageBox.Show("Không có chuyến bay nào đúng với yêu cầu");
                            }
                            else
                            {
                                dsChuyenBay.AddRange(dsChuyenBayVe);
                                dgvChuyenBay.ItemsSource = dsChuyenBay;
                                dgvChuyenBay.Items.Refresh();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thông tin Một Chiều Hoặc Khứ Hồi", "Thông Báo", MessageBoxButton.OK);
            }
        }

        private void btn_TraCuuVe_Click(object sender, RoutedEventArgs e)
        {
            XemThongTinVe xemThongTinVe_UI = new XemThongTinVe();
            xemThongTinVe_UI.Show();
            this.Close();
        }
        private void btn_XemGioHang_Click(object sender, RoutedEventArgs e)
        {
            XemGioHang xemGioHang_UI = new XemGioHang(_id);
            xemGioHang_UI.Show();
            this.Close();
        }

        private void comboBox_diemXuatPhat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgvChuyenBay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_HangGhe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            Login login_UI = new Login();
            login_UI.Show();
            this.Close();
        }
        private void tbHangHangKhong_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgvChuyenBay.Items.Filter = FilterMethod;
        }
        private bool FilterMethod(object obj)
        {
            var ChuyenBay = (ChuyenBay)obj;
            return ChuyenBay.hangHangKhong.Contains(tbHangHangKhong.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
