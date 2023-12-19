using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(primary: Primary.Grey900, darkPrimary: Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txb_UserName.Text;
            string password = txb_Password.Text;
            if (Check_Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username);
                FrmMain f = new FrmMain(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool Check_Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
    }
}
