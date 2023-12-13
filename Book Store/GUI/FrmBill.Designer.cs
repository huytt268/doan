namespace WindowsFormsApp1.GUI
{
    partial class FrmBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBill));
            this.btn_billAdd = new MaterialSkin.Controls.MaterialButton();
            this.txb_billName = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txb_billAuth = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txb_billCost = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txb_billAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txb_RemainAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_billAdd
            // 
            this.btn_billAdd.AutoSize = false;
            this.btn_billAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_billAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_billAdd.Depth = 0;
            this.btn_billAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_billAdd.HighEmphasis = true;
            this.btn_billAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btn_billAdd.Icon")));
            this.btn_billAdd.Location = new System.Drawing.Point(556, 367);
            this.btn_billAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_billAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_billAdd.Name = "btn_billAdd";
            this.btn_billAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_billAdd.Size = new System.Drawing.Size(158, 36);
            this.btn_billAdd.TabIndex = 1;
            this.btn_billAdd.Text = "Thêm Sách";
            this.btn_billAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_billAdd.UseAccentColor = false;
            this.btn_billAdd.UseVisualStyleBackColor = true;
            this.btn_billAdd.Click += new System.EventHandler(this.btn_billAdd_Click);
            // 
            // txb_billName
            // 
            this.txb_billName.AnimateReadOnly = false;
            this.txb_billName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_billName.Depth = 0;
            this.txb_billName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_billName.LeadingIcon = null;
            this.txb_billName.Location = new System.Drawing.Point(-3, 32);
            this.txb_billName.MaxLength = 50;
            this.txb_billName.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_billName.Multiline = false;
            this.txb_billName.Name = "txb_billName";
            this.txb_billName.Size = new System.Drawing.Size(247, 50);
            this.txb_billName.TabIndex = 2;
            this.txb_billName.Text = "";
            this.txb_billName.TrailingIcon = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(68, 23);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Tên Sách";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txb_billName);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(87, 117);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(244, 86);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txb_billAuth);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Location = new System.Drawing.Point(453, 121);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(261, 90);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // txb_billAuth
            // 
            this.txb_billAuth.AnimateReadOnly = false;
            this.txb_billAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_billAuth.Depth = 0;
            this.txb_billAuth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_billAuth.LeadingIcon = null;
            this.txb_billAuth.Location = new System.Drawing.Point(-3, 32);
            this.txb_billAuth.MaxLength = 50;
            this.txb_billAuth.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_billAuth.Multiline = false;
            this.txb_billAuth.Name = "txb_billAuth";
            this.txb_billAuth.Size = new System.Drawing.Size(261, 50);
            this.txb_billAuth.TabIndex = 2;
            this.txb_billAuth.Text = "";
            this.txb_billAuth.TrailingIcon = null;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(0, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(52, 23);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Tác giả";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.txb_billCost);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel3.Location = new System.Drawing.Point(87, 246);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(244, 89);
            this.bunifuPanel3.TabIndex = 5;
            // 
            // txb_billCost
            // 
            this.txb_billCost.AnimateReadOnly = false;
            this.txb_billCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_billCost.Depth = 0;
            this.txb_billCost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_billCost.LeadingIcon = null;
            this.txb_billCost.Location = new System.Drawing.Point(-3, 32);
            this.txb_billCost.MaxLength = 50;
            this.txb_billCost.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_billCost.Multiline = false;
            this.txb_billCost.Name = "txb_billCost";
            this.txb_billCost.Size = new System.Drawing.Size(247, 50);
            this.txb_billCost.TabIndex = 2;
            this.txb_billCost.Text = "";
            this.txb_billCost.TrailingIcon = null;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(0, 3);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(62, 23);
            this.bunifuLabel3.TabIndex = 3;
            this.bunifuLabel3.Text = "Đơn Giá";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.txb_billAmount);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel4.Location = new System.Drawing.Point(453, 246);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(261, 89);
            this.bunifuPanel4.TabIndex = 6;
            // 
            // txb_billAmount
            // 
            this.txb_billAmount.AnimateReadOnly = false;
            this.txb_billAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_billAmount.Depth = 0;
            this.txb_billAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_billAmount.LeadingIcon = null;
            this.txb_billAmount.Location = new System.Drawing.Point(-3, 32);
            this.txb_billAmount.MaxLength = 50;
            this.txb_billAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_billAmount.Multiline = false;
            this.txb_billAmount.Name = "txb_billAmount";
            this.txb_billAmount.Size = new System.Drawing.Size(264, 50);
            this.txb_billAmount.TabIndex = 2;
            this.txb_billAmount.Text = "";
            this.txb_billAmount.TrailingIcon = null;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(0, 3);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(72, 23);
            this.bunifuLabel4.TabIndex = 3;
            this.bunifuLabel4.Text = "Số Lượng";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(87, 81);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(107, 23);
            this.bunifuLabel5.TabIndex = 7;
            this.bunifuLabel5.Text = "Số Lượng Tồn";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txb_RemainAmount
            // 
            this.txb_RemainAmount.AnimateReadOnly = false;
            this.txb_RemainAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_RemainAmount.Depth = 0;
            this.txb_RemainAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_RemainAmount.LeadingIcon = null;
            this.txb_RemainAmount.Location = new System.Drawing.Point(200, 67);
            this.txb_RemainAmount.MaxLength = 50;
            this.txb_RemainAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_RemainAmount.Multiline = false;
            this.txb_RemainAmount.Name = "txb_RemainAmount";
            this.txb_RemainAmount.ReadOnly = true;
            this.txb_RemainAmount.Size = new System.Drawing.Size(100, 50);
            this.txb_RemainAmount.TabIndex = 8;
            this.txb_RemainAmount.Text = "";
            this.txb_RemainAmount.TrailingIcon = null;
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_RemainAmount);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btn_billAdd);
            this.Name = "FrmBill";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBill";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_billAdd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        public MaterialSkin.Controls.MaterialTextBox txb_billName;
        public MaterialSkin.Controls.MaterialTextBox txb_billAuth;
        public MaterialSkin.Controls.MaterialTextBox txb_billCost;
        public MaterialSkin.Controls.MaterialTextBox txb_billAmount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        public MaterialSkin.Controls.MaterialTextBox txb_RemainAmount;
    }
}