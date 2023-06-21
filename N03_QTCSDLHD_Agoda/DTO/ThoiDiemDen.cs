using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiDiemDen
    {
        [BsonElement("NgayDen")]
        public string? ngayDen { get; set; }
        [BsonElement("GioDen")]
        public string? gioDen { get; set; }
    }
}
