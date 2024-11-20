namespace Mini_Cs
{
    partial class FrmAddEditClient
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
            txtFullName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtContactNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cmbCreatedBy = new MaterialSkin.Controls.MaterialComboBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            SuspendLayout();
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
            txtFullName.Hint = "Full Name";
            txtFullName.InsertKeyMode = InsertKeyMode.Default;
            txtFullName.LeadingIcon = null;
            txtFullName.Location = new Point(48, 48);
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
            txtFullName.Size = new Size(250, 48);
            txtFullName.SkipLiterals = true;
            txtFullName.TabIndex = 0;
            txtFullName.TabStop = false;
            txtFullName.TextAlign = HorizontalAlignment.Left;
            txtFullName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtFullName.TrailingIcon = null;
            txtFullName.UseSystemPasswordChar = false;
            txtFullName.ValidatingType = null;
            txtFullName.Click += txtFamilyName_Click;
            // 
            // txtContactNumber
            // 
            txtContactNumber.AllowPromptAsInput = true;
            txtContactNumber.AnimateReadOnly = false;
            txtContactNumber.AsciiOnly = false;
            txtContactNumber.BackgroundImageLayout = ImageLayout.None;
            txtContactNumber.BeepOnError = false;
            txtContactNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtContactNumber.Depth = 0;
            txtContactNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContactNumber.HidePromptOnLeave = false;
            txtContactNumber.HideSelection = true;
            txtContactNumber.Hint = "Contact Number";
            txtContactNumber.InsertKeyMode = InsertKeyMode.Default;
            txtContactNumber.LeadingIcon = null;
            txtContactNumber.Location = new Point(48, 121);
            txtContactNumber.Mask = "";
            txtContactNumber.MaxLength = 32767;
            txtContactNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PasswordChar = '\0';
            txtContactNumber.PrefixSuffixText = null;
            txtContactNumber.PromptChar = '_';
            txtContactNumber.ReadOnly = false;
            txtContactNumber.RejectInputOnFirstFailure = false;
            txtContactNumber.ResetOnPrompt = true;
            txtContactNumber.ResetOnSpace = true;
            txtContactNumber.RightToLeft = RightToLeft.No;
            txtContactNumber.SelectedText = "";
            txtContactNumber.SelectionLength = 0;
            txtContactNumber.SelectionStart = 0;
            txtContactNumber.ShortcutsEnabled = true;
            txtContactNumber.Size = new Size(250, 48);
            txtContactNumber.SkipLiterals = true;
            txtContactNumber.TabIndex = 1;
            txtContactNumber.TabStop = false;
            txtContactNumber.TextAlign = HorizontalAlignment.Left;
            txtContactNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtContactNumber.TrailingIcon = null;
            txtContactNumber.UseSystemPasswordChar = false;
            txtContactNumber.ValidatingType = null;
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
            txtAddress.Location = new Point(48, 195);
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
            txtAddress.Size = new Size(525, 48);
            txtAddress.SkipLiterals = true;
            txtAddress.TabIndex = 2;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            txtAddress.ValidatingType = null;
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
            cmbCreatedBy.Location = new Point(332, 48);
            cmbCreatedBy.MaxDropDownItems = 4;
            cmbCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            cmbCreatedBy.Name = "cmbCreatedBy";
            cmbCreatedBy.Size = new Size(241, 49);
            cmbCreatedBy.StartIndex = 0;
            cmbCreatedBy.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(143, 348);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 5;
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
            btnCancel.Location = new Point(422, 348);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.AllowPromptAsInput = true;
            txtEmail.AnimateReadOnly = false;
            txtEmail.AsciiOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.BeepOnError = false;
            txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HidePromptOnLeave = false;
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.InsertKeyMode = InsertKeyMode.Default;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(332, 121);
            txtEmail.Mask = "";
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.PromptChar = '_';
            txtEmail.ReadOnly = false;
            txtEmail.RejectInputOnFirstFailure = false;
            txtEmail.ResetOnPrompt = true;
            txtEmail.ResetOnSpace = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(241, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 7;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            txtEmail.Click += txtEmail_Click;
            // 
            // txtNotes
            // 
            txtNotes.AnimateReadOnly = false;
            txtNotes.BackgroundImageLayout = ImageLayout.None;
            txtNotes.CharacterCasing = CharacterCasing.Normal;
            txtNotes.Depth = 0;
            txtNotes.HideSelection = true;
            txtNotes.Hint = "Notes";
            txtNotes.Location = new Point(48, 254);
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
            txtNotes.Size = new Size(525, 72);
            txtNotes.TabIndex = 8;
            txtNotes.TabStop = false;
            txtNotes.TextAlign = HorizontalAlignment.Left;
            txtNotes.UseSystemPasswordChar = false;
            txtNotes.Click += txtNotes_Click;
            // 
            // FrmAddEditClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 437);
            Controls.Add(txtNotes);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCreatedBy);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNumber);
            Controls.Add(txtFullName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddEditClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtFullName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContactNumber;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddress;
        private MaterialSkin.Controls.MaterialComboBox cmbCreatedBy;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmail;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNotes;
        private MaterialSkin.Controls.MaterialCheckbox cbFreeChapel;
    }
}