using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Book
    {
        public Book(DataRow row) 
        {
            this.ID = (int)row["MASACH"];
            this.Name = row["TENSACH"].ToString();
            this.Author = row["TACGIA"].ToString();
            this.Nxb = row["NXB"].ToString();
            this.Sluong = (int)row["SOLUONGTON"];
            this.Gianhap = (int)row["DONGIANHAP"];
            this.Giaban = (int)row["DONGIABAN"];
        }
        public Book(int id, string name, string author, string nxb, int sluong, int gianhap, int giaban) 
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.nxb = nxb;
            this.sluong = sluong;
            this.gianhap = gianhap;
            this.giaban = giaban;
        }
        private static Book instance;
        private int id;
        private string name;
        private string author;
        private string nxb;
        private int sluong;
        private int gianhap;
        private int giaban;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Nxb { get => nxb; set => nxb = value; }
        public int Sluong { get => sluong; set => sluong = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
        public int Giaban { get => giaban; set => giaban = value; }
    }
}
