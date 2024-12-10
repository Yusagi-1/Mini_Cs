namespace Mini_Cs
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            cbCustomerId = new MaterialSkin.Controls.MaterialComboBox();
            lblCustomerName = new MaterialSkin.Controls.MaterialLabel();
            txtContractPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtAmountPaid = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblRemainingBalance = new MaterialSkin.Controls.MaterialLabel();
            dpPaymentDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            cbStatus = new MaterialSkin.Controls.MaterialComboBox();
            cbModeOfPayment = new MaterialSkin.Controls.MaterialComboBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnView = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbCustomerId
            // 
            cbCustomerId.AutoResize = false;
            cbCustomerId.BackColor = Color.FromArgb(255, 255, 255);
            cbCustomerId.Depth = 0;
            cbCustomerId.DrawMode = DrawMode.OwnerDrawVariable;
            cbCustomerId.DropDownHeight = 174;
            cbCustomerId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerId.DropDownWidth = 121;
            cbCustomerId.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCustomerId.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCustomerId.FormattingEnabled = true;
            cbCustomerId.IntegralHeight = false;
            cbCustomerId.ItemHeight = 43;
            cbCustomerId.Location = new Point(151, 60);
            cbCustomerId.MaxDropDownItems = 4;
            cbCustomerId.MouseState = MaterialSkin.MouseState.OUT;
            cbCustomerId.Name = "cbCustomerId";
            cbCustomerId.Size = new Size(121, 49);
            cbCustomerId.StartIndex = 0;
            cbCustomerId.TabIndex = 0;
            cbCustomerId.SelectedIndexChanged += cbCustomerId_SelectedIndexChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Depth = 0;
            lblCustomerName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCustomerName.Location = new Point(278, 79);
            lblCustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(115, 19);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.Click += lblCustomerName_Click;
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
            txtContractPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContractPrice.HidePromptOnLeave = false;
            txtContractPrice.HideSelection = true;
            txtContractPrice.Hint = "Contract Price";
            txtContractPrice.InsertKeyMode = InsertKeyMode.Default;
            txtContractPrice.LeadingIcon = null;
            txtContractPrice.Location = new Point(154, 141);
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
            txtContractPrice.TabIndex = 2;
            txtContractPrice.TabStop = false;
            txtContractPrice.TextAlign = HorizontalAlignment.Left;
            txtContractPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtContractPrice.TrailingIcon = null;
            txtContractPrice.UseSystemPasswordChar = false;
            txtContractPrice.ValidatingType = null;
            txtContractPrice.Click += txtContractPrice_Click;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.AllowPromptAsInput = true;
            txtAmountPaid.AnimateReadOnly = false;
            txtAmountPaid.AsciiOnly = false;
            txtAmountPaid.BackgroundImageLayout = ImageLayout.None;
            txtAmountPaid.BeepOnError = false;
            txtAmountPaid.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAmountPaid.Depth = 0;
            txtAmountPaid.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmountPaid.HidePromptOnLeave = false;
            txtAmountPaid.HideSelection = true;
            txtAmountPaid.Hint = "Amount Paid";
            txtAmountPaid.InsertKeyMode = InsertKeyMode.Default;
            txtAmountPaid.LeadingIcon = null;
            txtAmountPaid.Location = new Point(154, 218);
            txtAmountPaid.Mask = "";
            txtAmountPaid.MaxLength = 32767;
            txtAmountPaid.MouseState = MaterialSkin.MouseState.OUT;
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.PasswordChar = '\0';
            txtAmountPaid.PrefixSuffixText = null;
            txtAmountPaid.PromptChar = '_';
            txtAmountPaid.ReadOnly = false;
            txtAmountPaid.RejectInputOnFirstFailure = false;
            txtAmountPaid.ResetOnPrompt = true;
            txtAmountPaid.ResetOnSpace = true;
            txtAmountPaid.RightToLeft = RightToLeft.No;
            txtAmountPaid.SelectedText = "";
            txtAmountPaid.SelectionLength = 0;
            txtAmountPaid.SelectionStart = 0;
            txtAmountPaid.ShortcutsEnabled = true;
            txtAmountPaid.Size = new Size(250, 48);
            txtAmountPaid.SkipLiterals = true;
            txtAmountPaid.TabIndex = 3;
            txtAmountPaid.TabStop = false;
            txtAmountPaid.TextAlign = HorizontalAlignment.Left;
            txtAmountPaid.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAmountPaid.TrailingIcon = null;
            txtAmountPaid.UseSystemPasswordChar = false;
            txtAmountPaid.ValidatingType = null;
            txtAmountPaid.Click += txtAmountPaid_Click;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.Depth = 0;
            lblRemainingBalance.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRemainingBalance.Location = new Point(154, 293);
            lblRemainingBalance.MouseState = MaterialSkin.MouseState.HOVER;
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(138, 19);
            lblRemainingBalance.TabIndex = 4;
            lblRemainingBalance.Text = "Remaining Balance";
            lblRemainingBalance.Click += lblRemainingBalance_Click;
            // 
            // dpPaymentDate
            // 
            dpPaymentDate.BackColor = Color.Transparent;
            dpPaymentDate.BorderColor = Color.Silver;
            dpPaymentDate.BorderRadius = 1;
            dpPaymentDate.Color = Color.Silver;
            dpPaymentDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpPaymentDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpPaymentDate.DisabledColor = Color.Gray;
            dpPaymentDate.DisplayWeekNumbers = false;
            dpPaymentDate.DPHeight = 0;
            dpPaymentDate.DropDownAlign = LeftRightAlignment.Right;
            dpPaymentDate.FillDatePicker = false;
            dpPaymentDate.Font = new Font("Segoe UI", 9F);
            dpPaymentDate.ForeColor = Color.Black;
            dpPaymentDate.Icon = (Image)resources.GetObject("dpPaymentDate.Icon");
            dpPaymentDate.IconColor = Color.Gray;
            dpPaymentDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpPaymentDate.LeftTextMargin = 5;
            dpPaymentDate.Location = new Point(455, 66);
            dpPaymentDate.MinimumSize = new Size(0, 32);
            dpPaymentDate.Name = "dpPaymentDate";
            dpPaymentDate.Size = new Size(220, 32);
            dpPaymentDate.TabIndex = 5;
            dpPaymentDate.ValueChanged += dpPaymentDate_ValueChanged;
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
            cbStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.IntegralHeight = false;
            cbStatus.ItemHeight = 43;
            cbStatus.Location = new Point(455, 140);
            cbStatus.MaxDropDownItems = 4;
            cbStatus.MouseState = MaterialSkin.MouseState.OUT;
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(220, 49);
            cbStatus.StartIndex = 0;
            cbStatus.TabIndex = 6;
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
            cbModeOfPayment.IntegralHeight = false;
            cbModeOfPayment.ItemHeight = 43;
            cbModeOfPayment.Location = new Point(455, 218);
            cbModeOfPayment.MaxDropDownItems = 4;
            cbModeOfPayment.MouseState = MaterialSkin.MouseState.OUT;
            cbModeOfPayment.Name = "cbModeOfPayment";
            cbModeOfPayment.Size = new Size(220, 49);
            cbModeOfPayment.StartIndex = 0;
            cbModeOfPayment.TabIndex = 7;
            cbModeOfPayment.SelectedIndexChanged += cbModeOfPayment_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(154, 365);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(252, 365);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnView.Depth = 0;
            btnView.HighEmphasis = true;
            btnView.Icon = null;
            btnView.Location = new Point(363, 365);
            btnView.Margin = new Padding(4, 6, 4, 6);
            btnView.MouseState = MaterialSkin.MouseState.HOVER;
            btnView.Name = "btnView";
            btnView.NoAccentTextColor = Color.Empty;
            btnView.Size = new Size(64, 36);
            btnView.TabIndex = 10;
            btnView.Text = "View";
            btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnView.UseAccentColor = false;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 441);
            Controls.Add(btnView);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbModeOfPayment);
            Controls.Add(cbStatus);
            Controls.Add(dpPaymentDate);
            Controls.Add(lblRemainingBalance);
            Controls.Add(txtAmountPaid);
            Controls.Add(txtContractPrice);
            Controls.Add(lblCustomerName);
            Controls.Add(cbCustomerId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbCustomerId;
        private MaterialSkin.Controls.MaterialLabel lblCustomerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContractPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAmountPaid;
        private MaterialSkin.Controls.MaterialLabel lblRemainingBalance;
        private Bunifu.UI.WinForms.BunifuDatePicker dpPaymentDate;
        private MaterialSkin.Controls.MaterialComboBox cbStatus;
        private MaterialSkin.Controls.MaterialComboBox cbModeOfPayment;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnView;
    }
}