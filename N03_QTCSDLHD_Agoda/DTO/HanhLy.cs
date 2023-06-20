using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DTO
{
    public class HanhLy
    {
        [BsonElement("soKg")]
        public int soKg { get; set; }

        [BsonElement("giaTien")]
        public int giaTien { get; set; }

    }
}
