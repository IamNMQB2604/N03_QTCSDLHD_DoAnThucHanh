using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    public class DiemDung
    {
        [BsonElement("thoiGian")]
        public DateTime Date { get; set; }
        [BsonElement("diaDiem")]
        public string DiaDiem { get; set; }
    }
}
