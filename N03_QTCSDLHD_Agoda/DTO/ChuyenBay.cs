using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace DTO
{
    public class ChuyenBay
    {
        [BsonId]
        public int _id { get; set; }
        [BsonElement ("hangHangKhong")]
        public string? hangHangKhong { get; set; }
        [BsonElement("thoiDiemDi")]
        public DateTime thoiDiemDi { get; set; }
        [BsonElement("thoiDiemDen")]
        public DateTime thoiDiemDen { get; set; }
        [BsonElement("thoiGianBay")]
        public string ?thoiGianBay { get; set; }
        [BsonElement("giaVe")]
        public decimal giaVe { get; set; }
        [BsonElement("diemXuatPhat")]
        public string? diemXuatPhat { get; set; }
        [BsonElement("diemDen")]
        public string? diemDen { get; set; }
        [BsonElement("diemDung")]
        public int diemDung { get; set; }
        [BsonElement("chiTietChuyenBay")]
        public ChiTietChuyenBay  chiTietChuyenBay { get; set; }
        [BsonElement("hangVe")]
        public string? hangVe { get; set; }
    }
}
