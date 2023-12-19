using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE USERNAME = '"+username+"'");
            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }
        public bool UpdateAccount(string userName, string pass, string newPass)
        {
            int result =  DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @username , @password , @newpassword ",new object[] {userName,pass,newPass});
            return result > 0;
        }
    }
}
