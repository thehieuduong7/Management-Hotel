using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Room
    {
        public string id_phong { get; }
        public string loai { get; set; }
        public int so_giuong { get; set; }
        public string vitri { get; set; }
        public float giaPhong { get; set; }
        public Room(object[] arr)
        {
            try
            {
                string id = arr[0].ToString().Trim();
                string loai = arr[1].ToString().Trim();
                int so_giuong = int.Parse(arr[2].ToString());
                string vitri = arr[3].ToString().Trim();
                float gia = float.Parse(arr[4].ToString());
                this.id_phong = id;
                this.loai = loai;
                this.so_giuong = so_giuong;
                this.vitri = vitri;
                this.giaPhong = gia;
            }
            catch (FormatException) { }
        }
        public Room(string id,string loai,int so_giuong,string vitri,float gia)
        {
            this.id_phong = id;
            this.loai = loai;
            this.so_giuong = so_giuong;
            this.vitri = vitri;
            this.giaPhong = gia;
        }
    }
}
