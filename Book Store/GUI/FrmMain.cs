using System;
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
using MaterialSkin;
using MaterialSkin.Controls;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmMain: MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(primary:Primary.Grey900, darkPrimary:Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadBook();
            LoadBill();
        }

        #region Method
        
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
        #endregion

        #region Event
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

        private void dgv_icBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idBill= (int)dgv_icBill.SelectedCells[0].Value;           
            ShowBill(idBill);
        }

        private void btn_AddBookSale_Click(object sender, EventArgs e)
        {
            if(dgv_billFullBook.SelectedRows.Count == 0)
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
        
        private void DeleteCheckedItems()
        {
            int total = Convert.ToInt32(txb_billTotalPrice.Text);

            foreach (ListViewItem selectedItem in lv_bill.SelectedItems)
            {
                total -= Convert.ToInt32(selectedItem.SubItems[3].Text);
                lv_bill.Items.Remove(selectedItem);
            }
            txb_billTotalPrice.Text = total.ToString();
        }

        private void btn_RemoveBook_Click(object sender, EventArgs e)
        {
            DeleteCheckedItems();                
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lv_bill.GridLines = true;
            lv_bill.FullRowSelect = true;
        }

        private void lv_bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.InsertBill(Convert.ToInt32(txb_billTotalPrice.Text));

            //BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(),)
        }
    }
}
