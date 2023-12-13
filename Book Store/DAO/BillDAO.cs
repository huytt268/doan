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
    }
}
