namespace Mini_Cs
{
    partial class FrmTransaction
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            txtSearchTransaction = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dgvTransactions = new Bunifu.UI.WinForms.BunifuDataGridView();
            btnAddTransaction = new MaterialSkin.Controls.MaterialButton();
            btnEditTransaction = new MaterialSkin.Controls.MaterialButton();
            btnDeleteTransaction = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // txtSearchTransaction
            // 
            txtSearchTransaction.AllowPromptAsInput = true;
            txtSearchTransaction.AnimateReadOnly = false;
            txtSearchTransaction.AsciiOnly = false;
            txtSearchTransaction.BackgroundImageLayout = ImageLayout.None;
            txtSearchTransaction.BeepOnError = false;
            txtSearchTransaction.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchTransaction.Depth = 0;
            txtSearchTransaction.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchTransaction.HidePromptOnLeave = false;
            txtSearchTransaction.HideSelection = true;
            txtSearchTransaction.Hint = "Search";
            txtSearchTransaction.InsertKeyMode = InsertKeyMode.Default;
            txtSearchTransaction.LeadingIcon = null;
            txtSearchTransaction.Location = new Point(47, 56);
            txtSearchTransaction.Mask = "";
            txtSearchTransaction.MaxLength = 32767;
            txtSearchTransaction.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchTransaction.Name = "txtSearchTransaction";
            txtSearchTransaction.PasswordChar = '\0';
            txtSearchTransaction.PrefixSuffixText = null;
            txtSearchTransaction.PromptChar = '_';
            txtSearchTransaction.ReadOnly = false;
            txtSearchTransaction.RejectInputOnFirstFailure = false;
            txtSearchTransaction.ResetOnPrompt = true;
            txtSearchTransaction.ResetOnSpace = true;
            txtSearchTransaction.RightToLeft = RightToLeft.No;
            txtSearchTransaction.SelectedText = "";
            txtSearchTransaction.SelectionLength = 0;
            txtSearchTransaction.SelectionStart = 0;
            txtSearchTransaction.ShortcutsEnabled = true;
            txtSearchTransaction.Size = new Size(332, 48);
            txtSearchTransaction.SkipLiterals = true;
            txtSearchTransaction.TabIndex = 0;
            txtSearchTransaction.TabStop = false;
            txtSearchTransaction.TextAlign = HorizontalAlignment.Left;
            txtSearchTransaction.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchTransaction.TrailingIcon = null;
            txtSearchTransaction.UseSystemPasswordChar = false;
            txtSearchTransaction.ValidatingType = null;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvTransactions.ColumnHeadersHeight = 40;
            dgvTransactions.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvTransactions.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvTransactions.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvTransactions.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvTransactions.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvTransactions.CurrentTheme.BackColor = Color.White;
            dgvTransactions.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvTransactions.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvTransactions.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvTransactions.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvTransactions.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvTransactions.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvTransactions.CurrentTheme.Name = null;
            dgvTransactions.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvTransactions.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvTransactions.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvTransactions.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvTransactions.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle9;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.GridColor = Color.FromArgb(221, 238, 255);
            dgvTransactions.HeaderBackColor = Color.DodgerBlue;
            dgvTransactions.HeaderBgColor = Color.Empty;
            dgvTransactions.HeaderForeColor = Color.White;
            dgvTransactions.Location = new Point(47, 119);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowTemplate.Height = 40;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(792, 317);
            dgvTransactions.TabIndex = 1;
            dgvTransactions.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddTransaction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddTransaction.Depth = 0;
            btnAddTransaction.HighEmphasis = true;
            btnAddTransaction.Icon = null;
            btnAddTransaction.Location = new Point(47, 460);
            btnAddTransaction.Margin = new Padding(4, 6, 4, 6);
            btnAddTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.NoAccentTextColor = Color.Empty;
            btnAddTransaction.Size = new Size(64, 36);
            btnAddTransaction.TabIndex = 2;
            btnAddTransaction.Text = "Add";
            btnAddTransaction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddTransaction.UseAccentColor = false;
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnEditTransaction
            // 
            btnEditTransaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditTransaction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditTransaction.Depth = 0;
            btnEditTransaction.HighEmphasis = true;
            btnEditTransaction.Icon = null;
            btnEditTransaction.Location = new Point(144, 460);
            btnEditTransaction.Margin = new Padding(4, 6, 4, 6);
            btnEditTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditTransaction.Name = "btnEditTransaction";
            btnEditTransaction.NoAccentTextColor = Color.Empty;
            btnEditTransaction.Size = new Size(64, 36);
            btnEditTransaction.TabIndex = 3;
            btnEditTransaction.Text = "Edit";
            btnEditTransaction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditTransaction.UseAccentColor = false;
            btnEditTransaction.UseVisualStyleBackColor = true;
            btnEditTransaction.Click += btnEditTransaction_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteTransaction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteTransaction.Depth = 0;
            btnDeleteTransaction.HighEmphasis = true;
            btnDeleteTransaction.Icon = null;
            btnDeleteTransaction.Location = new Point(239, 460);
            btnDeleteTransaction.Margin = new Padding(4, 6, 4, 6);
            btnDeleteTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.NoAccentTextColor = Color.Empty;
            btnDeleteTransaction.Size = new Size(73, 36);
            btnDeleteTransaction.TabIndex = 4;
            btnDeleteTransaction.Text = "Delete";
            btnDeleteTransaction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteTransaction.UseAccentColor = false;
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // FrmTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 538);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnEditTransaction);
            Controls.Add(btnAddTransaction);
            Controls.Add(dgvTransactions);
            Controls.Add(txtSearchTransaction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTransaction";
            Text = "FrmTransaction";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchTransaction;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTransactions;
        private MaterialSkin.Controls.MaterialButton btnAddTransaction;
        private MaterialSkin.Controls.MaterialButton btnEditTransaction;
        private MaterialSkin.Controls.MaterialButton btnDeleteTransaction;
    }
}