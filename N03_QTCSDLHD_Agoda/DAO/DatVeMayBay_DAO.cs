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
    }
}
