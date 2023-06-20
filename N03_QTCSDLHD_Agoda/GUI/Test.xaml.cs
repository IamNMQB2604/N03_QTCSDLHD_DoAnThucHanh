using MongoDB.Driver;
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
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using DTO;
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        Login_BUS loginBussiness = new Login_BUS();

        public Test()
        {
            InitializeComponent();
            /*
            KhachHang khachHang = loginBussiness.LayThongTinKhachHang("1234", "1234");
            if (khachHang != null)
            {
                TestTING.Text = khachHang.email;
            }
            else
            {
                TestTING.Text = "Cặc";
            }
            */
        }
    }
}
