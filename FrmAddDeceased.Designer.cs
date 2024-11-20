namespace Mini_Cs
{
    partial class FrmAddDeceased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDeceased));
            txtDeceasedName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtAge = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dtpBirthDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            dtpDeathDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            txtGraveAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cmbCreatedBy = new MaterialSkin.Controls.MaterialComboBox();
            cmbClientID = new MaterialSkin.Controls.MaterialComboBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            cmbRelationship = new MaterialSkin.Controls.MaterialComboBox();
            txtFullName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // txtDeceasedName
            // 
            txtDeceasedName.AllowPromptAsInput = true;
            txtDeceasedName.AnimateReadOnly = false;
            txtDeceasedName.AsciiOnly = false;
            txtDeceasedName.BackgroundImageLayout = ImageLayout.None;
            txtDeceasedName.BeepOnError = false;
            txtDeceasedName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDeceasedName.Depth = 0;
            txtDeceasedName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDeceasedName.HidePromptOnLeave = false;
            txtDeceasedName.HideSelection = true;
            txtDeceasedName.Hint = "Deceased Name";
            txtDeceasedName.InsertKeyMode = InsertKeyMode.Default;
            txtDeceasedName.LeadingIcon = null;
            txtDeceasedName.Location = new Point(58, 48);
            txtDeceasedName.Mask = "";
            txtDeceasedName.MaxLength = 32767;
            txtDeceasedName.MouseState = MaterialSkin.MouseState.OUT;
            txtDeceasedName.Name = "txtDeceasedName";
            txtDeceasedName.PasswordChar = '\0';
            txtDeceasedName.PrefixSuffixText = null;
            txtDeceasedName.PromptChar = '_';
            txtDeceasedName.ReadOnly = false;
            txtDeceasedName.RejectInputOnFirstFailure = false;
            txtDeceasedName.ResetOnPrompt = true;
            txtDeceasedName.ResetOnSpace = true;
            txtDeceasedName.RightToLeft = RightToLeft.No;
            txtDeceasedName.SelectedText = "";
            txtDeceasedName.SelectionLength = 0;
            txtDeceasedName.SelectionStart = 0;
            txtDeceasedName.ShortcutsEnabled = true;
            txtDeceasedName.Size = new Size(250, 48);
            txtDeceasedName.SkipLiterals = true;
            txtDeceasedName.TabIndex = 0;
            txtDeceasedName.TabStop = false;
            txtDeceasedName.TextAlign = HorizontalAlignment.Left;
            txtDeceasedName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDeceasedName.TrailingIcon = null;
            txtDeceasedName.UseSystemPasswordChar = false;
            txtDeceasedName.ValidatingType = null;
            // 
            // txtAge
            // 
            txtAge.AllowPromptAsInput = true;
            txtAge.AnimateReadOnly = false;
            txtAge.AsciiOnly = false;
            txtAge.BackgroundImageLayout = ImageLayout.None;
            txtAge.BeepOnError = false;
            txtAge.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAge.Depth = 0;
            txtAge.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAge.HidePromptOnLeave = false;
            txtAge.HideSelection = true;
            txtAge.Hint = "Age";
            txtAge.InsertKeyMode = InsertKeyMode.Default;
            txtAge.LeadingIcon = null;
            txtAge.Location = new Point(58, 112);
            txtAge.Mask = "";
            txtAge.MaxLength = 32767;
            txtAge.MouseState = MaterialSkin.MouseState.OUT;
            txtAge.Name = "txtAge";
            txtAge.PasswordChar = '\0';
            txtAge.PrefixSuffixText = null;
            txtAge.PromptChar = '_';
            txtAge.ReadOnly = false;
            txtAge.RejectInputOnFirstFailure = false;
            txtAge.ResetOnPrompt = true;
            txtAge.ResetOnSpace = true;
            txtAge.RightToLeft = RightToLeft.No;
            txtAge.SelectedText = "";
            txtAge.SelectionLength = 0;
            txtAge.SelectionStart = 0;
            txtAge.ShortcutsEnabled = true;
            txtAge.Size = new Size(250, 48);
            txtAge.SkipLiterals = true;
            txtAge.TabIndex = 1;
            txtAge.TabStop = false;
            txtAge.TextAlign = HorizontalAlignment.Left;
            txtAge.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAge.TrailingIcon = null;
            txtAge.UseSystemPasswordChar = false;
            txtAge.ValidatingType = null;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.BackColor = Color.Transparent;
            dtpBirthDate.BorderColor = Color.Silver;
            dtpBirthDate.BorderRadius = 1;
            dtpBirthDate.Color = Color.Silver;
            dtpBirthDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dtpBirthDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dtpBirthDate.DisabledColor = Color.Gray;
            dtpBirthDate.DisplayWeekNumbers = false;
            dtpBirthDate.DPHeight = 0;
            dtpBirthDate.DropDownAlign = LeftRightAlignment.Right;
            dtpBirthDate.FillDatePicker = false;
            dtpBirthDate.Font = new Font("Segoe UI", 9F);
            dtpBirthDate.ForeColor = Color.Black;
            dtpBirthDate.Icon = (Image)resources.GetObject("dtpBirthDate.Icon");
            dtpBirthDate.IconColor = Color.Gray;
            dtpBirthDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dtpBirthDate.LeftTextMargin = 5;
            dtpBirthDate.Location = new Point(362, 64);
            dtpBirthDate.MinimumSize = new Size(0, 32);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(220, 32);
            dtpBirthDate.TabIndex = 2;
            // 
            // dtpDeathDate
            // 
            dtpDeathDate.BackColor = Color.Transparent;
            dtpDeathDate.BorderColor = Color.Silver;
            dtpDeathDate.BorderRadius = 1;
            dtpDeathDate.Color = Color.Silver;
            dtpDeathDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dtpDeathDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dtpDeathDate.DisabledColor = Color.Gray;
            dtpDeathDate.DisplayWeekNumbers = false;
            dtpDeathDate.DPHeight = 0;
            dtpDeathDate.DropDownAlign = LeftRightAlignment.Right;
            dtpDeathDate.FillDatePicker = false;
            dtpDeathDate.Font = new Font("Segoe UI", 9F);
            dtpDeathDate.ForeColor = Color.Black;
            dtpDeathDate.Icon = (Image)resources.GetObject("dtpDeathDate.Icon");
            dtpDeathDate.IconColor = Color.Gray;
            dtpDeathDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dtpDeathDate.LeftTextMargin = 5;
            dtpDeathDate.Location = new Point(362, 128);
            dtpDeathDate.MinimumSize = new Size(0, 32);
            dtpDeathDate.Name = "dtpDeathDate";
            dtpDeathDate.Size = new Size(220, 32);
            dtpDeathDate.TabIndex = 3;
            // 
            // txtGraveAddress
            // 
            txtGraveAddress.AnimateReadOnly = false;
            txtGraveAddress.BackgroundImageLayout = ImageLayout.None;
            txtGraveAddress.CharacterCasing = CharacterCasing.Normal;
            txtGraveAddress.Depth = 0;
            txtGraveAddress.HideSelection = true;
            txtGraveAddress.Hint = "Grave Address";
            txtGraveAddress.Location = new Point(58, 310);
            txtGraveAddress.MaxLength = 32767;
            txtGraveAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtGraveAddress.Name = "txtGraveAddress";
            txtGraveAddress.PasswordChar = '\0';
            txtGraveAddress.ReadOnly = false;
            txtGraveAddress.ScrollBars = ScrollBars.None;
            txtGraveAddress.SelectedText = "";
            txtGraveAddress.SelectionLength = 0;
            txtGraveAddress.SelectionStart = 0;
            txtGraveAddress.ShortcutsEnabled = true;
            txtGraveAddress.Size = new Size(250, 66);
            txtGraveAddress.TabIndex = 4;
            txtGraveAddress.TabStop = false;
            txtGraveAddress.TextAlign = HorizontalAlignment.Left;
            txtGraveAddress.UseSystemPasswordChar = false;
            // 
            // txtNotes
            // 
            txtNotes.AnimateReadOnly = false;
            txtNotes.BackgroundImageLayout = ImageLayout.None;
            txtNotes.CharacterCasing = CharacterCasing.Normal;
            txtNotes.Depth = 0;
            txtNotes.HideSelection = true;
            txtNotes.Hint = "Notes";
            txtNotes.Location = new Point(362, 310);
            txtNotes.MaxLength = 32767;
            txtNotes.MouseState = MaterialSkin.MouseState.OUT;
            txtNotes.Name = "txtNotes";
            txtNotes.PasswordChar = '\0';
            txtNotes.ReadOnly = false;
            txtNotes.ScrollBars = ScrollBars.None;
            txtNotes.SelectedText = "";
            txtNotes.SelectionLength = 0;
            txtNotes.SelectionStart = 0;
            txtNotes.ShortcutsEnabled = true;
            txtNotes.Size = new Size(250, 66);
            txtNotes.TabIndex = 5;
            txtNotes.TabStop = false;
            txtNotes.TextAlign = HorizontalAlignment.Left;
            txtNotes.UseSystemPasswordChar = false;
            // 
            // cmbCreatedBy
            // 
            cmbCreatedBy.AutoResize = false;
            cmbCreatedBy.BackColor = Color.FromArgb(255, 255, 255);
            cmbCreatedBy.Depth = 0;
            cmbCreatedBy.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCreatedBy.DropDownHeight = 174;
            cmbCreatedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCreatedBy.DropDownWidth = 121;
            cmbCreatedBy.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCreatedBy.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCreatedBy.FormattingEnabled = true;
            cmbCreatedBy.IntegralHeight = false;
            cmbCreatedBy.ItemHeight = 43;
            cmbCreatedBy.Location = new Point(362, 247);
            cmbCreatedBy.MaxDropDownItems = 4;
            cmbCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            cmbCreatedBy.Name = "cmbCreatedBy";
            cmbCreatedBy.Size = new Size(250, 49);
            cmbCreatedBy.StartIndex = 0;
            cmbCreatedBy.TabIndex = 6;
            // 
            // cmbClientID
            // 
            cmbClientID.AutoResize = false;
            cmbClientID.BackColor = Color.FromArgb(255, 255, 255);
            cmbClientID.Depth = 0;
            cmbClientID.DrawMode = DrawMode.OwnerDrawVariable;
            cmbClientID.DropDownHeight = 174;
            cmbClientID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientID.DropDownWidth = 121;
            cmbClientID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbClientID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbClientID.FormattingEnabled = true;
            cmbClientID.IntegralHeight = false;
            cmbClientID.ItemHeight = 43;
            cmbClientID.Location = new Point(58, 192);
            cmbClientID.MaxDropDownItems = 4;
            cmbClientID.MouseState = MaterialSkin.MouseState.OUT;
            cmbClientID.Name = "cmbClientID";
            cmbClientID.Size = new Size(90, 49);
            cmbClientID.StartIndex = 0;
            cmbClientID.TabIndex = 7;
            cmbClientID.SelectedIndexChanged += cmbClientID_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(135, 399);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(439, 399);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbRelationship
            // 
            cmbRelationship.AutoResize = false;
            cmbRelationship.BackColor = Color.FromArgb(255, 255, 255);
            cmbRelationship.Depth = 0;
            cmbRelationship.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRelationship.DropDownHeight = 174;
            cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRelationship.DropDownWidth = 121;
            cmbRelationship.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRelationship.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRelationship.FormattingEnabled = true;
            cmbRelationship.IntegralHeight = false;
            cmbRelationship.ItemHeight = 43;
            cmbRelationship.Items.AddRange(new object[] { "Parent", "Spouse", "Child", "Other" });
            cmbRelationship.Location = new Point(58, 247);
            cmbRelationship.MaxDropDownItems = 4;
            cmbRelationship.MouseState = MaterialSkin.MouseState.OUT;
            cmbRelationship.Name = "cmbRelationship";
            cmbRelationship.Size = new Size(250, 49);
            cmbRelationship.StartIndex = 0;
            cmbRelationship.TabIndex = 11;
            cmbRelationship.SelectedIndexChanged += cmbRelationship_SelectedIndexChanged;
            // 
            // txtFullName
            // 
            txtFullName.AllowPromptAsInput = true;
            txtFullName.AnimateReadOnly = false;
            txtFullName.AsciiOnly = false;
            txtFullName.BackgroundImageLayout = ImageLayout.None;
            txtFullName.BeepOnError = false;
            txtFullName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtFullName.Depth = 0;
            txtFullName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullName.HidePromptOnLeave = false;
            txtFullName.HideSelection = true;
            txtFullName.InsertKeyMode = InsertKeyMode.Default;
            txtFullName.LeadingIcon = null;
            txtFullName.Location = new Point(154, 192);
            txtFullName.Mask = "";
            txtFullName.MaxLength = 32767;
            txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PrefixSuffixText = null;
            txtFullName.PromptChar = '_';
            txtFullName.ReadOnly = false;
            txtFullName.RejectInputOnFirstFailure = false;
            txtFullName.ResetOnPrompt = true;
            txtFullName.ResetOnSpace = true;
            txtFullName.RightToLeft = RightToLeft.No;
            txtFullName.SelectedText = "";
            txtFullName.SelectionLength = 0;
            txtFullName.SelectionStart = 0;
            txtFullName.ShortcutsEnabled = true;
            txtFullName.Size = new Size(154, 48);
            txtFullName.SkipLiterals = true;
            txtFullName.TabIndex = 12;
            txtFullName.TabStop = false;
            txtFullName.TextAlign = HorizontalAlignment.Left;
            txtFullName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtFullName.TrailingIcon = null;
            txtFullName.UseSystemPasswordChar = false;
            txtFullName.ValidatingType = null;
            txtFullName.Click += txtFullName_Click;
            // 
            // FrmAddDeceased
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(txtFullName);
            Controls.Add(cmbRelationship);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbClientID);
            Controls.Add(cmbCreatedBy);
            Controls.Add(txtNotes);
            Controls.Add(txtGraveAddress);
            Controls.Add(dtpDeathDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtAge);
            Controls.Add(txtDeceasedName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddDeceased";
            Text = "FrmAddDeceased";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtDeceasedName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAge;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpBirthDate;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDeathDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtGraveAddress;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNotes;
        private MaterialSkin.Controls.MaterialComboBox cmbCreatedBy;
        private MaterialSkin.Controls.MaterialComboBox cmbClientID;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialComboBox cmbRelationship;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFullName;
    }
}