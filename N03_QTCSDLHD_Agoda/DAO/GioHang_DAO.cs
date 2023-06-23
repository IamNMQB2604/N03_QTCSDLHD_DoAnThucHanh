using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using StackExchange.Redis;

namespace DAO
{
    public class GioHang_DAO
    {
        public List<GioHang>LayTatCaThongTinGioHang_DB(int id)
        {
            var redisConnectionString = "localhost:6379"; // Thay thế bằng thông tin máy chủ Redis của bạn
            var redis = ConnectionMultiplexer.Connect(redisConnectionString);
            var db = redis.GetDatabase();
            List<string>idChuyenBay = new List<string>();
            List<GioHang> dsgioHang = new List<GioHang>();
            var fields = db.HashKeys(id.ToString()); // Lấy tất cả các trường trong hash
            foreach (var field in fields)
            {
                idChuyenBay.Add(field.ToString());
            }
            for(int i=0;i<idChuyenBay.Count;i++)
            {
                string value = db.HashGet(id.ToString(), idChuyenBay[i]);
                GioHang gioHang = new GioHang();
                gioHang.id = idChuyenBay[i];
                gioHang.thongTinChuyenBay = value;
                dsgioHang.Add(gioHang);
            }
            if (dsgioHang.Count == 0)
            {
                return null;
            }
            else
            {
                return dsgioHang;
            }
        }
    }
}
