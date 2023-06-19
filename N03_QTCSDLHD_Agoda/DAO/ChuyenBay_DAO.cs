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
    }
}
