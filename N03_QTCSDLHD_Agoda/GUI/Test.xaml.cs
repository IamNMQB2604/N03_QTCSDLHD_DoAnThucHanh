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

namespace GUI
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
            Hehe();

        }
        private void Hehe()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<ChuyenBay>("ChuyenBay");
            List<ChuyenBay> danhSachChuyenBay = new List<ChuyenBay>();
            danhSachChuyenBay = collection.Find(_ => true).ToList();
            DITMEMAY.ItemsSource = danhSachChuyenBay;
            DITMEMAY.Items.Refresh();

        }
        public class ChuyenBay
        {
            [BsonId]
            public int _id { get; set; }
            [BsonElement("hangHangKhong")]
            public string? hangHangKhong { get; set; }
        }
    }
}
