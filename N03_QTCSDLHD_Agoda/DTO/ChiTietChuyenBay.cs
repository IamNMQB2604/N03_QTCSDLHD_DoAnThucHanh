using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietChuyenBay
    {
        [BsonElement("soHieu")]
        public string ? soHieu { get; set; }
        [BsonElement("loaiMayBay")]
        public string ? loaiMayBay { get; set; }
        [BsonElement("sanBayDi")]
        public string ? sanBayDi { get; set; }
        [BsonElement("sanBayDen")]
        public string ? sanBayDen { get; set; }
        public List<DiemDung> ? diemDung { get; set; }
    }
}
