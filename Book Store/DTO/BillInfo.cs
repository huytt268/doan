using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BillInfo
    {
        public BillInfo(int billId, int bookId, int amount, int total) 
        {
            this.BillId = billId;
            this.BookId = bookId;   
            this.Amount = amount;
            this.Total = total;
        }

        public BillInfo(DataRow row)
        {
            this.BillId = (int)row["MAHD"];
            this.BookId = (int)row["MASACH"];
            this.Amount = (int)row["SOLUONG"];
            this.Total = (int)row["THANHTIEN"];
        }

        private int billId;
        private int bookId;
        private int amount;
        private int total;

        public int BillId { get => billId; set => billId = value; }
        public int BookId { get => bookId; set => bookId = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Total { get => total; set => total = value; }
    }
}
