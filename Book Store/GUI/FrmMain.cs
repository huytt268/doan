﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmMain: MaterialForm
    {
        private Account loginAccount;

        public Account LoginAccount 
        { 
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(loginAccount.Loaitk); }
        }

        public FrmMain(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(primary:Primary.Grey900, darkPrimary:Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadBook();
            LoadBill();
        }

        #region Method
        void ChangeAccount(int type)
        {
            //tab doanh thu
            dgv_icBill.Visible = type == 1;
            lv_icBillInfo.Visible = type == 1;
            bunifuLabel8.Visible = type == 1;
            txb_icTotal.Visible = type == 1;
            //tab phiếu nhập
            bunifuPanel10.Visible = type == 1;
            bunifuPanel11.Visible = type == 1;
            dgv_Nhap.Visible = type == 1;
            //tab nhân viên
            bunifuPanel14.Visible = type == 1;
            dgv_Staff.Visible = type == 1;
            bunifuPanel16.Visible = type == 1;
            //tab thông tin cá nhân
            txb_AccUser.Text = loginAccount.Username;

            //Ngăn quyền truy cập
            btn_Privacy1.Visible = type == 0;
            btn_Privacy2.Visible = type == 0;
            btn_Privacy3.Visible = type == 0;
                     
        }
        void LoadBook()
        {
            dgv_Search.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetBookList");
            dgv_billFullBook.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetBookList");
        }
        void LoadBill()
        {
            dgv_icBill.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetBillList");
        }
        void ShowBill(int id)
        {
            lv_icBillInfo.Items.Clear();
            List<BillDetail> listBillDetail = BillDetailDAO.Instance.GetBillDetail(id);
            int total = 0;
            foreach (BillDetail item in listBillDetail) 
            {
                ListViewItem lvItem = new ListViewItem(item.BookName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Total.ToString());
                total += item.Total;
                lv_icBillInfo.Items.Add(lvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txb_icTotal.Text = total.ToString("c");
        }
        void UpdateAccount()
        {
            string displayName = txb_AccUser.Text;
            string password = txb_AccPass.Text;
            string newpassword = txb_AccNewPass.Text;
            string repeat = txb_AccRepeat.Text;
            if(newpassword == "")
            {
                return;
            }
            else if (!repeat.Equals(newpassword))
            {
                MessageBox.Show("Nhập lại mật khẩu phải trùng với mật khẩu mới!");
            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(displayName, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                }
            }
        }
        private void DeleteCheckedItems()
        {
            int total = Convert.ToInt32(txb_billTotalPrice.Text);


            foreach (ListViewItem selectedItem in lv_bill.SelectedItems)
            {
                for (int i = 0; i < dgv_billFullBook.Rows.Count; i++)
                {
                    if (dgv_billFullBook.Rows[i].Cells[1].Value.Equals(selectedItem.SubItems[0].Text) &&
                        dgv_billFullBook.Rows[i].Cells[2].Value.Equals(selectedItem.SubItems[1].Text))
                    {
                        int currentvalue = Convert.ToInt32(dgv_billFullBook.Rows[i].Cells[4].Value);
                        dgv_billFullBook.Rows[i].Cells[4].Value = currentvalue + Convert.ToInt32(selectedItem.SubItems[3].Text);
                        break;
                    }
                }
                total -= Convert.ToInt32(selectedItem.SubItems[4].Text);


                lv_bill.Items.Remove(selectedItem);
            }
            txb_billTotalPrice.Text = total.ToString();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lv_bill.GridLines = true;
            lv_bill.FullRowSelect = true;
            lv_bill.AutoSize = false;
        }
        #endregion

        #region Event
        //xử lí nút thanh toán hóa đơn
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            if (lv_bill.Items.Count != 0)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.InsertBill(Convert.ToInt32(txb_billTotalPrice.Text));
                    int idbill = BillDAO.Instance.GetMaxIDBill();
                    foreach (ListViewItem item in lv_bill.Items)
                    {
                        int idbook = BookDAO.Instance.GetIDbyName(item.Text, item.SubItems[1].Text);
                        int count = Convert.ToInt32(item.SubItems[3].Text);
                        int total = Convert.ToInt32(item.SubItems[4].Text);
                        BillInfoDAO.Instance.InsertBillInfo(idbill, idbook, count, total);
                    }
                    lv_bill.Items.Clear();
                    LoadBook();
                    MessageBox.Show("Thanh toán thành công");
                }
            }
        }
        private void btn_RemoveBook_Click(object sender, EventArgs e)
        {
            DeleteCheckedItems();
        }
        private void btn_AddBookSale_Click(object sender, EventArgs e)
        {
            if (dgv_billFullBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần thêm");
            }
            else
            {
                FrmBill frmBill = new FrmBill();
                frmBill.frmMain = this;
                //frmBill.Owner = this;
                //if (frmBill == null || frmBill.IsDisposed)
                //{
                //    frmBill = new FrmBill();
                //}
                frmBill.txb_billName.Text = dgv_billFullBook.SelectedRows[0].Cells[1].Value.ToString();
                frmBill.txb_billAuth.Text = dgv_billFullBook.SelectedRows[0].Cells[2].Value.ToString();
                frmBill.txb_billCost.Text = dgv_billFullBook.SelectedRows[0].Cells[6].Value.ToString();
                frmBill.txb_RemainAmount.Text = dgv_billFullBook.SelectedRows[0].Cells[4].Value.ToString();
                frmBill.Show();
            }


        }

        private void dgv_icBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idBill = (int)dgv_icBill.SelectedCells[0].Value;
            ShowBill(idBill);
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btn_AccLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_AccUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
        private void btn_bookSearch_Click(object sender, EventArgs e)
        {           
            string searchbook = txb_bookSearch.Text;    
            dgv_Search.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetFilteredBookList @bookname", new object[]{searchbook});
        }

        private void txb_bookSearch_TextChanged(object sender, EventArgs e)
        {
            if(txb_bookSearch.Text == "") dgv_Search.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetBookList");
        }

        //Khai báo biến để không cần gọi đi gọi lại
        //FrmBill frmBill = new FrmBill();
        

        //Sự kiện khi click cell của dtgv
        private void dgv_billFullBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmBill.txb_billName.Text = dgv_billFullBook.SelectedRows[0].Cells[1].Value.ToString();
            //frmBill.txb_billAuth.Text = dgv_billFullBook.SelectedRows[0].Cells[2].Value.ToString();
            //frmBill.txb_billCost.Text = dgv_billFullBook.SelectedRows[0].Cells[6].Value.ToString();
            //frmBill.txb_RemainAmount.Text = dgv_billFullBook.SelectedRows[0].Cells[4].Value.ToString();
        }                     

        #endregion
               
        //hàm rác nhưng đừng xóa, xóa bể giao diện
        private void lv_bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }     
    }
}
