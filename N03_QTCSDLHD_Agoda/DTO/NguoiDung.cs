using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace DTO
{
    public class NguoiDung
    { 
        [BsonId]
        public int _id { get; set; }
        [BsonElement("hoTen")]
        public string? hoTen { get; set; }
        [BsonElement("SDT")]
        public string? SDT { get; set; }
        [BsonElement("email")]
        public string? email { get; set; }
        [BsonElement("matKhau")]
        public string ?matKhau { get; set; }
    }
}

