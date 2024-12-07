namespace Mini_Cs
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            checkBoxFullService = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxFullServiceCremation = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxCremationOnly = new MaterialSkin.Controls.MaterialCheckbox();
            label1 = new Label();
            label2 = new Label();
            checkBoxYes = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxNo = new MaterialSkin.Controls.MaterialCheckbox();
            checkBoxOther = new MaterialSkin.Controls.MaterialCheckbox();
            txtBoxOthers = new MaterialSkin.Controls.MaterialMaskedTextBox();
            bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            SuspendLayout();
            // 
            // checkBoxFullService
            // 
            checkBoxFullService.AutoSize = true;
            checkBoxFullService.Depth = 0;
            checkBoxFullService.Location = new Point(76, 72);
            checkBoxFullService.Margin = new Padding(0);
            checkBoxFullService.MouseLocation = new Point(-1, -1);
            checkBoxFullService.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxFullService.Name = "checkBoxFullService";
            checkBoxFullService.ReadOnly = false;
            checkBoxFullService.Ripple = true;
            checkBoxFullService.Size = new Size(116, 37);
            checkBoxFullService.TabIndex = 0;
            checkBoxFullService.Text = "Full Service";
            checkBoxFullService.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullServiceCremation
            // 
            checkBoxFullServiceCremation.AutoSize = true;
            checkBoxFullServiceCremation.Depth = 0;
            checkBoxFullServiceCremation.Location = new Point(76, 109);
            checkBoxFullServiceCremation.Margin = new Padding(0);
            checkBoxFullServiceCremation.MouseLocation = new Point(-1, -1);
            checkBoxFullServiceCremation.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxFullServiceCremation.Name = "checkBoxFullServiceCremation";
            checkBoxFullServiceCremation.ReadOnly = false;
            checkBoxFullServiceCremation.Ripple = true;
            checkBoxFullServiceCremation.Size = new Size(216, 37);
            checkBoxFullServiceCremation.TabIndex = 1;
            checkBoxFullServiceCremation.Text = "Full Service w/ Cremation";
            checkBoxFullServiceCremation.UseVisualStyleBackColor = true;
            // 
            // checkBoxCremationOnly
            // 
            checkBoxCremationOnly.AutoSize = true;
            checkBoxCremationOnly.Depth = 0;
            checkBoxCremationOnly.Location = new Point(76, 146);
            checkBoxCremationOnly.Margin = new Padding(0);
            checkBoxCremationOnly.MouseLocation = new Point(-1, -1);
            checkBoxCremationOnly.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxCremationOnly.Name = "checkBoxCremationOnly";
            checkBoxCremationOnly.ReadOnly = false;
            checkBoxCremationOnly.Ripple = true;
            checkBoxCremationOnly.Size = new Size(144, 37);
            checkBoxCremationOnly.TabIndex = 2;
            checkBoxCremationOnly.Text = "Cremation Only";
            checkBoxCremationOnly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 3;
            label1.Text = "Service Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 44);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 4;
            label2.Text = "Service Type";
            // 
            // checkBoxYes
            // 
            checkBoxYes.AutoSize = true;
            checkBoxYes.Depth = 0;
            checkBoxYes.Location = new Point(333, 72);
            checkBoxYes.Margin = new Padding(0);
            checkBoxYes.MouseLocation = new Point(-1, -1);
            checkBoxYes.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.ReadOnly = false;
            checkBoxYes.Ripple = true;
            checkBoxYes.Size = new Size(61, 37);
            checkBoxYes.TabIndex = 5;
            checkBoxYes.Text = "Yes";
            checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Depth = 0;
            checkBoxNo.Location = new Point(333, 109);
            checkBoxNo.Margin = new Padding(0);
            checkBoxNo.MouseLocation = new Point(-1, -1);
            checkBoxNo.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.ReadOnly = false;
            checkBoxNo.Ripple = true;
            checkBoxNo.Size = new Size(55, 37);
            checkBoxNo.TabIndex = 6;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxOther
            // 
            checkBoxOther.AutoSize = true;
            checkBoxOther.Depth = 0;
            checkBoxOther.Location = new Point(333, 146);
            checkBoxOther.Margin = new Padding(0);
            checkBoxOther.MouseLocation = new Point(-1, -1);
            checkBoxOther.MouseState = MaterialSkin.MouseState.HOVER;
            checkBoxOther.Name = "checkBoxOther";
            checkBoxOther.ReadOnly = false;
            checkBoxOther.Ripple = true;
            checkBoxOther.Size = new Size(73, 37);
            checkBoxOther.TabIndex = 7;
            checkBoxOther.Text = "Other";
            checkBoxOther.UseVisualStyleBackColor = true;
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
            txtBoxOthers.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxOthers.HidePromptOnLeave = false;
            txtBoxOthers.HideSelection = true;
            txtBoxOthers.Hint = "Others";
            txtBoxOthers.InsertKeyMode = InsertKeyMode.Default;
            txtBoxOthers.LeadingIcon = null;
            txtBoxOthers.Location = new Point(333, 186);
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
            txtBoxOthers.TabIndex = 8;
            txtBoxOthers.TabStop = false;
            txtBoxOthers.TextAlign = HorizontalAlignment.Left;
            txtBoxOthers.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBoxOthers.TrailingIcon = null;
            txtBoxOthers.UseSystemPasswordChar = false;
            txtBoxOthers.ValidatingType = null;
            // 
            // bunifuDatePicker1
            // 
            bunifuDatePicker1.BackColor = Color.Transparent;
            bunifuDatePicker1.BorderColor = Color.Silver;
            bunifuDatePicker1.BorderRadius = 1;
            bunifuDatePicker1.Color = Color.Silver;
            bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            bunifuDatePicker1.DisabledColor = Color.Gray;
            bunifuDatePicker1.DisplayWeekNumbers = false;
            bunifuDatePicker1.DPHeight = 0;
            bunifuDatePicker1.FillDatePicker = false;
            bunifuDatePicker1.Font = new Font("Segoe UI", 9F);
            bunifuDatePicker1.ForeColor = Color.Black;
            bunifuDatePicker1.Icon = (Image)resources.GetObject("bunifuDatePicker1.Icon");
            bunifuDatePicker1.IconColor = Color.Gray;
            bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            bunifuDatePicker1.LeftTextMargin = 5;
            bunifuDatePicker1.Location = new Point(559, 44);
            bunifuDatePicker1.MinimumSize = new Size(0, 32);
            bunifuDatePicker1.Name = "bunifuDatePicker1";
            bunifuDatePicker1.Size = new Size(220, 32);
            bunifuDatePicker1.TabIndex = 9;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bunifuDatePicker1);
            Controls.Add(txtBoxOthers);
            Controls.Add(checkBoxOther);
            Controls.Add(checkBoxNo);
            Controls.Add(checkBoxYes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxCremationOnly);
            Controls.Add(checkBoxFullServiceCremation);
            Controls.Add(checkBoxFullService);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            Text = "Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox checkBoxFullService;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxFullServiceCremation;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxCremationOnly;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxYes;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxNo;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxOther;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBoxOthers;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
    }
}