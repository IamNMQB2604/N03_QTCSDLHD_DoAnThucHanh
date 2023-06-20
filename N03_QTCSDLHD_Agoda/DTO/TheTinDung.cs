using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DTO
{
    public class TheTinDung
    {
        [BsonElement("tenThe")]
        public string? tenThe { get; set; }

        [BsonElement("soThe")]
        public string? soThe { get; set; }

        [BsonElement("ngayHetHan")]
        public DateOnly ngayHetHan { get; set; }
    }
}
