namespace Mini_Cs
{
    partial class FrmAddEditService
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
            txtServiceName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            numDuration = new NumericUpDown();
            cmbCreatedBy = new MaterialSkin.Controls.MaterialComboBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cbIncludesChapel = new MaterialSkin.Controls.MaterialCheckbox();
            cbCasket = new MaterialSkin.Controls.MaterialCheckbox();
            cbAircon = new MaterialSkin.Controls.MaterialCheckbox();
            cbEmbalming = new MaterialSkin.Controls.MaterialCheckbox();
            cbPresidential = new MaterialSkin.Controls.MaterialCheckbox();
            cbFreeChapel = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // txtServiceName
            // 
            txtServiceName.AllowPromptAsInput = true;
            txtServiceName.AnimateReadOnly = false;
            txtServiceName.AsciiOnly = false;
            txtServiceName.BackgroundImageLayout = ImageLayout.None;
            txtServiceName.BeepOnError = false;
            txtServiceName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtServiceName.Depth = 0;
            txtServiceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtServiceName.HidePromptOnLeave = false;
            txtServiceName.HideSelection = true;
            txtServiceName.Hint = "Service Name";
            txtServiceName.InsertKeyMode = InsertKeyMode.Default;
            txtServiceName.LeadingIcon = null;
            txtServiceName.Location = new Point(35, 57);
            txtServiceName.Mask = "";
            txtServiceName.MaxLength = 32767;
            txtServiceName.MouseState = MaterialSkin.MouseState.OUT;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.PasswordChar = '\0';
            txtServiceName.PrefixSuffixText = null;
            txtServiceName.PromptChar = '_';
            txtServiceName.ReadOnly = false;
            txtServiceName.RejectInputOnFirstFailure = false;
            txtServiceName.ResetOnPrompt = true;
            txtServiceName.ResetOnSpace = true;
            txtServiceName.RightToLeft = RightToLeft.No;
            txtServiceName.SelectedText = "";
            txtServiceName.SelectionLength = 0;
            txtServiceName.SelectionStart = 0;
            txtServiceName.ShortcutsEnabled = true;
            txtServiceName.Size = new Size(250, 48);
            txtServiceName.SkipLiterals = true;
            txtServiceName.TabIndex = 0;
            txtServiceName.TabStop = false;
            txtServiceName.TextAlign = HorizontalAlignment.Left;
            txtServiceName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtServiceName.TrailingIcon = null;
            txtServiceName.UseSystemPasswordChar = false;
            txtServiceName.ValidatingType = null;
            txtServiceName.Click += txtServiceName_Click;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.Location = new Point(35, 124);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(379, 100);
            txtDescription.TabIndex = 1;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.AllowPromptAsInput = true;
            txtPrice.AnimateReadOnly = false;
            txtPrice.AsciiOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.BeepOnError = false;
            txtPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HidePromptOnLeave = false;
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.InsertKeyMode = InsertKeyMode.Default;
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(332, 57);
            txtPrice.Mask = "";
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.PromptChar = '_';
            txtPrice.ReadOnly = false;
            txtPrice.RejectInputOnFirstFailure = false;
            txtPrice.ResetOnPrompt = true;
            txtPrice.ResetOnSpace = true;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(250, 48);
            txtPrice.SkipLiterals = true;
            txtPrice.TabIndex = 2;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.ValidatingType = null;
            // 
            // numDuration
            // 
            numDuration.Location = new Point(420, 146);
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(162, 23);
            numDuration.TabIndex = 3;
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
            cmbCreatedBy.Location = new Point(420, 175);
            cmbCreatedBy.MaxDropDownItems = 4;
            cmbCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            cmbCreatedBy.Name = "cmbCreatedBy";
            cmbCreatedBy.Size = new Size(162, 49);
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
            btnSave.Location = new Point(124, 270);
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
            btnCancel.Location = new Point(405, 270);
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(420, 124);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(62, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Duration";
            // 
            // cbIncludesChapel
            // 
            cbIncludesChapel.AutoSize = true;
            cbIncludesChapel.Depth = 0;
            cbIncludesChapel.Location = new Point(595, 48);
            cbIncludesChapel.Margin = new Padding(0);
            cbIncludesChapel.MouseLocation = new Point(-1, -1);
            cbIncludesChapel.MouseState = MaterialSkin.MouseState.HOVER;
            cbIncludesChapel.Name = "cbIncludesChapel";
            cbIncludesChapel.ReadOnly = false;
            cbIncludesChapel.Ripple = true;
            cbIncludesChapel.Size = new Size(84, 37);
            cbIncludesChapel.TabIndex = 8;
            cbIncludesChapel.Text = "Chapel";
            cbIncludesChapel.UseVisualStyleBackColor = true;
            cbIncludesChapel.CheckedChanged += cbIncludesChapel_CheckedChanged;
            // 
            // cbCasket
            // 
            cbCasket.AutoSize = true;
            cbCasket.Depth = 0;
            cbCasket.Location = new Point(595, 85);
            cbCasket.Margin = new Padding(0);
            cbCasket.MouseLocation = new Point(-1, -1);
            cbCasket.MouseState = MaterialSkin.MouseState.HOVER;
            cbCasket.Name = "cbCasket";
            cbCasket.ReadOnly = false;
            cbCasket.Ripple = true;
            cbCasket.Size = new Size(83, 37);
            cbCasket.TabIndex = 9;
            cbCasket.Text = "Casket";
            cbCasket.UseVisualStyleBackColor = true;
            cbCasket.CheckedChanged += cbCasket_CheckedChanged;
            // 
            // cbAircon
            // 
            cbAircon.AutoSize = true;
            cbAircon.Depth = 0;
            cbAircon.Location = new Point(595, 122);
            cbAircon.Margin = new Padding(0);
            cbAircon.MouseLocation = new Point(-1, -1);
            cbAircon.MouseState = MaterialSkin.MouseState.HOVER;
            cbAircon.Name = "cbAircon";
            cbAircon.ReadOnly = false;
            cbAircon.Ripple = true;
            cbAircon.Size = new Size(80, 37);
            cbAircon.TabIndex = 10;
            cbAircon.Text = "Aircon";
            cbAircon.UseVisualStyleBackColor = true;
            cbAircon.CheckedChanged += cbAircon_CheckedChanged;
            // 
            // cbEmbalming
            // 
            cbEmbalming.AutoSize = true;
            cbEmbalming.Depth = 0;
            cbEmbalming.Location = new Point(595, 159);
            cbEmbalming.Margin = new Padding(0);
            cbEmbalming.MouseLocation = new Point(-1, -1);
            cbEmbalming.MouseState = MaterialSkin.MouseState.HOVER;
            cbEmbalming.Name = "cbEmbalming";
            cbEmbalming.ReadOnly = false;
            cbEmbalming.Ripple = true;
            cbEmbalming.Size = new Size(116, 37);
            cbEmbalming.TabIndex = 11;
            cbEmbalming.Text = "Embalming";
            cbEmbalming.UseVisualStyleBackColor = true;
            cbEmbalming.CheckedChanged += cbEmbalming_CheckedChanged;
            // 
            // cbPresidential
            // 
            cbPresidential.AutoSize = true;
            cbPresidential.Depth = 0;
            cbPresidential.Location = new Point(595, 196);
            cbPresidential.Margin = new Padding(0);
            cbPresidential.MouseLocation = new Point(-1, -1);
            cbPresidential.MouseState = MaterialSkin.MouseState.HOVER;
            cbPresidential.Name = "cbPresidential";
            cbPresidential.ReadOnly = false;
            cbPresidential.Ripple = true;
            cbPresidential.Size = new Size(118, 37);
            cbPresidential.TabIndex = 12;
            cbPresidential.Text = "Presidential";
            cbPresidential.UseVisualStyleBackColor = true;
            cbPresidential.CheckedChanged += cbPresidential_CheckedChanged;
            // 
            // cbFreeChapel
            // 
            cbFreeChapel.AutoSize = true;
            cbFreeChapel.Depth = 0;
            cbFreeChapel.Location = new Point(593, 233);
            cbFreeChapel.Margin = new Padding(0);
            cbFreeChapel.MouseLocation = new Point(-1, -1);
            cbFreeChapel.MouseState = MaterialSkin.MouseState.HOVER;
            cbFreeChapel.Name = "cbFreeChapel";
            cbFreeChapel.ReadOnly = false;
            cbFreeChapel.Ripple = true;
            cbFreeChapel.Size = new Size(118, 37);
            cbFreeChapel.TabIndex = 13;
            cbFreeChapel.Text = "Free Chapel";
            cbFreeChapel.UseVisualStyleBackColor = true;
            cbFreeChapel.CheckedChanged += cbFreeChapel_CheckedChanged;
            // 
            // FrmAddEditService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 371);
            Controls.Add(cbFreeChapel);
            Controls.Add(cbPresidential);
            Controls.Add(cbEmbalming);
            Controls.Add(cbAircon);
            Controls.Add(cbCasket);
            Controls.Add(cbIncludesChapel);
            Controls.Add(materialLabel1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCreatedBy);
            Controls.Add(numDuration);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtServiceName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddEditService";
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtServiceName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrice;
        private NumericUpDown numDuration;
        private MaterialSkin.Controls.MaterialComboBox cmbCreatedBy;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox cbIncludesChapel;
        private MaterialSkin.Controls.MaterialCheckbox cbCasket;
        private MaterialSkin.Controls.MaterialCheckbox cbAircon;
        private MaterialSkin.Controls.MaterialCheckbox cbEmbalming;
        private MaterialSkin.Controls.MaterialCheckbox cbPresidential;
        private MaterialSkin.Controls.MaterialCheckbox cbFreeChapel;
    }
}