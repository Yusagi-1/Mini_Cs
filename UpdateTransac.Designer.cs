namespace Mini_Cs
{
    partial class UpdateTransac
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
            txtContractPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPaymentAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cbStatus = new MaterialSkin.Controls.MaterialComboBox();
            cbModeOfPayment = new MaterialSkin.Controls.MaterialComboBox();
            cbTransactionID = new ComboBox();
            lblCustomerName = new MaterialSkin.Controls.MaterialLabel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtContractPrice
            // 
            txtContractPrice.AllowPromptAsInput = true;
            txtContractPrice.AnimateReadOnly = false;
            txtContractPrice.AsciiOnly = false;
            txtContractPrice.BackgroundImageLayout = ImageLayout.None;
            txtContractPrice.BeepOnError = false;
            txtContractPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtContractPrice.Depth = 0;
            txtContractPrice.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContractPrice.HidePromptOnLeave = false;
            txtContractPrice.HideSelection = true;
            txtContractPrice.Hint = "Contract Price";
            txtContractPrice.InsertKeyMode = InsertKeyMode.Default;
            txtContractPrice.LeadingIcon = null;
            txtContractPrice.Location = new Point(87, 108);
            txtContractPrice.Mask = "";
            txtContractPrice.MaxLength = 32767;
            txtContractPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtContractPrice.Name = "txtContractPrice";
            txtContractPrice.PasswordChar = '\0';
            txtContractPrice.PrefixSuffixText = null;
            txtContractPrice.PromptChar = '_';
            txtContractPrice.ReadOnly = false;
            txtContractPrice.RejectInputOnFirstFailure = false;
            txtContractPrice.ResetOnPrompt = true;
            txtContractPrice.ResetOnSpace = true;
            txtContractPrice.RightToLeft = RightToLeft.No;
            txtContractPrice.SelectedText = "";
            txtContractPrice.SelectionLength = 0;
            txtContractPrice.SelectionStart = 0;
            txtContractPrice.ShortcutsEnabled = true;
            txtContractPrice.Size = new Size(250, 48);
            txtContractPrice.SkipLiterals = true;
            txtContractPrice.TabIndex = 0;
            txtContractPrice.TabStop = false;
            txtContractPrice.TextAlign = HorizontalAlignment.Left;
            txtContractPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtContractPrice.TrailingIcon = null;
            txtContractPrice.UseSystemPasswordChar = false;
            txtContractPrice.ValidatingType = null;
            txtContractPrice.Click += txtContractPrice_Click;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.AllowPromptAsInput = true;
            txtPaymentAmount.AnimateReadOnly = false;
            txtPaymentAmount.AsciiOnly = false;
            txtPaymentAmount.BackgroundImageLayout = ImageLayout.None;
            txtPaymentAmount.BeepOnError = false;
            txtPaymentAmount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPaymentAmount.Depth = 0;
            txtPaymentAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPaymentAmount.HidePromptOnLeave = false;
            txtPaymentAmount.HideSelection = true;
            txtPaymentAmount.Hint = "Payment Amount";
            txtPaymentAmount.InsertKeyMode = InsertKeyMode.Default;
            txtPaymentAmount.LeadingIcon = null;
            txtPaymentAmount.Location = new Point(87, 200);
            txtPaymentAmount.Mask = "";
            txtPaymentAmount.MaxLength = 32767;
            txtPaymentAmount.MouseState = MaterialSkin.MouseState.OUT;
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.PasswordChar = '\0';
            txtPaymentAmount.PrefixSuffixText = null;
            txtPaymentAmount.PromptChar = '_';
            txtPaymentAmount.ReadOnly = false;
            txtPaymentAmount.RejectInputOnFirstFailure = false;
            txtPaymentAmount.ResetOnPrompt = true;
            txtPaymentAmount.ResetOnSpace = true;
            txtPaymentAmount.RightToLeft = RightToLeft.No;
            txtPaymentAmount.SelectedText = "";
            txtPaymentAmount.SelectionLength = 0;
            txtPaymentAmount.SelectionStart = 0;
            txtPaymentAmount.ShortcutsEnabled = true;
            txtPaymentAmount.Size = new Size(250, 48);
            txtPaymentAmount.SkipLiterals = true;
            txtPaymentAmount.TabIndex = 1;
            txtPaymentAmount.TabStop = false;
            txtPaymentAmount.TextAlign = HorizontalAlignment.Left;
            txtPaymentAmount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPaymentAmount.TrailingIcon = null;
            txtPaymentAmount.UseSystemPasswordChar = false;
            txtPaymentAmount.ValidatingType = null;
            txtPaymentAmount.Click += txtPaymentAmount_Click;
            // 
            // cbStatus
            // 
            cbStatus.AutoResize = false;
            cbStatus.BackColor = Color.FromArgb(255, 255, 255);
            cbStatus.Depth = 0;
            cbStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cbStatus.DropDownHeight = 174;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.DropDownWidth = 121;
            cbStatus.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Hint = "Status";
            cbStatus.IntegralHeight = false;
            cbStatus.ItemHeight = 43;
            cbStatus.Location = new Point(450, 107);
            cbStatus.MaxDropDownItems = 4;
            cbStatus.MouseState = MaterialSkin.MouseState.OUT;
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(191, 49);
            cbStatus.StartIndex = 0;
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // cbModeOfPayment
            // 
            cbModeOfPayment.AutoResize = false;
            cbModeOfPayment.BackColor = Color.FromArgb(255, 255, 255);
            cbModeOfPayment.Depth = 0;
            cbModeOfPayment.DrawMode = DrawMode.OwnerDrawVariable;
            cbModeOfPayment.DropDownHeight = 174;
            cbModeOfPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModeOfPayment.DropDownWidth = 121;
            cbModeOfPayment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbModeOfPayment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbModeOfPayment.FormattingEnabled = true;
            cbModeOfPayment.Hint = "Mode Of Payment";
            cbModeOfPayment.IntegralHeight = false;
            cbModeOfPayment.ItemHeight = 43;
            cbModeOfPayment.Location = new Point(450, 199);
            cbModeOfPayment.MaxDropDownItems = 4;
            cbModeOfPayment.MouseState = MaterialSkin.MouseState.OUT;
            cbModeOfPayment.Name = "cbModeOfPayment";
            cbModeOfPayment.Size = new Size(191, 49);
            cbModeOfPayment.StartIndex = 0;
            cbModeOfPayment.TabIndex = 3;
            cbModeOfPayment.SelectedIndexChanged += cbModeOfPayment_SelectedIndexChanged;
            // 
            // cbTransactionID
            // 
            cbTransactionID.FormattingEnabled = true;
            cbTransactionID.Location = new Point(87, 53);
            cbTransactionID.Name = "cbTransactionID";
            cbTransactionID.Size = new Size(125, 23);
            cbTransactionID.TabIndex = 4;
            cbTransactionID.Text = "Transaction ID";
            cbTransactionID.SelectedIndexChanged += cbTransactionID_SelectedIndexChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Depth = 0;
            lblCustomerName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCustomerName.Location = new Point(261, 53);
            lblCustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(115, 19);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.Click += lblCustomerName_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(221, 326);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 6;
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
            btnCancel.Location = new Point(462, 326);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateTransac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblCustomerName);
            Controls.Add(cbTransactionID);
            Controls.Add(cbModeOfPayment);
            Controls.Add(cbStatus);
            Controls.Add(txtPaymentAmount);
            Controls.Add(txtContractPrice);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateTransac";
            Text = "UpdateTransac";
            Load += UpdateTransac_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtContractPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPaymentAmount;
        private MaterialSkin.Controls.MaterialComboBox cbStatus;
        private MaterialSkin.Controls.MaterialComboBox cbModeOfPayment;
        private ComboBox cbTransactionID;
        private MaterialSkin.Controls.MaterialLabel lblCustomerName;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
    }
}