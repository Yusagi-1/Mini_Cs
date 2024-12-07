namespace Mini_Cs.PaymentServices
{
    partial class SeniorCitizenServices
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
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtVatableSales = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtAddDiscount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txt20Discount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtTotalVATExempt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtExtraCharges = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPlanValue = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtGrossPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(376, 372);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtVatableSales
            // 
            txtVatableSales.AllowPromptAsInput = true;
            txtVatableSales.AnimateReadOnly = false;
            txtVatableSales.AsciiOnly = false;
            txtVatableSales.BackgroundImageLayout = ImageLayout.None;
            txtVatableSales.BeepOnError = false;
            txtVatableSales.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtVatableSales.Depth = 0;
            txtVatableSales.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVatableSales.HidePromptOnLeave = false;
            txtVatableSales.HideSelection = true;
            txtVatableSales.Hint = "CONTRACT Price";
            txtVatableSales.InsertKeyMode = InsertKeyMode.Default;
            txtVatableSales.LeadingIcon = null;
            txtVatableSales.Location = new Point(281, 273);
            txtVatableSales.Mask = "";
            txtVatableSales.MaxLength = 32767;
            txtVatableSales.MouseState = MaterialSkin.MouseState.OUT;
            txtVatableSales.Name = "txtVatableSales";
            txtVatableSales.PasswordChar = '\0';
            txtVatableSales.PrefixSuffixText = null;
            txtVatableSales.PromptChar = '_';
            txtVatableSales.ReadOnly = false;
            txtVatableSales.RejectInputOnFirstFailure = false;
            txtVatableSales.ResetOnPrompt = true;
            txtVatableSales.ResetOnSpace = true;
            txtVatableSales.RightToLeft = RightToLeft.No;
            txtVatableSales.SelectedText = "";
            txtVatableSales.SelectionLength = 0;
            txtVatableSales.SelectionStart = 0;
            txtVatableSales.ShortcutsEnabled = true;
            txtVatableSales.Size = new Size(250, 48);
            txtVatableSales.SkipLiterals = true;
            txtVatableSales.TabIndex = 14;
            txtVatableSales.TabStop = false;
            txtVatableSales.TextAlign = HorizontalAlignment.Left;
            txtVatableSales.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtVatableSales.TrailingIcon = null;
            txtVatableSales.UseSystemPasswordChar = false;
            txtVatableSales.ValidatingType = null;
            txtVatableSales.Click += txtVatableSales_Click;
            // 
            // txtAddDiscount
            // 
            txtAddDiscount.AllowPromptAsInput = true;
            txtAddDiscount.AnimateReadOnly = false;
            txtAddDiscount.AsciiOnly = false;
            txtAddDiscount.BackgroundImageLayout = ImageLayout.None;
            txtAddDiscount.BeepOnError = false;
            txtAddDiscount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAddDiscount.Depth = 0;
            txtAddDiscount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddDiscount.HidePromptOnLeave = false;
            txtAddDiscount.HideSelection = true;
            txtAddDiscount.Hint = "Add. Discount";
            txtAddDiscount.InsertKeyMode = InsertKeyMode.Default;
            txtAddDiscount.LeadingIcon = null;
            txtAddDiscount.Location = new Point(429, 43);
            txtAddDiscount.Mask = "";
            txtAddDiscount.MaxLength = 32767;
            txtAddDiscount.MouseState = MaterialSkin.MouseState.OUT;
            txtAddDiscount.Name = "txtAddDiscount";
            txtAddDiscount.PasswordChar = '\0';
            txtAddDiscount.PrefixSuffixText = null;
            txtAddDiscount.PromptChar = '_';
            txtAddDiscount.ReadOnly = false;
            txtAddDiscount.RejectInputOnFirstFailure = false;
            txtAddDiscount.ResetOnPrompt = true;
            txtAddDiscount.ResetOnSpace = true;
            txtAddDiscount.RightToLeft = RightToLeft.No;
            txtAddDiscount.SelectedText = "";
            txtAddDiscount.SelectionLength = 0;
            txtAddDiscount.SelectionStart = 0;
            txtAddDiscount.ShortcutsEnabled = true;
            txtAddDiscount.Size = new Size(250, 48);
            txtAddDiscount.SkipLiterals = true;
            txtAddDiscount.TabIndex = 13;
            txtAddDiscount.TabStop = false;
            txtAddDiscount.TextAlign = HorizontalAlignment.Left;
            txtAddDiscount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAddDiscount.TrailingIcon = null;
            txtAddDiscount.UseSystemPasswordChar = false;
            txtAddDiscount.ValidatingType = null;
            txtAddDiscount.Click += txtAddDiscount_Click;
            // 
            // txt20Discount
            // 
            txt20Discount.AllowPromptAsInput = true;
            txt20Discount.AnimateReadOnly = false;
            txt20Discount.AsciiOnly = false;
            txt20Discount.BackgroundImageLayout = ImageLayout.None;
            txt20Discount.BeepOnError = false;
            txt20Discount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt20Discount.Depth = 0;
            txt20Discount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt20Discount.HidePromptOnLeave = false;
            txt20Discount.HideSelection = true;
            txt20Discount.Hint = "20% SC Discount";
            txt20Discount.InsertKeyMode = InsertKeyMode.Default;
            txt20Discount.LeadingIcon = null;
            txt20Discount.Location = new Point(429, 125);
            txt20Discount.Mask = "";
            txt20Discount.MaxLength = 32767;
            txt20Discount.MouseState = MaterialSkin.MouseState.OUT;
            txt20Discount.Name = "txt20Discount";
            txt20Discount.PasswordChar = '\0';
            txt20Discount.PrefixSuffixText = null;
            txt20Discount.PromptChar = '_';
            txt20Discount.ReadOnly = false;
            txt20Discount.RejectInputOnFirstFailure = false;
            txt20Discount.ResetOnPrompt = true;
            txt20Discount.ResetOnSpace = true;
            txt20Discount.RightToLeft = RightToLeft.No;
            txt20Discount.SelectedText = "";
            txt20Discount.SelectionLength = 0;
            txt20Discount.SelectionStart = 0;
            txt20Discount.ShortcutsEnabled = true;
            txt20Discount.Size = new Size(250, 48);
            txt20Discount.SkipLiterals = true;
            txt20Discount.TabIndex = 12;
            txt20Discount.TabStop = false;
            txt20Discount.TextAlign = HorizontalAlignment.Left;
            txt20Discount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt20Discount.TrailingIcon = null;
            txt20Discount.UseSystemPasswordChar = false;
            txt20Discount.ValidatingType = null;
            txt20Discount.Click += txt20Discount_Click;
            // 
            // txtTotalVATExempt
            // 
            txtTotalVATExempt.AllowPromptAsInput = true;
            txtTotalVATExempt.AnimateReadOnly = false;
            txtTotalVATExempt.AsciiOnly = false;
            txtTotalVATExempt.BackgroundImageLayout = ImageLayout.None;
            txtTotalVATExempt.BeepOnError = false;
            txtTotalVATExempt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalVATExempt.Depth = 0;
            txtTotalVATExempt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalVATExempt.HidePromptOnLeave = false;
            txtTotalVATExempt.HideSelection = true;
            txtTotalVATExempt.Hint = "Total (VAT EXEMPT)";
            txtTotalVATExempt.InsertKeyMode = InsertKeyMode.Default;
            txtTotalVATExempt.LeadingIcon = null;
            txtTotalVATExempt.Location = new Point(429, 198);
            txtTotalVATExempt.Mask = "";
            txtTotalVATExempt.MaxLength = 32767;
            txtTotalVATExempt.MouseState = MaterialSkin.MouseState.OUT;
            txtTotalVATExempt.Name = "txtTotalVATExempt";
            txtTotalVATExempt.PasswordChar = '\0';
            txtTotalVATExempt.PrefixSuffixText = null;
            txtTotalVATExempt.PromptChar = '_';
            txtTotalVATExempt.ReadOnly = false;
            txtTotalVATExempt.RejectInputOnFirstFailure = false;
            txtTotalVATExempt.ResetOnPrompt = true;
            txtTotalVATExempt.ResetOnSpace = true;
            txtTotalVATExempt.RightToLeft = RightToLeft.No;
            txtTotalVATExempt.SelectedText = "";
            txtTotalVATExempt.SelectionLength = 0;
            txtTotalVATExempt.SelectionStart = 0;
            txtTotalVATExempt.ShortcutsEnabled = true;
            txtTotalVATExempt.Size = new Size(250, 48);
            txtTotalVATExempt.SkipLiterals = true;
            txtTotalVATExempt.TabIndex = 11;
            txtTotalVATExempt.TabStop = false;
            txtTotalVATExempt.TextAlign = HorizontalAlignment.Left;
            txtTotalVATExempt.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalVATExempt.TrailingIcon = null;
            txtTotalVATExempt.UseSystemPasswordChar = false;
            txtTotalVATExempt.ValidatingType = null;
            txtTotalVATExempt.Click += txtTotalVATExempt_Click;
            // 
            // txtExtraCharges
            // 
            txtExtraCharges.AllowPromptAsInput = true;
            txtExtraCharges.AnimateReadOnly = false;
            txtExtraCharges.AsciiOnly = false;
            txtExtraCharges.BackgroundImageLayout = ImageLayout.None;
            txtExtraCharges.BeepOnError = false;
            txtExtraCharges.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtExtraCharges.Depth = 0;
            txtExtraCharges.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExtraCharges.HidePromptOnLeave = false;
            txtExtraCharges.HideSelection = true;
            txtExtraCharges.Hint = "Extra Charges";
            txtExtraCharges.InsertKeyMode = InsertKeyMode.Default;
            txtExtraCharges.LeadingIcon = null;
            txtExtraCharges.Location = new Point(122, 198);
            txtExtraCharges.Mask = "";
            txtExtraCharges.MaxLength = 32767;
            txtExtraCharges.MouseState = MaterialSkin.MouseState.OUT;
            txtExtraCharges.Name = "txtExtraCharges";
            txtExtraCharges.PasswordChar = '\0';
            txtExtraCharges.PrefixSuffixText = null;
            txtExtraCharges.PromptChar = '_';
            txtExtraCharges.ReadOnly = false;
            txtExtraCharges.RejectInputOnFirstFailure = false;
            txtExtraCharges.ResetOnPrompt = true;
            txtExtraCharges.ResetOnSpace = true;
            txtExtraCharges.RightToLeft = RightToLeft.No;
            txtExtraCharges.SelectedText = "";
            txtExtraCharges.SelectionLength = 0;
            txtExtraCharges.SelectionStart = 0;
            txtExtraCharges.ShortcutsEnabled = true;
            txtExtraCharges.Size = new Size(250, 48);
            txtExtraCharges.SkipLiterals = true;
            txtExtraCharges.TabIndex = 10;
            txtExtraCharges.TabStop = false;
            txtExtraCharges.TextAlign = HorizontalAlignment.Left;
            txtExtraCharges.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtExtraCharges.TrailingIcon = null;
            txtExtraCharges.UseSystemPasswordChar = false;
            txtExtraCharges.ValidatingType = null;
            txtExtraCharges.Click += txtExtraCharges_Click;
            // 
            // txtPlanValue
            // 
            txtPlanValue.AllowPromptAsInput = true;
            txtPlanValue.AnimateReadOnly = false;
            txtPlanValue.AsciiOnly = false;
            txtPlanValue.BackgroundImageLayout = ImageLayout.None;
            txtPlanValue.BeepOnError = false;
            txtPlanValue.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPlanValue.Depth = 0;
            txtPlanValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlanValue.HidePromptOnLeave = false;
            txtPlanValue.HideSelection = true;
            txtPlanValue.Hint = "Plan Value";
            txtPlanValue.InsertKeyMode = InsertKeyMode.Default;
            txtPlanValue.LeadingIcon = null;
            txtPlanValue.Location = new Point(122, 125);
            txtPlanValue.Mask = "";
            txtPlanValue.MaxLength = 32767;
            txtPlanValue.MouseState = MaterialSkin.MouseState.OUT;
            txtPlanValue.Name = "txtPlanValue";
            txtPlanValue.PasswordChar = '\0';
            txtPlanValue.PrefixSuffixText = null;
            txtPlanValue.PromptChar = '_';
            txtPlanValue.ReadOnly = false;
            txtPlanValue.RejectInputOnFirstFailure = false;
            txtPlanValue.ResetOnPrompt = true;
            txtPlanValue.ResetOnSpace = true;
            txtPlanValue.RightToLeft = RightToLeft.No;
            txtPlanValue.SelectedText = "";
            txtPlanValue.SelectionLength = 0;
            txtPlanValue.SelectionStart = 0;
            txtPlanValue.ShortcutsEnabled = true;
            txtPlanValue.Size = new Size(250, 48);
            txtPlanValue.SkipLiterals = true;
            txtPlanValue.TabIndex = 9;
            txtPlanValue.TabStop = false;
            txtPlanValue.TextAlign = HorizontalAlignment.Left;
            txtPlanValue.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPlanValue.TrailingIcon = null;
            txtPlanValue.UseSystemPasswordChar = false;
            txtPlanValue.ValidatingType = null;
            txtPlanValue.Click += txtPlanValue_Click;
            // 
            // txtGrossPrice
            // 
            txtGrossPrice.AllowPromptAsInput = true;
            txtGrossPrice.AnimateReadOnly = false;
            txtGrossPrice.AsciiOnly = false;
            txtGrossPrice.BackgroundImageLayout = ImageLayout.None;
            txtGrossPrice.BeepOnError = false;
            txtGrossPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGrossPrice.Depth = 0;
            txtGrossPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGrossPrice.HidePromptOnLeave = false;
            txtGrossPrice.HideSelection = true;
            txtGrossPrice.Hint = "Gross Price";
            txtGrossPrice.InsertKeyMode = InsertKeyMode.Default;
            txtGrossPrice.LeadingIcon = null;
            txtGrossPrice.Location = new Point(122, 43);
            txtGrossPrice.Mask = "";
            txtGrossPrice.MaxLength = 32767;
            txtGrossPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtGrossPrice.Name = "txtGrossPrice";
            txtGrossPrice.PasswordChar = '\0';
            txtGrossPrice.PrefixSuffixText = null;
            txtGrossPrice.PromptChar = '_';
            txtGrossPrice.ReadOnly = false;
            txtGrossPrice.RejectInputOnFirstFailure = false;
            txtGrossPrice.ResetOnPrompt = true;
            txtGrossPrice.ResetOnSpace = true;
            txtGrossPrice.RightToLeft = RightToLeft.No;
            txtGrossPrice.SelectedText = "";
            txtGrossPrice.SelectionLength = 0;
            txtGrossPrice.SelectionStart = 0;
            txtGrossPrice.ShortcutsEnabled = true;
            txtGrossPrice.Size = new Size(250, 48);
            txtGrossPrice.SkipLiterals = true;
            txtGrossPrice.TabIndex = 8;
            txtGrossPrice.TabStop = false;
            txtGrossPrice.TextAlign = HorizontalAlignment.Left;
            txtGrossPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGrossPrice.TrailingIcon = null;
            txtGrossPrice.UseSystemPasswordChar = false;
            txtGrossPrice.ValidatingType = null;
            txtGrossPrice.Click += txtGrossPrice_Click;
            // 
            // SeniorCitizenServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtVatableSales);
            Controls.Add(txtAddDiscount);
            Controls.Add(txt20Discount);
            Controls.Add(txtTotalVATExempt);
            Controls.Add(txtExtraCharges);
            Controls.Add(txtPlanValue);
            Controls.Add(txtGrossPrice);
            Name = "SeniorCitizenServices";
            Text = "SeniorCitizenServices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtVatableSales;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddDiscount;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt20Discount;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTotalVATExempt;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtExtraCharges;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPlanValue;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGrossPrice;
    }
}