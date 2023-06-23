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
using StackExchange.Redis;
using System.Windows.Media.Media3D;

namespace DAO
{
    public class ChuyenBay_DAO
    {
        public List<ChuyenBay> LayDanhSachChuyenBay_DB()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<ChuyenBay>("ChuyenBay");
            List<ChuyenBay> danhSachChuyenBay = new List<ChuyenBay>();
            danhSachChuyenBay = collection.Find(_ => true).ToList();
            if (danhSachChuyenBay.Count == 0)
            {
                return null;
            }
            else
            {
                return danhSachChuyenBay;
            }
        }
        public ChuyenBay LayThongTinChuyenBay_DB(int id)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<ChuyenBay>("ChuyenBay");
            var filter = Builders<ChuyenBay>.Filter.Eq("_id", id);
            var flight = collection.Find(filter).FirstOrDefault();
            return flight;
        }    
        public List<ChuyenBay> TimKiemChuyenBay_DB(string ngayDi, string hangVe, string diemXuatPhat, string diemDen)
        {

            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("QuanLyVeMayBay");
            var collection = db.GetCollection<ChuyenBay>("ChuyenBay");

            var filter = Builders<ChuyenBay>.Filter.And(
                Builders<ChuyenBay>.Filter.Eq("thoiDiemDi.NgayDi", ngayDi),
                Builders<ChuyenBay>.Filter.Eq("hangVe", hangVe),
                Builders<ChuyenBay>.Filter.Eq("diemXuatPhat", diemXuatPhat),
                Builders<ChuyenBay>.Filter.Eq("diemDen", diemDen)
            );

            List<ChuyenBay> danhSachChuyenBay = collection.Find(filter).ToList();
            if (danhSachChuyenBay.Count == 0)
            {
                return null;
            }
            else
            {
                return danhSachChuyenBay;
            }
        }
        public bool ThemChuyenBayVaoGioHang_DB(string idKhachHang,string idChuyenBay,string thongTinChuyenBay)
        {
            var redisConnectionString = "localhost:6379"; // Thay thế bằng thông tin máy chủ Redis của bạn
            var redis = ConnectionMultiplexer.Connect(redisConnectionString);
            var db = redis.GetDatabase();
            bool added = db.HashSet(idKhachHang, idChuyenBay, thongTinChuyenBay);
            return added;
        }
    }
}
