using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Account
    {
        public Account(string username, int loaitk, string password = null) 
        { 
            this.Username = username;
            this.Password = password;
            this.Loaitk = loaitk;
        }
        public Account(DataRow row)
        {
            this.Username = row["USERNAME"].ToString();
            this.Password = row["PASS"].ToString();
            this.Loaitk = (int)row["LOAITK"];
        }
        private string username;
        private string password;
        private int loaitk;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Loaitk { get => loaitk; set => loaitk = value; }
    }
}
