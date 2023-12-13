using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        private BillDAO() { }

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; } 
            private set => instance = value; 
        }

        public int GetBillID()
        {
            return (int)DataProvider.Instance.ExecuteScalar("");
        }
        public void InsertBill(int total)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_AddBill @total", new object[] {total});
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MAHD) FROM HOADON");

            }
            catch
            {
                return 1;
            }
        }
    }
}
