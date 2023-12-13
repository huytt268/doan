using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime nghd, string manv, int total) 
        {
            this.Id = id;
            this.Nghd = nghd;
            this.Manv = manv;
            this.Total = total;
        }   

        public Bill(DataRow row)
        {
            this.Id = (int)row["MAHD"];
            this.Nghd = (DateTime)row["NGAYLAP"];
            this.Manv = row["MANV"].ToString();
            this.Total = (int)row["TONGTIEN"];
        }

        private int id;
        private DateTime nghd;
        private string manv;
        private int total;

        public int Id { get => id; set => id = value; }
        public DateTime Nghd { get => nghd; set => nghd = value; }
        public string Manv { get => manv; set => manv = value; }
        public int Total { get => total; set => total = value; }
    }
}
