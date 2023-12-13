using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance 
        {
            get { if (instance == null) instance = new BillDetailDAO(); return instance; }
            private set => instance = value; 
        }
        private BillDetailDAO() { }

        public List<BillDetail> GetBillDetail(int id)
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();
            string query = "SELECT S.TENSACH, CT.SOLUONG, S.DONGIABAN, S.DONGIABAN*CT.SOLUONG AS THANHTIEN FROM HOADON HD, CTHD CT, SACH S" +
                " WHERE HD.MAHD = CT.MAHD AND CT.MASACH = S.MASACH AND HD.MAHD = '"+id.ToString()+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillDetail item = new BillDetail(row);
                listBillDetail.Add(item);
            }

            return listBillDetail;
        }
    }
}
