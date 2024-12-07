namespace Mini_Cs
{
    partial class CustomerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfo));
            txtBoxOthers = new MaterialSkin.Controls.MaterialMaskedTextBox();
            checkBoxOther = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxNo = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxYes = new MaterialSkin.Controls.MaterialCheckbox();
            label2 = new Label();
            label1 = new Label();
            checkBoxCremationOnly = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxFullServiceCremation = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxFullService = new MaterialSkin.Controls.MaterialCheckbox();
            btnProceed = new MaterialSkin.Controls.MaterialButton();
            dpDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            SuspendLayout();
            // 
            // txtBoxOthers
            // 
            txtBoxOthers.AllowPromptAsInput = true;
            txtBoxOthers.AnimateReadOnly = false;
            txtBoxOthers.AsciiOnly = false;
            txtBoxOthers.BackgroundImageLayout = ImageLayout.None;
            txtBoxOthers.BeepOnError = false;
            txtBoxOthers.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBoxOthers.Depth = 0;
            txtBoxOthers.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxOthers.HidePromptOnLeave = false;
            txtBoxOthers.HideSelection = true;
            txtBoxOthers.Hint = "Others";
            txtBoxOthers.InsertKeyMode = InsertKeyMode.Default;
            txtBoxOthers.LeadingIcon = null;
            txtBoxOthers.Location = new Point(320, 180);
            txtBoxOthers.Mask = "";
            txtBoxOthers.MaxLength = 32767;
            txtBoxOthers.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxOthers.Name = "txtBoxOthers";
            txtBoxOthers.PasswordChar = '\0';
            txtBoxOthers.PrefixSuffixText = null;
            txtBoxOthers.PromptChar = '_';
            txtBoxOthers.ReadOnly = false;
            txtBoxOthers.RejectInputOnFirstFailure = false;
            txtBoxOthers.ResetOnPrompt = true;
            txtBoxOthers.ResetOnSpace = true;
            txtBoxOthers.RightToLeft = RightToLeft.No;
            txtBoxOthers.SelectedText = "";
            txtBoxOthers.SelectionLength = 0;
            txtBoxOthers.SelectionStart = 0;
            txtBoxOthers.ShortcutsEnabled = true;
            txtBoxOthers.Size = new Size(250, 48);
            txtBoxOthers.SkipLiterals = true;
            txtBoxOthers.TabIndex = 19;
            txtBoxOthers.TabStop = false;
            txtBoxOthers.TextAlign = HorizontalAlignment.Left;
            txtBoxOthers.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBoxOthers.TrailingIcon = null;
            txtBoxOthers.UseSystemPasswordChar = false;
            txtBoxOthers.ValidatingType = null;
            txtBoxOthers.Click += txtBoxOthers_Click_1;
            txtBoxOthers.TextChanged += txtBoxOthers_TextChanged;
            // 
            // checkBoxOther
            // 
            checkBoxOther.AutoSize = true;
            checkBoxOther.Depth = 0;
            checkBoxOther.Location = new Point(320, 140);
            checkBoxOther.Margin = new Padding(0);
            checkBoxOther.MouseLocation = new Point(-1, -1);
            checkBoxOther.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxOther.Name = "checkBoxOther";
            checkBoxOther.ReadOnly = false;
            checkBoxOther.Ripple = true;
            checkBoxOther.Size = new Size(73, 37);
            checkBoxOther.TabIndex = 18;
            checkBoxOther.Text = "Other";
            checkBoxOther.UseVisualStyleBackColor = true;
            checkBoxOther.CheckedChanged += checkBoxOther_CheckedChanged_1;
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Depth = 0;
            checkBoxNo.Location = new Point(320, 103);
            checkBoxNo.Margin = new Padding(0);
            checkBoxNo.MouseLocation = new Point(-1, -1);
            checkBoxNo.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.ReadOnly = false;
            checkBoxNo.Ripple = true;
            checkBoxNo.Size = new Size(55, 37);
            checkBoxNo.TabIndex = 17;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged_1;
            // 
            // checkBoxYes
            // 
            checkBoxYes.AutoSize = true;
            checkBoxYes.Depth = 0;
            checkBoxYes.Location = new Point(320, 66);
            checkBoxYes.Margin = new Padding(0);
            checkBoxYes.MouseLocation = new Point(-1, -1);
            checkBoxYes.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.ReadOnly = false;
            checkBoxYes.Ripple = true;
            checkBoxYes.Size = new Size(61, 37);
            checkBoxYes.TabIndex = 16;
            checkBoxYes.Text = "Yes";
            checkBoxYes.UseVisualStyleBackColor = true;
            checkBoxYes.CheckedChanged += checkBoxYes_CheckedChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 38);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 15;
            label2.Text = "Service Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 14;
            label1.Text = "Service Type";
            // 
            // checkBoxCremationOnly
            // 
            checkBoxCremationOnly.AutoSize = true;
            checkBoxCremationOnly.Depth = 0;
            checkBoxCremationOnly.Location = new Point(63, 140);
            checkBoxCremationOnly.Margin = new Padding(0);
            checkBoxCremationOnly.MouseLocation = new Point(-1, -1);
            checkBoxCremationOnly.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxCremationOnly.Name = "checkBoxCremationOnly";
            checkBoxCremationOnly.ReadOnly = false;
            checkBoxCremationOnly.Ripple = true;
            checkBoxCremationOnly.Size = new Size(144, 37);
            checkBoxCremationOnly.TabIndex = 13;
            checkBoxCremationOnly.Text = "Cremation Only";
            checkBoxCremationOnly.UseVisualStyleBackColor = true;
            checkBoxCremationOnly.CheckedChanged += checkBoxCremationOnly_CheckedChanged_1;
            // 
            // checkBoxFullServiceCremation
            // 
            checkBoxFullServiceCremation.AutoSize = true;
            checkBoxFullServiceCremation.Depth = 0;
            checkBoxFullServiceCremation.Location = new Point(63, 103);
            checkBoxFullServiceCremation.Margin = new Padding(0);
            checkBoxFullServiceCremation.MouseLocation = new Point(-1, -1);
            checkBoxFullServiceCremation.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxFullServiceCremation.Name = "checkBoxFullServiceCremation";
            checkBoxFullServiceCremation.ReadOnly = false;
            checkBoxFullServiceCremation.Ripple = true;
            checkBoxFullServiceCremation.Size = new Size(216, 37);
            checkBoxFullServiceCremation.TabIndex = 12;
            checkBoxFullServiceCremation.Text = "Full Service w/ Cremation";
            checkBoxFullServiceCremation.UseVisualStyleBackColor = true;
            checkBoxFullServiceCremation.CheckedChanged += checkBoxFullServiceCremation_CheckedChanged_1;
            // 
            // checkBoxFullService
            // 
            checkBoxFullService.AutoSize = true;
            checkBoxFullService.Depth = 0;
            checkBoxFullService.Location = new Point(63, 66);
            checkBoxFullService.Margin = new Padding(0);
            checkBoxFullService.MouseLocation = new Point(-1, -1);
            checkBoxFullService.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxFullService.Name = "checkBoxFullService";
            checkBoxFullService.ReadOnly = false;
            checkBoxFullService.Ripple = true;
            checkBoxFullService.Size = new Size(116, 37);
            checkBoxFullService.TabIndex = 11;
            checkBoxFullService.Text = "Full Service";
            checkBoxFullService.UseVisualStyleBackColor = true;
            checkBoxFullService.CheckedChanged += checkBoxFullService_CheckedChanged_1;
            // 
            // btnProceed
            // 
            btnProceed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProceed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProceed.Depth = 0;
            btnProceed.HighEmphasis = true;
            btnProceed.Icon = null;
            btnProceed.Location = new Point(799, 342);
            btnProceed.Margin = new Padding(4, 6, 4, 6);
            btnProceed.MouseState = MaterialSkin.MouseState.HOVER;
            btnProceed.Name = "btnProceed";
            btnProceed.NoAccentTextColor = Color.Empty;
            btnProceed.Size = new Size(86, 36);
            btnProceed.TabIndex = 21;
            btnProceed.Text = "Proceed";
            btnProceed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProceed.UseAccentColor = false;
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click_1;
            // 
            // dpDate
            // 
            dpDate.BackColor = Color.Transparent;
            dpDate.BorderColor = Color.Silver;
            dpDate.BorderRadius = 1;
            dpDate.Color = Color.Silver;
            dpDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpDate.DisabledColor = Color.Gray;
            dpDate.DisplayWeekNumbers = false;
            dpDate.DPHeight = 0;
            dpDate.DropDownAlign = LeftRightAlignment.Right;
            dpDate.FillDatePicker = false;
            dpDate.Font = new Font("Segoe UI", 9F);
            dpDate.ForeColor = Color.Black;
            dpDate.Icon = (Image)resources.GetObject("dpDate.Icon");
            dpDate.IconColor = Color.Gray;
            dpDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpDate.LeftTextMargin = 5;
            dpDate.Location = new Point(665, 38);
            dpDate.MinimumSize = new Size(0, 32);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(220, 32);
            dpDate.TabIndex = 20;
            dpDate.ValueChanged += dpDate_ValueChanged_1;
            // 
            // CustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(txtBoxOthers);
            Controls.Add(checkBoxOther);
            Controls.Add(checkBoxNo);
            Controls.Add(checkBoxYes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxCremationOnly);
            Controls.Add(checkBoxFullServiceCremation);
            Controls.Add(checkBoxFullService);
            Controls.Add(btnProceed);
            Controls.Add(dpDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerInfo";
            Text = "CustomerInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtBoxOthers;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxOther;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxNo;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxYes;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxCremationOnly;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxFullServiceCremation;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxFullService;
        private MaterialSkin.Controls.MaterialButton btnProceed;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDate;
    }
}