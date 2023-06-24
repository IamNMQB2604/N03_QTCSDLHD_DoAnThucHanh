using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data;
using System.Security.Policy;
using System.Collections;
using System.Windows;

namespace DAO
{
    public class DatVeMayBay_DAO
    {
        public void ThemCacVeMayBay_DB(VeMayBay veMayBay)
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var database = mongoClient.GetDatabase("QuanLyVeMayBay"); // Thay "ten_database" bằng tên database thực tế
            var collection = database.GetCollection<VeMayBay>("VeMayBay"); // Thay "ten_bosuutap" bằng tên collection thực tế
            collection.InsertOne(veMayBay);

        }
        public List<VeMayBay> LayTatCaThongTinVe_DB()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<VeMayBay>("VeMayBay");
            List<VeMayBay> ThongTinVe = new List<VeMayBay>();
            ThongTinVe = collection.Find(_ => true).ToList();
            if (ThongTinVe.Count == 0)
            {
                return null;
            }
            else
            {
                return ThongTinVe;
            }
        }

        public List<VeMayBay> LayThongTinVeMayBay_DB(int id)
        {
            List<VeMayBay> danhSachVeMayBay = new List<VeMayBay>();

            // Kết nối tới cơ sở dữ liệu MongoDB
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<VeMayBay>("VeMayBay");

            // Tạo một filter để tìm các vé máy bay có idnguoidung tương ứng
            var filter = Builders<VeMayBay>.Filter.Eq("id_nguoiDung", id);

            // Thực hiện truy vấn và lấy danh sách vé máy bay
            var veMayBayCursor = collection.Find(filter);
            danhSachVeMayBay = veMayBayCursor.ToList();
            if (danhSachVeMayBay.Count == 0)
            {
                return null;
            }
            else
            {
                return danhSachVeMayBay;
            }
        }
    }
}
