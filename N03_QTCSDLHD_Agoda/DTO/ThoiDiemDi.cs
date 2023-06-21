using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiDiemDi
    {
        [BsonElement("NgayDi")]
        public string ngayDi { get; set; }
        [BsonElement("GioDi")]
        public string gioDi { get; set; }
    }
}
