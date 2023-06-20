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
using System.Collections;

namespace GUI
{
    /// <summary>
    /// Interaction logic for XemChiTietChuyenBay.xaml
    /// </summary>
    public partial class XemChiTietChuyenBay : Window
    {
        int _id;
        public XemChiTietChuyenBay(int id,ChuyenBay chuyenBay)
        {
            InitializeComponent();
            HienThiThongTinChiTietChuyenBay(chuyenBay);
            _id = id;
        }
        private void HienThiThongTinChiTietChuyenBay(ChuyenBay chuyenBay)
        {
            dgvThongTinChuyenBay.Items.Add(chuyenBay);
            tbChiTietChuyenBay.Text = "Số Hiệu: " + chuyenBay.chiTietChuyenBay.soHieu + '\n' + "Loại Máy Bay: " + chuyenBay.chiTietChuyenBay.loaiMayBay + '\n'
                + "Sân Bay Đi: " + chuyenBay.chiTietChuyenBay.sanBayDi + '\n' + "Sân Bay Đến: " + chuyenBay.chiTietChuyenBay.sanBayDen;
            if (chuyenBay.chiTietChuyenBay.moTa == null)
            {
                tbMoTa.Text = "Không có mô tả";
            }
            else
            { tbMoTa.Text = chuyenBay.chiTietChuyenBay.moTa; }
            if (chuyenBay.chiTietChuyenBay.diemDung == null)
            {
                tbDiemDung.Text = "Không có điểm dừng";
            }
            else
            {
                List<DiemDung> diemDungList = chuyenBay.chiTietChuyenBay.diemDung;
                // In thông tin các điểm dừng
                List<string> diemDungTemp = new List<string>();

                for (int i = 0; i < diemDungList.Count; i++)
                {
                    diemDungTemp.Add("Địa Điểm: " + diemDungList[i].DiaDiem.ToString() + '\n' + "Thời Gian: " + diemDungList[i].Date.ToString("dd:MM:yy HH:mm:ss")); 
                }
                tbDiemDung.Text = string.Join('\n', diemDungTemp);
            }
        }

        private void btnQuayLai_Click(object sender, RoutedEventArgs e)
        {

            XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(_id);
            xemChuyenBay_UI.Show();
            this.Close();
        }
    }
}
