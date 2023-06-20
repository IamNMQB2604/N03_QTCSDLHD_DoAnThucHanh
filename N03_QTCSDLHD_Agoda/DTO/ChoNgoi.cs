using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DTO
{
    public class ChoNgoi
    {
        [BsonElement("maGhe")]
        public string? maGhe { get; set; }

        [BsonElement("giaTien")]
        public int giaTien { get; set; }
    }
}
