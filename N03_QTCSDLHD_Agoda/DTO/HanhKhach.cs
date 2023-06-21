using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace DTO
{
    public class HanhKhach
    {
        [BsonElement("hoTen")]
        public string? hoTen { get; set; }

        [BsonElement("gioiTinh")]
        public string? gioiTinh { get; set; }

        [BsonElement("ngaySinh")]
        public string? ngaySinh { get; set; }

        [BsonElement("quocTich")]
        public string? quocTich { get; set; }

        [BsonElement("hanhLy")]
        public HanhLy? hanhLy { get; set; }

        [BsonElement("choNgoi")]
        public ChoNgoi? choNgoi { get; set; }
    }
}
