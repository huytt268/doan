using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Bunifu.UI.WinForms.BunifuSnackbar;
using System.Drawing.Text;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmBill : MaterialForm
    {

        public FrmBill()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(primary: Primary.Grey900, darkPrimary: Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        //Sự kiện thêm dự liệu vào list view
        public FrmMain frmMain;
        private void btn_billAdd_Click(object sender, EventArgs e)
        {
            //FrmMain frmMain = this.Owner as FrmMain;
            if (txb_billName.Text == "" || txb_billAuth.Text == "" || txb_billAmount.Text == "")
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            else
            {
                if (Convert.ToInt32(txb_billAmount.Text) > Convert.ToInt32(txb_RemainAmount.Text))
                    MessageBox.Show("Không đủ số lượng tồn");
                else
                {
                    int total = Convert.ToInt32(txb_billAmount.Text) * Convert.ToInt32(txb_billCost.Text);
                    int flag = 0;
                    int Amount = 0;
                    int TotalOld = 0;
                    
                    foreach (ListViewItem listItem in frmMain.lv_bill.Items)
                    {
                        if (txb_billName.Text == listItem.SubItems[0].Text &&
                            txb_billAuth.Text == listItem.SubItems[1].Text)
                        {
                            flag = 1;
                            Amount = Convert.ToInt32(listItem.SubItems[3].Text);
                            TotalOld = Convert.ToInt32(listItem.SubItems[4].Text);
                            Updatedgv(Amount);
                            frmMain.txb_billTotalPrice.Text = (Convert.ToInt32(frmMain.txb_billTotalPrice.Text) -TotalOld).ToString();
                            frmMain.lv_bill.Items.Remove(listItem);

                            break;
                        }
                    }
                    // Assuming listView1 is the name of your ListView control
                    if (flag == 0)
                    {
                        ListViewItem item = new ListViewItem(txb_billName.Text);
                        Updatedgv(-Convert.ToInt32(txb_billAmount.Text));
                        AddItem(total);
                        
                    }
                    else
                    {
                        txb_billAmount.Text = (Convert.ToInt32(txb_billAmount.Text) + Amount).ToString();
                        total += TotalOld;
                        Updatedgv(-Convert.ToInt32(txb_billAmount.Text));
                        AddItem(total);
                        
                    }
                }
            }

        }
        private void AddItem(int total)
        {
            ListViewItem item = new ListViewItem(txb_billName.Text);
            item.SubItems.Add(txb_billAuth.Text);
            item.SubItems.Add(txb_billCost.Text);
            item.SubItems.Add(txb_billAmount.Text);
            item.SubItems.Add(total.ToString());
            frmMain.lv_bill.Items.Add(item);
            int temp = Convert.ToInt32(frmMain.txb_billTotalPrice.Text);
            temp = temp + total;
            frmMain.txb_billTotalPrice.Text = temp.ToString();
            this.Close();
        }
        private void Updatedgv(int Amount)
        {
            int currentvalue = Convert.ToInt32(frmMain.dgv_billFullBook.SelectedRows[0].Cells[4].Value);
            frmMain.dgv_billFullBook.SelectedRows[0].Cells[4].Value = currentvalue + Amount;
        }
    }
    
}
