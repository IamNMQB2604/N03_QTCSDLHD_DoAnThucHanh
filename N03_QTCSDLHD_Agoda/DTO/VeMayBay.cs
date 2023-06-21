using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DTO
{
    public class VeMayBay
    {
        [BsonId]
        public int _id { get; set; }

        [BsonElement("id_nguoiDung")]
        public int id_nguoiDung { get; set; }

        [BsonElement("maQuocGia")]
        public string? maQuocGia { get; set; }

        [BsonElement("SDT")]
        public string? SDT { get; set; }

        [BsonElement("email")]
        public string? email { get; set; }

        [BsonElement("chuyenBay")]
        public List<ChuyenBay>? chuyenBay { get; set; }

        [BsonElement("hanhKhach")]
        public List<HanhKhach>? hanhKhach { get; set; }

        [BsonElement("theTinDung")]
        public TheTinDung? theTinDung { get; set; }

        [BsonElement("ngayDatVe")]
        public string? ngayDatVe { get; set; }

    }
}
