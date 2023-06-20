using BUS;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Login_BUS loginBussiness = new Login_BUS();
        public Login()
        {
            InitializeComponent();
        }
        private void btnLoggin_Click(object sender, RoutedEventArgs e)
        {
            // Đăng nhập

            NguoiDung nguoiDung = loginBussiness.LayThongTinNguoiDung(tbUsername.Text, tbPass.Password);
            if(nguoiDung != null ) 
            {
                XemChuyenBay xemChuyenBay_UI = new XemChuyenBay(nguoiDung._id);
                xemChuyenBay_UI.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
                return;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Thoát ứng dụng
            Close();
        }
    }
}
