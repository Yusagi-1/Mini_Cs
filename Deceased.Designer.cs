namespace Mini_Cs
{
    partial class Deceased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deceased));
            txtName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cbGender = new MaterialSkin.Controls.MaterialComboBox();
            cbCivilStatus = new MaterialSkin.Controls.MaterialComboBox();
            dpBirthdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            txtPwd = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dpDateofDeath = new Bunifu.UI.WinForms.BunifuDatePicker();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnProceed = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AllowPromptAsInput = true;
            txtName.AnimateReadOnly = false;
            txtName.AsciiOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.BeepOnError = false;
            txtName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HidePromptOnLeave = false;
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.InsertKeyMode = InsertKeyMode.Default;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(62, 46);
            txtName.Mask = "";
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.PromptChar = '_';
            txtName.ReadOnly = false;
            txtName.RejectInputOnFirstFailure = false;
            txtName.ResetOnPrompt = true;
            txtName.ResetOnSpace = true;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(250, 48);
            txtName.SkipLiterals = true;
            txtName.TabIndex = 0;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.ValidatingType = null;
            txtName.Click += txtName_Click;
            // 
            // txtAddress
            // 
            txtAddress.AllowPromptAsInput = true;
            txtAddress.AnimateReadOnly = false;
            txtAddress.AsciiOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.BeepOnError = false;
            txtAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HidePromptOnLeave = false;
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.InsertKeyMode = InsertKeyMode.Default;
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(62, 121);
            txtAddress.Mask = "";
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.PromptChar = '_';
            txtAddress.ReadOnly = false;
            txtAddress.RejectInputOnFirstFailure = false;
            txtAddress.ResetOnPrompt = true;
            txtAddress.ResetOnSpace = true;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(598, 48);
            txtAddress.SkipLiterals = true;
            txtAddress.TabIndex = 1;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            txtAddress.ValidatingType = null;
            txtAddress.Click += txtAddress_Click;
            // 
            // cbGender
            // 
            cbGender.AutoResize = false;
            cbGender.BackColor = Color.FromArgb(255, 255, 255);
            cbGender.Depth = 0;
            cbGender.DrawMode = DrawMode.OwnerDrawVariable;
            cbGender.DropDownHeight = 174;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.DropDownWidth = 121;
            cbGender.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbGender.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Hint = "Gender";
            cbGender.IntegralHeight = false;
            cbGender.ItemHeight = 43;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(62, 203);
            cbGender.MaxDropDownItems = 4;
            cbGender.MouseState = MaterialSkin.MouseState.OUT;
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(250, 49);
            cbGender.StartIndex = 0;
            cbGender.TabIndex = 2;
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            // 
            // cbCivilStatus
            // 
            cbCivilStatus.AutoResize = false;
            cbCivilStatus.BackColor = Color.FromArgb(255, 255, 255);
            cbCivilStatus.Depth = 0;
            cbCivilStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cbCivilStatus.DropDownHeight = 174;
            cbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCivilStatus.DropDownWidth = 121;
            cbCivilStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCivilStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCivilStatus.FormattingEnabled = true;
            cbCivilStatus.Hint = "Civil Status";
            cbCivilStatus.IntegralHeight = false;
            cbCivilStatus.ItemHeight = 43;
            cbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Divorce", "Widow" });
            cbCivilStatus.Location = new Point(62, 285);
            cbCivilStatus.MaxDropDownItems = 4;
            cbCivilStatus.MouseState = MaterialSkin.MouseState.OUT;
            cbCivilStatus.Name = "cbCivilStatus";
            cbCivilStatus.Size = new Size(250, 49);
            cbCivilStatus.StartIndex = 0;
            cbCivilStatus.TabIndex = 3;
            cbCivilStatus.SelectedIndexChanged += cbCivilStatus_SelectedIndexChanged;
            // 
            // dpBirthdate
            // 
            dpBirthdate.BackColor = Color.Transparent;
            dpBirthdate.BorderColor = Color.Silver;
            dpBirthdate.BorderRadius = 1;
            dpBirthdate.Color = Color.Silver;
            dpBirthdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpBirthdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpBirthdate.DisabledColor = Color.Gray;
            dpBirthdate.DisplayWeekNumbers = false;
            dpBirthdate.DPHeight = 0;
            dpBirthdate.DropDownAlign = LeftRightAlignment.Right;
            dpBirthdate.FillDatePicker = false;
            dpBirthdate.Font = new Font("Segoe UI", 9F);
            dpBirthdate.ForeColor = Color.Black;
            dpBirthdate.Icon = (Image)resources.GetObject("dpBirthdate.Icon");
            dpBirthdate.IconColor = Color.Gray;
            dpBirthdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpBirthdate.LeftTextMargin = 5;
            dpBirthdate.Location = new Point(410, 220);
            dpBirthdate.MinimumSize = new Size(0, 32);
            dpBirthdate.Name = "dpBirthdate";
            dpBirthdate.Size = new Size(250, 32);
            dpBirthdate.TabIndex = 4;
            dpBirthdate.ValueChanged += dpBirthdate_ValueChanged;
            // 
            // txtPwd
            // 
            txtPwd.AllowPromptAsInput = true;
            txtPwd.AnimateReadOnly = false;
            txtPwd.AsciiOnly = false;
            txtPwd.BackgroundImageLayout = ImageLayout.None;
            txtPwd.BeepOnError = false;
            txtPwd.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPwd.Depth = 0;
            txtPwd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPwd.HidePromptOnLeave = false;
            txtPwd.HideSelection = true;
            txtPwd.Hint = "OSCA/PWD ID NO.";
            txtPwd.InsertKeyMode = InsertKeyMode.Default;
            txtPwd.LeadingIcon = null;
            txtPwd.Location = new Point(410, 46);
            txtPwd.Mask = "";
            txtPwd.MaxLength = 32767;
            txtPwd.MouseState = MaterialSkin.MouseState.OUT;
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '\0';
            txtPwd.PrefixSuffixText = null;
            txtPwd.PromptChar = '_';
            txtPwd.ReadOnly = false;
            txtPwd.RejectInputOnFirstFailure = false;
            txtPwd.ResetOnPrompt = true;
            txtPwd.ResetOnSpace = true;
            txtPwd.RightToLeft = RightToLeft.No;
            txtPwd.SelectedText = "";
            txtPwd.SelectionLength = 0;
            txtPwd.SelectionStart = 0;
            txtPwd.ShortcutsEnabled = true;
            txtPwd.Size = new Size(250, 48);
            txtPwd.SkipLiterals = true;
            txtPwd.TabIndex = 5;
            txtPwd.TabStop = false;
            txtPwd.TextAlign = HorizontalAlignment.Left;
            txtPwd.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPwd.TrailingIcon = null;
            txtPwd.UseSystemPasswordChar = false;
            txtPwd.ValidatingType = null;
            txtPwd.Click += txtPwd_Click;
            // 
            // dpDateofDeath
            // 
            dpDateofDeath.BackColor = Color.Transparent;
            dpDateofDeath.BorderColor = Color.Silver;
            dpDateofDeath.BorderRadius = 1;
            dpDateofDeath.Color = Color.Silver;
            dpDateofDeath.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpDateofDeath.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpDateofDeath.DisabledColor = Color.Gray;
            dpDateofDeath.DisplayWeekNumbers = false;
            dpDateofDeath.DPHeight = 0;
            dpDateofDeath.DropDownAlign = LeftRightAlignment.Right;
            dpDateofDeath.FillDatePicker = false;
            dpDateofDeath.Font = new Font("Segoe UI", 9F);
            dpDateofDeath.ForeColor = Color.Black;
            dpDateofDeath.Icon = (Image)resources.GetObject("dpDateofDeath.Icon");
            dpDateofDeath.IconColor = Color.Gray;
            dpDateofDeath.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpDateofDeath.LeftTextMargin = 5;
            dpDateofDeath.Location = new Point(410, 302);
            dpDateofDeath.MinimumSize = new Size(0, 32);
            dpDateofDeath.Name = "dpDateofDeath";
            dpDateofDeath.Size = new Size(250, 32);
            dpDateofDeath.TabIndex = 6;
            dpDateofDeath.ValueChanged += dpDateofDeath_ValueChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(410, 198);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(65, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Birthdate";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(410, 280);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(99, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Date of Death";
            // 
            // btnProceed
            // 
            btnProceed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProceed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProceed.Depth = 0;
            btnProceed.HighEmphasis = true;
            btnProceed.Icon = null;
            btnProceed.Location = new Point(917, 409);
            btnProceed.Margin = new Padding(4, 6, 4, 6);
            btnProceed.MouseState = MaterialSkin.MouseState.HOVER;
            btnProceed.Name = "btnProceed";
            btnProceed.NoAccentTextColor = Color.Empty;
            btnProceed.Size = new Size(86, 36);
            btnProceed.TabIndex = 9;
            btnProceed.Text = "Proceed";
            btnProceed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProceed.UseAccentColor = false;
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // Deceased
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 450);
            Controls.Add(btnProceed);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(dpDateofDeath);
            Controls.Add(txtPwd);
            Controls.Add(dpBirthdate);
            Controls.Add(cbCivilStatus);
            Controls.Add(cbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deceased";
            Text = "Deceased";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddress;
        private MaterialSkin.Controls.MaterialComboBox cbGender;
        private MaterialSkin.Controls.MaterialComboBox cbCivilStatus;
        private Bunifu.UI.WinForms.BunifuDatePicker dpBirthdate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPwd;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDateofDeath;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnProceed;
    }
}