namespace Mini_Cs
{
    partial class Representative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Representative));
            panel1 = new Panel();
            txtPrimaryName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dpPrimaryDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            txtPrimaryEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPrimaryMobileNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPrimaryAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPrimaryRelationship = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnProceed = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            txtSecondaryName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dpSecondaryDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            txtSecondaryEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtSecondaryMobileNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtSecondaryAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtSecondaryRelationship = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPrimaryName);
            panel1.Controls.Add(dpPrimaryDate);
            panel1.Controls.Add(txtPrimaryEmail);
            panel1.Controls.Add(txtPrimaryMobileNo);
            panel1.Controls.Add(txtPrimaryAddress);
            panel1.Controls.Add(txtPrimaryRelationship);
            panel1.Location = new Point(26, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 312);
            panel1.TabIndex = 0;
            // 
            // txtPrimaryName
            // 
            txtPrimaryName.AllowPromptAsInput = true;
            txtPrimaryName.AnimateReadOnly = false;
            txtPrimaryName.AsciiOnly = false;
            txtPrimaryName.BackgroundImageLayout = ImageLayout.None;
            txtPrimaryName.BeepOnError = false;
            txtPrimaryName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryName.Depth = 0;
            txtPrimaryName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimaryName.HidePromptOnLeave = false;
            txtPrimaryName.HideSelection = true;
            txtPrimaryName.Hint = "Name";
            txtPrimaryName.InsertKeyMode = InsertKeyMode.Default;
            txtPrimaryName.LeadingIcon = null;
            txtPrimaryName.Location = new Point(3, 3);
            txtPrimaryName.Mask = "";
            txtPrimaryName.MaxLength = 32767;
            txtPrimaryName.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimaryName.Name = "txtPrimaryName";
            txtPrimaryName.PasswordChar = '\0';
            txtPrimaryName.PrefixSuffixText = null;
            txtPrimaryName.PromptChar = '_';
            txtPrimaryName.ReadOnly = false;
            txtPrimaryName.RejectInputOnFirstFailure = false;
            txtPrimaryName.ResetOnPrompt = true;
            txtPrimaryName.ResetOnSpace = true;
            txtPrimaryName.RightToLeft = RightToLeft.No;
            txtPrimaryName.SelectedText = "";
            txtPrimaryName.SelectionLength = 0;
            txtPrimaryName.SelectionStart = 0;
            txtPrimaryName.ShortcutsEnabled = true;
            txtPrimaryName.Size = new Size(407, 48);
            txtPrimaryName.SkipLiterals = true;
            txtPrimaryName.TabIndex = 7;
            txtPrimaryName.TabStop = false;
            txtPrimaryName.TextAlign = HorizontalAlignment.Left;
            txtPrimaryName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryName.TrailingIcon = null;
            txtPrimaryName.UseSystemPasswordChar = false;
            txtPrimaryName.ValidatingType = null;
            // 
            // dpPrimaryDate
            // 
            dpPrimaryDate.BackColor = Color.Transparent;
            dpPrimaryDate.BorderColor = Color.Silver;
            dpPrimaryDate.BorderRadius = 1;
            dpPrimaryDate.Color = Color.Silver;
            dpPrimaryDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpPrimaryDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpPrimaryDate.DisabledColor = Color.Gray;
            dpPrimaryDate.DisplayWeekNumbers = false;
            dpPrimaryDate.DPHeight = 0;
            dpPrimaryDate.DropDownAlign = LeftRightAlignment.Right;
            dpPrimaryDate.FillDatePicker = false;
            dpPrimaryDate.Font = new Font("Segoe UI", 9F);
            dpPrimaryDate.ForeColor = Color.Black;
            dpPrimaryDate.Icon = (Image)resources.GetObject("dpPrimaryDate.Icon");
            dpPrimaryDate.IconColor = Color.Gray;
            dpPrimaryDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpPrimaryDate.LeftTextMargin = 5;
            dpPrimaryDate.Location = new Point(3, 274);
            dpPrimaryDate.MinimumSize = new Size(0, 32);
            dpPrimaryDate.Name = "dpPrimaryDate";
            dpPrimaryDate.Size = new Size(407, 32);
            dpPrimaryDate.TabIndex = 6;
            // 
            // txtPrimaryEmail
            // 
            txtPrimaryEmail.AllowPromptAsInput = true;
            txtPrimaryEmail.AnimateReadOnly = false;
            txtPrimaryEmail.AsciiOnly = false;
            txtPrimaryEmail.BackgroundImageLayout = ImageLayout.None;
            txtPrimaryEmail.BeepOnError = false;
            txtPrimaryEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryEmail.Depth = 0;
            txtPrimaryEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimaryEmail.HidePromptOnLeave = false;
            txtPrimaryEmail.HideSelection = true;
            txtPrimaryEmail.Hint = "Email Address";
            txtPrimaryEmail.InsertKeyMode = InsertKeyMode.Default;
            txtPrimaryEmail.LeadingIcon = null;
            txtPrimaryEmail.Location = new Point(3, 220);
            txtPrimaryEmail.Mask = "";
            txtPrimaryEmail.MaxLength = 32767;
            txtPrimaryEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimaryEmail.Name = "txtPrimaryEmail";
            txtPrimaryEmail.PasswordChar = '\0';
            txtPrimaryEmail.PrefixSuffixText = null;
            txtPrimaryEmail.PromptChar = '_';
            txtPrimaryEmail.ReadOnly = false;
            txtPrimaryEmail.RejectInputOnFirstFailure = false;
            txtPrimaryEmail.ResetOnPrompt = true;
            txtPrimaryEmail.ResetOnSpace = true;
            txtPrimaryEmail.RightToLeft = RightToLeft.No;
            txtPrimaryEmail.SelectedText = "";
            txtPrimaryEmail.SelectionLength = 0;
            txtPrimaryEmail.SelectionStart = 0;
            txtPrimaryEmail.ShortcutsEnabled = true;
            txtPrimaryEmail.Size = new Size(407, 48);
            txtPrimaryEmail.SkipLiterals = true;
            txtPrimaryEmail.TabIndex = 3;
            txtPrimaryEmail.TabStop = false;
            txtPrimaryEmail.TextAlign = HorizontalAlignment.Left;
            txtPrimaryEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryEmail.TrailingIcon = null;
            txtPrimaryEmail.UseSystemPasswordChar = false;
            txtPrimaryEmail.ValidatingType = null;
            // 
            // txtPrimaryMobileNo
            // 
            txtPrimaryMobileNo.AllowPromptAsInput = true;
            txtPrimaryMobileNo.AnimateReadOnly = false;
            txtPrimaryMobileNo.AsciiOnly = false;
            txtPrimaryMobileNo.BackgroundImageLayout = ImageLayout.None;
            txtPrimaryMobileNo.BeepOnError = false;
            txtPrimaryMobileNo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryMobileNo.Depth = 0;
            txtPrimaryMobileNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimaryMobileNo.HidePromptOnLeave = false;
            txtPrimaryMobileNo.HideSelection = true;
            txtPrimaryMobileNo.Hint = "Telephone No./Mobile";
            txtPrimaryMobileNo.InsertKeyMode = InsertKeyMode.Default;
            txtPrimaryMobileNo.LeadingIcon = null;
            txtPrimaryMobileNo.Location = new Point(3, 166);
            txtPrimaryMobileNo.Mask = "";
            txtPrimaryMobileNo.MaxLength = 32767;
            txtPrimaryMobileNo.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimaryMobileNo.Name = "txtPrimaryMobileNo";
            txtPrimaryMobileNo.PasswordChar = '\0';
            txtPrimaryMobileNo.PrefixSuffixText = null;
            txtPrimaryMobileNo.PromptChar = '_';
            txtPrimaryMobileNo.ReadOnly = false;
            txtPrimaryMobileNo.RejectInputOnFirstFailure = false;
            txtPrimaryMobileNo.ResetOnPrompt = true;
            txtPrimaryMobileNo.ResetOnSpace = true;
            txtPrimaryMobileNo.RightToLeft = RightToLeft.No;
            txtPrimaryMobileNo.SelectedText = "";
            txtPrimaryMobileNo.SelectionLength = 0;
            txtPrimaryMobileNo.SelectionStart = 0;
            txtPrimaryMobileNo.ShortcutsEnabled = true;
            txtPrimaryMobileNo.Size = new Size(407, 48);
            txtPrimaryMobileNo.SkipLiterals = true;
            txtPrimaryMobileNo.TabIndex = 2;
            txtPrimaryMobileNo.TabStop = false;
            txtPrimaryMobileNo.TextAlign = HorizontalAlignment.Left;
            txtPrimaryMobileNo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryMobileNo.TrailingIcon = null;
            txtPrimaryMobileNo.UseSystemPasswordChar = false;
            txtPrimaryMobileNo.ValidatingType = null;
            // 
            // txtPrimaryAddress
            // 
            txtPrimaryAddress.AllowPromptAsInput = true;
            txtPrimaryAddress.AnimateReadOnly = false;
            txtPrimaryAddress.AsciiOnly = false;
            txtPrimaryAddress.BackgroundImageLayout = ImageLayout.None;
            txtPrimaryAddress.BeepOnError = false;
            txtPrimaryAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryAddress.Depth = 0;
            txtPrimaryAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimaryAddress.HidePromptOnLeave = false;
            txtPrimaryAddress.HideSelection = true;
            txtPrimaryAddress.Hint = "Address";
            txtPrimaryAddress.InsertKeyMode = InsertKeyMode.Default;
            txtPrimaryAddress.LeadingIcon = null;
            txtPrimaryAddress.Location = new Point(3, 112);
            txtPrimaryAddress.Mask = "";
            txtPrimaryAddress.MaxLength = 32767;
            txtPrimaryAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimaryAddress.Name = "txtPrimaryAddress";
            txtPrimaryAddress.PasswordChar = '\0';
            txtPrimaryAddress.PrefixSuffixText = null;
            txtPrimaryAddress.PromptChar = '_';
            txtPrimaryAddress.ReadOnly = false;
            txtPrimaryAddress.RejectInputOnFirstFailure = false;
            txtPrimaryAddress.ResetOnPrompt = true;
            txtPrimaryAddress.ResetOnSpace = true;
            txtPrimaryAddress.RightToLeft = RightToLeft.No;
            txtPrimaryAddress.SelectedText = "";
            txtPrimaryAddress.SelectionLength = 0;
            txtPrimaryAddress.SelectionStart = 0;
            txtPrimaryAddress.ShortcutsEnabled = true;
            txtPrimaryAddress.Size = new Size(407, 48);
            txtPrimaryAddress.SkipLiterals = true;
            txtPrimaryAddress.TabIndex = 1;
            txtPrimaryAddress.TabStop = false;
            txtPrimaryAddress.TextAlign = HorizontalAlignment.Left;
            txtPrimaryAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryAddress.TrailingIcon = null;
            txtPrimaryAddress.UseSystemPasswordChar = false;
            txtPrimaryAddress.ValidatingType = null;
            // 
            // txtPrimaryRelationship
            // 
            txtPrimaryRelationship.AllowPromptAsInput = true;
            txtPrimaryRelationship.AnimateReadOnly = false;
            txtPrimaryRelationship.AsciiOnly = false;
            txtPrimaryRelationship.BackgroundImageLayout = ImageLayout.None;
            txtPrimaryRelationship.BeepOnError = false;
            txtPrimaryRelationship.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryRelationship.Depth = 0;
            txtPrimaryRelationship.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimaryRelationship.HidePromptOnLeave = false;
            txtPrimaryRelationship.HideSelection = true;
            txtPrimaryRelationship.Hint = "Relationship";
            txtPrimaryRelationship.InsertKeyMode = InsertKeyMode.Default;
            txtPrimaryRelationship.LeadingIcon = null;
            txtPrimaryRelationship.Location = new Point(3, 58);
            txtPrimaryRelationship.Mask = "";
            txtPrimaryRelationship.MaxLength = 32767;
            txtPrimaryRelationship.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimaryRelationship.Name = "txtPrimaryRelationship";
            txtPrimaryRelationship.PasswordChar = '\0';
            txtPrimaryRelationship.PrefixSuffixText = null;
            txtPrimaryRelationship.PromptChar = '_';
            txtPrimaryRelationship.ReadOnly = false;
            txtPrimaryRelationship.RejectInputOnFirstFailure = false;
            txtPrimaryRelationship.ResetOnPrompt = true;
            txtPrimaryRelationship.ResetOnSpace = true;
            txtPrimaryRelationship.RightToLeft = RightToLeft.No;
            txtPrimaryRelationship.SelectedText = "";
            txtPrimaryRelationship.SelectionLength = 0;
            txtPrimaryRelationship.SelectionStart = 0;
            txtPrimaryRelationship.ShortcutsEnabled = true;
            txtPrimaryRelationship.Size = new Size(407, 48);
            txtPrimaryRelationship.SkipLiterals = true;
            txtPrimaryRelationship.TabIndex = 0;
            txtPrimaryRelationship.TabStop = false;
            txtPrimaryRelationship.TextAlign = HorizontalAlignment.Left;
            txtPrimaryRelationship.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrimaryRelationship.TrailingIcon = null;
            txtPrimaryRelationship.UseSystemPasswordChar = false;
            txtPrimaryRelationship.ValidatingType = null;
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
            btnProceed.TabIndex = 23;
            btnProceed.Text = "Proceed";
            btnProceed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProceed.UseAccentColor = false;
            btnProceed.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSecondaryName);
            panel2.Controls.Add(dpSecondaryDate);
            panel2.Controls.Add(txtSecondaryEmail);
            panel2.Controls.Add(txtSecondaryMobileNo);
            panel2.Controls.Add(txtSecondaryAddress);
            panel2.Controls.Add(txtSecondaryRelationship);
            panel2.Location = new Point(472, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 312);
            panel2.TabIndex = 24;
            // 
            // txtSecondaryName
            // 
            txtSecondaryName.AllowPromptAsInput = true;
            txtSecondaryName.AnimateReadOnly = false;
            txtSecondaryName.AsciiOnly = false;
            txtSecondaryName.BackgroundImageLayout = ImageLayout.None;
            txtSecondaryName.BeepOnError = false;
            txtSecondaryName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryName.Depth = 0;
            txtSecondaryName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondaryName.HidePromptOnLeave = false;
            txtSecondaryName.HideSelection = true;
            txtSecondaryName.Hint = "Name";
            txtSecondaryName.InsertKeyMode = InsertKeyMode.Default;
            txtSecondaryName.LeadingIcon = null;
            txtSecondaryName.Location = new Point(3, 3);
            txtSecondaryName.Mask = "";
            txtSecondaryName.MaxLength = 32767;
            txtSecondaryName.MouseState = MaterialSkin.MouseState.OUT;
            txtSecondaryName.Name = "txtSecondaryName";
            txtSecondaryName.PasswordChar = '\0';
            txtSecondaryName.PrefixSuffixText = null;
            txtSecondaryName.PromptChar = '_';
            txtSecondaryName.ReadOnly = false;
            txtSecondaryName.RejectInputOnFirstFailure = false;
            txtSecondaryName.ResetOnPrompt = true;
            txtSecondaryName.ResetOnSpace = true;
            txtSecondaryName.RightToLeft = RightToLeft.No;
            txtSecondaryName.SelectedText = "";
            txtSecondaryName.SelectionLength = 0;
            txtSecondaryName.SelectionStart = 0;
            txtSecondaryName.ShortcutsEnabled = true;
            txtSecondaryName.Size = new Size(407, 48);
            txtSecondaryName.SkipLiterals = true;
            txtSecondaryName.TabIndex = 12;
            txtSecondaryName.TabStop = false;
            txtSecondaryName.TextAlign = HorizontalAlignment.Left;
            txtSecondaryName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryName.TrailingIcon = null;
            txtSecondaryName.UseSystemPasswordChar = false;
            txtSecondaryName.ValidatingType = null;
            // 
            // dpSecondaryDate
            // 
            dpSecondaryDate.BackColor = Color.Transparent;
            dpSecondaryDate.BorderColor = Color.Silver;
            dpSecondaryDate.BorderRadius = 1;
            dpSecondaryDate.Color = Color.Silver;
            dpSecondaryDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dpSecondaryDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dpSecondaryDate.DisabledColor = Color.Gray;
            dpSecondaryDate.DisplayWeekNumbers = false;
            dpSecondaryDate.DPHeight = 0;
            dpSecondaryDate.DropDownAlign = LeftRightAlignment.Right;
            dpSecondaryDate.FillDatePicker = false;
            dpSecondaryDate.Font = new Font("Segoe UI", 9F);
            dpSecondaryDate.ForeColor = Color.Black;
            dpSecondaryDate.Icon = (Image)resources.GetObject("dpSecondaryDate.Icon");
            dpSecondaryDate.IconColor = Color.Gray;
            dpSecondaryDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dpSecondaryDate.LeftTextMargin = 5;
            dpSecondaryDate.Location = new Point(3, 272);
            dpSecondaryDate.MinimumSize = new Size(0, 32);
            dpSecondaryDate.Name = "dpSecondaryDate";
            dpSecondaryDate.Size = new Size(407, 32);
            dpSecondaryDate.TabIndex = 11;
            // 
            // txtSecondaryEmail
            // 
            txtSecondaryEmail.AllowPromptAsInput = true;
            txtSecondaryEmail.AnimateReadOnly = false;
            txtSecondaryEmail.AsciiOnly = false;
            txtSecondaryEmail.BackgroundImageLayout = ImageLayout.None;
            txtSecondaryEmail.BeepOnError = false;
            txtSecondaryEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryEmail.Depth = 0;
            txtSecondaryEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondaryEmail.HidePromptOnLeave = false;
            txtSecondaryEmail.HideSelection = true;
            txtSecondaryEmail.Hint = "Email Address";
            txtSecondaryEmail.InsertKeyMode = InsertKeyMode.Default;
            txtSecondaryEmail.LeadingIcon = null;
            txtSecondaryEmail.Location = new Point(3, 218);
            txtSecondaryEmail.Mask = "";
            txtSecondaryEmail.MaxLength = 32767;
            txtSecondaryEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtSecondaryEmail.Name = "txtSecondaryEmail";
            txtSecondaryEmail.PasswordChar = '\0';
            txtSecondaryEmail.PrefixSuffixText = null;
            txtSecondaryEmail.PromptChar = '_';
            txtSecondaryEmail.ReadOnly = false;
            txtSecondaryEmail.RejectInputOnFirstFailure = false;
            txtSecondaryEmail.ResetOnPrompt = true;
            txtSecondaryEmail.ResetOnSpace = true;
            txtSecondaryEmail.RightToLeft = RightToLeft.No;
            txtSecondaryEmail.SelectedText = "";
            txtSecondaryEmail.SelectionLength = 0;
            txtSecondaryEmail.SelectionStart = 0;
            txtSecondaryEmail.ShortcutsEnabled = true;
            txtSecondaryEmail.Size = new Size(407, 48);
            txtSecondaryEmail.SkipLiterals = true;
            txtSecondaryEmail.TabIndex = 8;
            txtSecondaryEmail.TabStop = false;
            txtSecondaryEmail.TextAlign = HorizontalAlignment.Left;
            txtSecondaryEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryEmail.TrailingIcon = null;
            txtSecondaryEmail.UseSystemPasswordChar = false;
            txtSecondaryEmail.ValidatingType = null;
            // 
            // txtSecondaryMobileNo
            // 
            txtSecondaryMobileNo.AllowPromptAsInput = true;
            txtSecondaryMobileNo.AnimateReadOnly = false;
            txtSecondaryMobileNo.AsciiOnly = false;
            txtSecondaryMobileNo.BackgroundImageLayout = ImageLayout.None;
            txtSecondaryMobileNo.BeepOnError = false;
            txtSecondaryMobileNo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryMobileNo.Depth = 0;
            txtSecondaryMobileNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondaryMobileNo.HidePromptOnLeave = false;
            txtSecondaryMobileNo.HideSelection = true;
            txtSecondaryMobileNo.Hint = "Telephone No./Mobile";
            txtSecondaryMobileNo.InsertKeyMode = InsertKeyMode.Default;
            txtSecondaryMobileNo.LeadingIcon = null;
            txtSecondaryMobileNo.Location = new Point(3, 164);
            txtSecondaryMobileNo.Mask = "";
            txtSecondaryMobileNo.MaxLength = 32767;
            txtSecondaryMobileNo.MouseState = MaterialSkin.MouseState.OUT;
            txtSecondaryMobileNo.Name = "txtSecondaryMobileNo";
            txtSecondaryMobileNo.PasswordChar = '\0';
            txtSecondaryMobileNo.PrefixSuffixText = null;
            txtSecondaryMobileNo.PromptChar = '_';
            txtSecondaryMobileNo.ReadOnly = false;
            txtSecondaryMobileNo.RejectInputOnFirstFailure = false;
            txtSecondaryMobileNo.ResetOnPrompt = true;
            txtSecondaryMobileNo.ResetOnSpace = true;
            txtSecondaryMobileNo.RightToLeft = RightToLeft.No;
            txtSecondaryMobileNo.SelectedText = "";
            txtSecondaryMobileNo.SelectionLength = 0;
            txtSecondaryMobileNo.SelectionStart = 0;
            txtSecondaryMobileNo.ShortcutsEnabled = true;
            txtSecondaryMobileNo.Size = new Size(407, 48);
            txtSecondaryMobileNo.SkipLiterals = true;
            txtSecondaryMobileNo.TabIndex = 7;
            txtSecondaryMobileNo.TabStop = false;
            txtSecondaryMobileNo.TextAlign = HorizontalAlignment.Left;
            txtSecondaryMobileNo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryMobileNo.TrailingIcon = null;
            txtSecondaryMobileNo.UseSystemPasswordChar = false;
            txtSecondaryMobileNo.ValidatingType = null;
            // 
            // txtSecondaryAddress
            // 
            txtSecondaryAddress.AllowPromptAsInput = true;
            txtSecondaryAddress.AnimateReadOnly = false;
            txtSecondaryAddress.AsciiOnly = false;
            txtSecondaryAddress.BackgroundImageLayout = ImageLayout.None;
            txtSecondaryAddress.BeepOnError = false;
            txtSecondaryAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryAddress.Depth = 0;
            txtSecondaryAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondaryAddress.HidePromptOnLeave = false;
            txtSecondaryAddress.HideSelection = true;
            txtSecondaryAddress.Hint = "Address";
            txtSecondaryAddress.InsertKeyMode = InsertKeyMode.Default;
            txtSecondaryAddress.LeadingIcon = null;
            txtSecondaryAddress.Location = new Point(3, 110);
            txtSecondaryAddress.Mask = "";
            txtSecondaryAddress.MaxLength = 32767;
            txtSecondaryAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtSecondaryAddress.Name = "txtSecondaryAddress";
            txtSecondaryAddress.PasswordChar = '\0';
            txtSecondaryAddress.PrefixSuffixText = null;
            txtSecondaryAddress.PromptChar = '_';
            txtSecondaryAddress.ReadOnly = false;
            txtSecondaryAddress.RejectInputOnFirstFailure = false;
            txtSecondaryAddress.ResetOnPrompt = true;
            txtSecondaryAddress.ResetOnSpace = true;
            txtSecondaryAddress.RightToLeft = RightToLeft.No;
            txtSecondaryAddress.SelectedText = "";
            txtSecondaryAddress.SelectionLength = 0;
            txtSecondaryAddress.SelectionStart = 0;
            txtSecondaryAddress.ShortcutsEnabled = true;
            txtSecondaryAddress.Size = new Size(407, 48);
            txtSecondaryAddress.SkipLiterals = true;
            txtSecondaryAddress.TabIndex = 6;
            txtSecondaryAddress.TabStop = false;
            txtSecondaryAddress.TextAlign = HorizontalAlignment.Left;
            txtSecondaryAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryAddress.TrailingIcon = null;
            txtSecondaryAddress.UseSystemPasswordChar = false;
            txtSecondaryAddress.ValidatingType = null;
            // 
            // txtSecondaryRelationship
            // 
            txtSecondaryRelationship.AllowPromptAsInput = true;
            txtSecondaryRelationship.AnimateReadOnly = false;
            txtSecondaryRelationship.AsciiOnly = false;
            txtSecondaryRelationship.BackgroundImageLayout = ImageLayout.None;
            txtSecondaryRelationship.BeepOnError = false;
            txtSecondaryRelationship.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryRelationship.Depth = 0;
            txtSecondaryRelationship.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSecondaryRelationship.HidePromptOnLeave = false;
            txtSecondaryRelationship.HideSelection = true;
            txtSecondaryRelationship.Hint = "Relationship";
            txtSecondaryRelationship.InsertKeyMode = InsertKeyMode.Default;
            txtSecondaryRelationship.LeadingIcon = null;
            txtSecondaryRelationship.Location = new Point(3, 56);
            txtSecondaryRelationship.Mask = "";
            txtSecondaryRelationship.MaxLength = 32767;
            txtSecondaryRelationship.MouseState = MaterialSkin.MouseState.OUT;
            txtSecondaryRelationship.Name = "txtSecondaryRelationship";
            txtSecondaryRelationship.PasswordChar = '\0';
            txtSecondaryRelationship.PrefixSuffixText = null;
            txtSecondaryRelationship.PromptChar = '_';
            txtSecondaryRelationship.ReadOnly = false;
            txtSecondaryRelationship.RejectInputOnFirstFailure = false;
            txtSecondaryRelationship.ResetOnPrompt = true;
            txtSecondaryRelationship.ResetOnSpace = true;
            txtSecondaryRelationship.RightToLeft = RightToLeft.No;
            txtSecondaryRelationship.SelectedText = "";
            txtSecondaryRelationship.SelectionLength = 0;
            txtSecondaryRelationship.SelectionStart = 0;
            txtSecondaryRelationship.ShortcutsEnabled = true;
            txtSecondaryRelationship.Size = new Size(407, 48);
            txtSecondaryRelationship.SkipLiterals = true;
            txtSecondaryRelationship.TabIndex = 5;
            txtSecondaryRelationship.TabStop = false;
            txtSecondaryRelationship.TextAlign = HorizontalAlignment.Left;
            txtSecondaryRelationship.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSecondaryRelationship.TrailingIcon = null;
            txtSecondaryRelationship.UseSystemPasswordChar = false;
            txtSecondaryRelationship.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(133, 31);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(183, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Primary Contracting Party";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(584, 31);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(203, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Secondary Contracting Party";
            // 
            // Representative
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 472);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(panel2);
            Controls.Add(btnProceed);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Representative";
            Text = "Representative";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnProceed;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrimaryRelationship;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrimaryEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrimaryAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrimaryMobileNo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSecondaryEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSecondaryMobileNo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSecondaryAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSecondaryRelationship;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dpPrimaryDate;
        private Bunifu.UI.WinForms.BunifuDatePicker dpSecondaryDate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrimaryName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSecondaryName;
    }
}