namespace Mini_Cs
{
    partial class FrmAddEditTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditTransaction));
            dtpTransactionDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            txtAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cmbCreatedBy = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            cmbClient = new ComboBox();
            cmbService = new ComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            numQuantity = new NumericUpDown();
            txtDiscount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.BackColor = Color.Transparent;
            dtpTransactionDate.BorderColor = Color.Silver;
            dtpTransactionDate.BorderRadius = 1;
            dtpTransactionDate.Color = Color.Silver;
            dtpTransactionDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dtpTransactionDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dtpTransactionDate.DisabledColor = Color.Gray;
            dtpTransactionDate.DisplayWeekNumbers = false;
            dtpTransactionDate.DPHeight = 0;
            dtpTransactionDate.DropDownAlign = LeftRightAlignment.Right;
            dtpTransactionDate.FillDatePicker = false;
            dtpTransactionDate.Font = new Font("Segoe UI", 9F);
            dtpTransactionDate.ForeColor = Color.Black;
            dtpTransactionDate.Icon = (Image)resources.GetObject("dtpTransactionDate.Icon");
            dtpTransactionDate.IconColor = Color.Gray;
            dtpTransactionDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dtpTransactionDate.LeftTextMargin = 5;
            dtpTransactionDate.Location = new Point(431, 108);
            dtpTransactionDate.MinimumSize = new Size(0, 32);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(199, 32);
            dtpTransactionDate.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.AllowPromptAsInput = true;
            txtAmount.AnimateReadOnly = false;
            txtAmount.AsciiOnly = false;
            txtAmount.BackgroundImageLayout = ImageLayout.None;
            txtAmount.BeepOnError = false;
            txtAmount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.HidePromptOnLeave = false;
            txtAmount.HideSelection = true;
            txtAmount.Hint = "Amount";
            txtAmount.InsertKeyMode = InsertKeyMode.Default;
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(333, 38);
            txtAmount.Mask = "";
            txtAmount.MaxLength = 32767;
            txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PrefixSuffixText = null;
            txtAmount.PromptChar = '_';
            txtAmount.ReadOnly = false;
            txtAmount.RejectInputOnFirstFailure = false;
            txtAmount.ResetOnPrompt = true;
            txtAmount.ResetOnSpace = true;
            txtAmount.RightToLeft = RightToLeft.No;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.ShortcutsEnabled = true;
            txtAmount.Size = new Size(297, 48);
            txtAmount.SkipLiterals = true;
            txtAmount.TabIndex = 3;
            txtAmount.TabStop = false;
            txtAmount.TextAlign = HorizontalAlignment.Left;
            txtAmount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAmount.TrailingIcon = null;
            txtAmount.UseSystemPasswordChar = false;
            txtAmount.ValidatingType = null;
            // 
            // txtNotes
            // 
            txtNotes.AnimateReadOnly = false;
            txtNotes.BackgroundImageLayout = ImageLayout.None;
            txtNotes.CharacterCasing = CharacterCasing.Normal;
            txtNotes.Depth = 0;
            txtNotes.HideSelection = true;
            txtNotes.Hint = "Notes";
            txtNotes.Location = new Point(31, 158);
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
            txtNotes.Size = new Size(370, 113);
            txtNotes.TabIndex = 4;
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
            cmbCreatedBy.Location = new Point(418, 222);
            cmbCreatedBy.MaxDropDownItems = 4;
            cmbCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            cmbCreatedBy.Name = "cmbCreatedBy";
            cmbCreatedBy.Size = new Size(212, 49);
            cmbCreatedBy.StartIndex = 0;
            cmbCreatedBy.TabIndex = 5;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(431, 86);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(123, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Transaction Date";
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(400, 308);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(113, 308);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbClient
            // 
            cmbClient.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbClient.FormattingEnabled = true;
            cmbClient.ItemHeight = 22;
            cmbClient.Location = new Point(31, 56);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(278, 30);
            cmbClient.TabIndex = 9;
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbService.FormattingEnabled = true;
            cmbService.ItemHeight = 22;
            cmbService.Location = new Point(31, 110);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(278, 30);
            cmbService.TabIndex = 10;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(31, 88);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(52, 19);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "Service";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(31, 34);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 12;
            materialLabel3.Text = "Client";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(418, 200);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(32, 19);
            materialLabel4.TabIndex = 13;
            materialLabel4.Text = "User";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(418, 174);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(212, 23);
            numQuantity.TabIndex = 14;
            // 
            // txtDiscount
            // 
            txtDiscount.AllowPromptAsInput = true;
            txtDiscount.AnimateReadOnly = false;
            txtDiscount.AsciiOnly = false;
            txtDiscount.BackgroundImageLayout = ImageLayout.None;
            txtDiscount.BeepOnError = false;
            txtDiscount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDiscount.Depth = 0;
            txtDiscount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiscount.HidePromptOnLeave = false;
            txtDiscount.HideSelection = true;
            txtDiscount.Hint = "Discount";
            txtDiscount.InsertKeyMode = InsertKeyMode.Default;
            txtDiscount.LeadingIcon = null;
            txtDiscount.Location = new Point(333, 92);
            txtDiscount.Mask = "";
            txtDiscount.MaxLength = 32767;
            txtDiscount.MouseState = MaterialSkin.MouseState.OUT;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PasswordChar = '\0';
            txtDiscount.PrefixSuffixText = null;
            txtDiscount.PromptChar = '_';
            txtDiscount.ReadOnly = false;
            txtDiscount.RejectInputOnFirstFailure = false;
            txtDiscount.ResetOnPrompt = true;
            txtDiscount.ResetOnSpace = true;
            txtDiscount.RightToLeft = RightToLeft.No;
            txtDiscount.SelectedText = "";
            txtDiscount.SelectionLength = 0;
            txtDiscount.SelectionStart = 0;
            txtDiscount.ShortcutsEnabled = true;
            txtDiscount.Size = new Size(92, 48);
            txtDiscount.SkipLiterals = true;
            txtDiscount.TabIndex = 15;
            txtDiscount.TabStop = false;
            txtDiscount.TextAlign = HorizontalAlignment.Left;
            txtDiscount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDiscount.TrailingIcon = null;
            txtDiscount.UseSystemPasswordChar = false;
            txtDiscount.ValidatingType = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(418, 152);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(61, 19);
            materialLabel5.TabIndex = 16;
            materialLabel5.Text = "Quantity";
            // 
            // FrmAddEditTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 371);
            Controls.Add(materialLabel5);
            Controls.Add(txtDiscount);
            Controls.Add(numQuantity);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(cmbService);
            Controls.Add(cmbClient);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(materialLabel1);
            Controls.Add(cmbCreatedBy);
            Controls.Add(txtNotes);
            Controls.Add(txtAmount);
            Controls.Add(dtpTransactionDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddEditTransaction";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDatePicker dtpTransactionDate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAmount;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNotes;
        private MaterialSkin.Controls.MaterialComboBox cmbCreatedBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private ComboBox cmbClient;
        private ComboBox cmbService;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private NumericUpDown numQuantity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDiscount;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}