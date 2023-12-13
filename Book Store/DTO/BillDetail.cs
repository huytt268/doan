using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BillDetail
    {
        public BillDetail(string bookName, int count, int price, int total) 
        {
            this.BookName = bookName;
            this.Count = count;
            this.Price = price;
            this.Total = total;
        }

        public BillDetail(DataRow row) 
        {
            this.BookName = row["TENSACH"].ToString();
            this.Count = (int)row["SOLUONG"];
            this.Price = (int)row["DONGIABAN"];
            this.Total = (int)row["THANHTIEN"];
        }

        private string bookName;
        private int count;
        private int price;
        private int total;

        public string BookName { get => bookName; set => bookName = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int Total { get => total; set => total = value; }
    }
}
