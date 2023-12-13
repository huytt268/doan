namespace WindowsFormsApp1.GUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txb_UserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txb_Password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Cb_Remember = new MaterialSkin.Controls.MaterialCheckbox();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_LostPass = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_Register = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_User = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_UserName
            // 
            this.txb_UserName.AllowPromptAsInput = true;
            this.txb_UserName.AnimateReadOnly = false;
            this.txb_UserName.AsciiOnly = false;
            this.txb_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_UserName.BeepOnError = false;
            this.txb_UserName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_UserName.Depth = 0;
            this.txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_UserName.HidePromptOnLeave = false;
            this.txb_UserName.HideSelection = true;
            this.txb_UserName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txb_UserName.LeadingIcon = null;
            this.txb_UserName.Location = new System.Drawing.Point(4, 0);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserName.Mask = "";
            this.txb_UserName.MaxLength = 32767;
            this.txb_UserName.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.PasswordChar = '\0';
            this.txb_UserName.PrefixSuffixText = null;
            this.txb_UserName.PromptChar = '_';
            this.txb_UserName.ReadOnly = false;
            this.txb_UserName.RejectInputOnFirstFailure = false;
            this.txb_UserName.ResetOnPrompt = true;
            this.txb_UserName.ResetOnSpace = true;
            this.txb_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_UserName.SelectedText = "";
            this.txb_UserName.SelectionLength = 0;
            this.txb_UserName.SelectionStart = 0;
            this.txb_UserName.ShortcutsEnabled = true;
            this.txb_UserName.Size = new System.Drawing.Size(559, 48);
            this.txb_UserName.SkipLiterals = true;
            this.txb_UserName.TabIndex = 0;
            this.txb_UserName.TabStop = false;
            this.txb_UserName.Text = "quanhao";
            this.txb_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_UserName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_UserName.TrailingIcon = null;
            this.txb_UserName.UseSystemPasswordChar = false;
            this.txb_UserName.ValidatingType = null;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txb_UserName);
            this.bunifuPanel1.Location = new System.Drawing.Point(49, 79);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(567, 62);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txb_Password);
            this.bunifuPanel2.Location = new System.Drawing.Point(49, 172);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(567, 54);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // txb_Password
            // 
            this.txb_Password.AllowPromptAsInput = true;
            this.txb_Password.AnimateReadOnly = false;
            this.txb_Password.AsciiOnly = false;
            this.txb_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_Password.BeepOnError = false;
            this.txb_Password.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_Password.Depth = 0;
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txb_Password.HidePromptOnLeave = false;
            this.txb_Password.HideSelection = true;
            this.txb_Password.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txb_Password.LeadingIcon = null;
            this.txb_Password.Location = new System.Drawing.Point(4, 0);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Mask = "";
            this.txb_Password.MaxLength = 32767;
            this.txb_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '\0';
            this.txb_Password.PrefixSuffixText = null;
            this.txb_Password.PromptChar = '_';
            this.txb_Password.ReadOnly = false;
            this.txb_Password.RejectInputOnFirstFailure = false;
            this.txb_Password.ResetOnPrompt = true;
            this.txb_Password.ResetOnSpace = true;
            this.txb_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_Password.SelectedText = "";
            this.txb_Password.SelectionLength = 0;
            this.txb_Password.SelectionStart = 0;
            this.txb_Password.ShortcutsEnabled = true;
            this.txb_Password.Size = new System.Drawing.Size(563, 48);
            this.txb_Password.SkipLiterals = true;
            this.txb_Password.TabIndex = 0;
            this.txb_Password.TabStop = false;
            this.txb_Password.Text = "22520584";
            this.txb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_Password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txb_Password.TrailingIcon = null;
            this.txb_Password.UseSystemPasswordChar = false;
            this.txb_Password.ValidatingType = null;
            // 
            // Cb_Remember
            // 
            this.Cb_Remember.Depth = 0;
            this.Cb_Remember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cb_Remember.Location = new System.Drawing.Point(49, 250);
            this.Cb_Remember.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_Remember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Cb_Remember.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cb_Remember.Name = "Cb_Remember";
            this.Cb_Remember.ReadOnly = false;
            this.Cb_Remember.Ripple = true;
            this.Cb_Remember.Size = new System.Drawing.Size(195, 42);
            this.Cb_Remember.TabIndex = 4;
            this.Cb_Remember.Text = "Nhớ mật khẩu";
            this.Cb_Remember.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = false;
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(49, 318);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(563, 44);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(67, 16);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(567, 1);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuImageButton3);
            this.bunifuPanel3.Location = new System.Drawing.Point(4, 79);
            this.bunifuPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(669, 126);
            this.bunifuPanel3.TabIndex = 9;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 0;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(132, 122);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(133, 123);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(268, 2);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(133, 123);
            this.bunifuImageButton3.TabIndex = 0;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 0;
            this.bunifuImageButton3.ZoomSpeed = 10;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.btn_LostPass);
            this.bunifuPanel4.Controls.Add(this.lb_Register);
            this.bunifuPanel4.Controls.Add(this.materialDivider1);
            this.bunifuPanel4.Location = new System.Drawing.Point(4, 574);
            this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(669, 114);
            this.bunifuPanel4.TabIndex = 10;
            // 
            // btn_LostPass
            // 
            this.btn_LostPass.AllowParentOverrides = false;
            this.btn_LostPass.AutoEllipsis = false;
            this.btn_LostPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_LostPass.CursorType = System.Windows.Forms.Cursors.Default;
            this.btn_LostPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LostPass.Location = new System.Drawing.Point(184, 49);
            this.btn_LostPass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LostPass.Name = "btn_LostPass";
            this.btn_LostPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_LostPass.Size = new System.Drawing.Size(163, 29);
            this.btn_LostPass.TabIndex = 9;
            this.btn_LostPass.Text = "Quên mật khẩu?";
            this.btn_LostPass.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.btn_LostPass.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_Register
            // 
            this.lb_Register.AllowParentOverrides = false;
            this.lb_Register.AutoEllipsis = false;
            this.lb_Register.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Register.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_Register.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Register.Location = new System.Drawing.Point(355, 49);
            this.lb_Register.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Register.Size = new System.Drawing.Size(79, 29);
            this.lb_Register.TabIndex = 8;
            this.lb_Register.Text = "Đăng ký";
            this.lb_Register.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_Register.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 3;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel5.Controls.Add(this.lb_User);
            this.bunifuPanel5.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel5.Controls.Add(this.btn_Login);
            this.bunifuPanel5.Controls.Add(this.bunifuPanel1);
            this.bunifuPanel5.Controls.Add(this.Cb_Remember);
            this.bunifuPanel5.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel5.Location = new System.Drawing.Point(4, 204);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(669, 369);
            this.bunifuPanel5.TabIndex = 11;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(53, 145);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(81, 24);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "Mật khẩu";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_User
            // 
            this.lb_User.AllowParentOverrides = false;
            this.lb_User.AutoEllipsis = false;
            this.lb_User.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_User.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_User.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(53, 48);
            this.lb_User.Margin = new System.Windows.Forms.Padding(4);
            this.lb_User.Name = "lb_User";
            this.lb_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_User.Size = new System.Drawing.Size(125, 24);
            this.lb_User.TabIndex = 7;
            this.lb_User.Text = "Tên đăng nhập";
            this.lb_User.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_User.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(268, 7);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(118, 32);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Book Store";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 692);
            this.Controls.Add(this.bunifuPanel5);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuPanel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txb_UserName;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txb_Password;
        private MaterialSkin.Controls.MaterialCheckbox Cb_Remember;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuLabel lb_Register;
        private Bunifu.UI.WinForms.BunifuLabel btn_LostPass;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lb_User;
    }
}