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
                    // Assuming listView1 is the name of your ListView control
                    ListViewItem item = new ListViewItem(txb_billName.Text);
                    item.SubItems.Add(txb_billAmount.Text);
                    item.SubItems.Add(txb_billCost.Text);
                    item.SubItems.Add(total.ToString());                                      
                    frmMain.lv_bill.Items.Add(item);
                    int temp = Convert.ToInt32(frmMain.txb_billTotalPrice.Text);
                    temp = temp + total;
                    frmMain.txb_billTotalPrice.Text = temp.ToString();
                    this.Close();
                }
            }
        }
    }
}
