using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Login_DAO
    {
        public NguoiDung LayThongTinNguoiDungDB(string sdt,string matKhau)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("QuanLyVeMayBay");

            IMongoCollection<NguoiDung> collection = database.GetCollection<NguoiDung>("NguoiDung");

            var filter = Builders<NguoiDung>.Filter.Eq("SDT", sdt) & Builders<NguoiDung>.Filter.Eq("matKhau", matKhau);
            var result = collection.Find(filter).FirstOrDefault();

            return result;
        }
    }
}
