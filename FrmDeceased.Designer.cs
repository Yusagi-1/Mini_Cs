namespace Mini_Cs
{
    partial class FrmDeceased
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnEditDeceased = new MaterialSkin.Controls.MaterialButton();
            btnAddDeceased = new MaterialSkin.Controls.MaterialButton();
            dgvDeceased = new Bunifu.UI.WinForms.BunifuDataGridView();
            txtSearchDeceased = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnDeleteDeceased = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvDeceased).BeginInit();
            SuspendLayout();
            // 
            // btnEditDeceased
            // 
            btnEditDeceased.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditDeceased.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditDeceased.Depth = 0;
            btnEditDeceased.HighEmphasis = true;
            btnEditDeceased.Icon = null;
            btnEditDeceased.Location = new Point(147, 453);
            btnEditDeceased.Margin = new Padding(4, 6, 4, 6);
            btnEditDeceased.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditDeceased.Name = "btnEditDeceased";
            btnEditDeceased.NoAccentTextColor = Color.Empty;
            btnEditDeceased.Size = new Size(64, 36);
            btnEditDeceased.TabIndex = 8;
            btnEditDeceased.Text = "Edit";
            btnEditDeceased.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditDeceased.UseAccentColor = false;
            btnEditDeceased.UseVisualStyleBackColor = true;
            btnEditDeceased.Click += btnEditDeceased_Click;
            // 
            // btnAddDeceased
            // 
            btnAddDeceased.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddDeceased.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddDeceased.Depth = 0;
            btnAddDeceased.HighEmphasis = true;
            btnAddDeceased.Icon = null;
            btnAddDeceased.Location = new Point(50, 453);
            btnAddDeceased.Margin = new Padding(4, 6, 4, 6);
            btnAddDeceased.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddDeceased.Name = "btnAddDeceased";
            btnAddDeceased.NoAccentTextColor = Color.Empty;
            btnAddDeceased.Size = new Size(64, 36);
            btnAddDeceased.TabIndex = 7;
            btnAddDeceased.Text = "Add";
            btnAddDeceased.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddDeceased.UseAccentColor = false;
            btnAddDeceased.UseVisualStyleBackColor = true;
            btnAddDeceased.Click += btnAddDeceased_Click;
            // 
            // dgvDeceased
            // 
            dgvDeceased.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvDeceased.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeceased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeceased.BorderStyle = BorderStyle.None;
            dgvDeceased.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeceased.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDeceased.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDeceased.ColumnHeadersHeight = 40;
            dgvDeceased.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvDeceased.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvDeceased.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvDeceased.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvDeceased.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvDeceased.CurrentTheme.BackColor = Color.White;
            dgvDeceased.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvDeceased.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvDeceased.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvDeceased.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvDeceased.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvDeceased.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvDeceased.CurrentTheme.Name = null;
            dgvDeceased.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvDeceased.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvDeceased.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvDeceased.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvDeceased.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDeceased.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDeceased.EnableHeadersVisualStyles = false;
            dgvDeceased.GridColor = Color.FromArgb(221, 238, 255);
            dgvDeceased.HeaderBackColor = Color.DodgerBlue;
            dgvDeceased.HeaderBgColor = Color.Empty;
            dgvDeceased.HeaderForeColor = Color.White;
            dgvDeceased.Location = new Point(50, 112);
            dgvDeceased.Name = "dgvDeceased";
            dgvDeceased.RowHeadersVisible = false;
            dgvDeceased.RowTemplate.Height = 40;
            dgvDeceased.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeceased.Size = new Size(1063, 317);
            dgvDeceased.TabIndex = 6;
            dgvDeceased.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvDeceased.CellContentClick += dgvDeceased_CellContentClick;
            // 
            // txtSearchDeceased
            // 
            txtSearchDeceased.AllowPromptAsInput = true;
            txtSearchDeceased.AnimateReadOnly = false;
            txtSearchDeceased.AsciiOnly = false;
            txtSearchDeceased.BackgroundImageLayout = ImageLayout.None;
            txtSearchDeceased.BeepOnError = false;
            txtSearchDeceased.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchDeceased.Depth = 0;
            txtSearchDeceased.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchDeceased.HidePromptOnLeave = false;
            txtSearchDeceased.HideSelection = true;
            txtSearchDeceased.InsertKeyMode = InsertKeyMode.Default;
            txtSearchDeceased.LeadingIcon = null;
            txtSearchDeceased.Location = new Point(50, 49);
            txtSearchDeceased.Mask = "";
            txtSearchDeceased.MaxLength = 32767;
            txtSearchDeceased.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchDeceased.Name = "txtSearchDeceased";
            txtSearchDeceased.PasswordChar = '\0';
            txtSearchDeceased.PrefixSuffixText = null;
            txtSearchDeceased.PromptChar = '_';
            txtSearchDeceased.ReadOnly = false;
            txtSearchDeceased.RejectInputOnFirstFailure = false;
            txtSearchDeceased.ResetOnPrompt = true;
            txtSearchDeceased.ResetOnSpace = true;
            txtSearchDeceased.RightToLeft = RightToLeft.No;
            txtSearchDeceased.SelectedText = "";
            txtSearchDeceased.SelectionLength = 0;
            txtSearchDeceased.SelectionStart = 0;
            txtSearchDeceased.ShortcutsEnabled = true;
            txtSearchDeceased.Size = new Size(332, 48);
            txtSearchDeceased.SkipLiterals = true;
            txtSearchDeceased.TabIndex = 5;
            txtSearchDeceased.TabStop = false;
            txtSearchDeceased.TextAlign = HorizontalAlignment.Left;
            txtSearchDeceased.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchDeceased.TrailingIcon = null;
            txtSearchDeceased.UseSystemPasswordChar = false;
            txtSearchDeceased.ValidatingType = null;
            txtSearchDeceased.Click += txtSearchDeceased_Click;
            // 
            // btnDeleteDeceased
            // 
            btnDeleteDeceased.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteDeceased.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteDeceased.Depth = 0;
            btnDeleteDeceased.HighEmphasis = true;
            btnDeleteDeceased.Icon = null;
            btnDeleteDeceased.Location = new Point(243, 453);
            btnDeleteDeceased.Margin = new Padding(4, 6, 4, 6);
            btnDeleteDeceased.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteDeceased.Name = "btnDeleteDeceased";
            btnDeleteDeceased.NoAccentTextColor = Color.Empty;
            btnDeleteDeceased.Size = new Size(73, 36);
            btnDeleteDeceased.TabIndex = 9;
            btnDeleteDeceased.Text = "Delete";
            btnDeleteDeceased.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteDeceased.UseAccentColor = false;
            btnDeleteDeceased.UseVisualStyleBackColor = true;
            btnDeleteDeceased.Click += btnDeleteDeceased_Click;
            // 
            // FrmDeceased
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 538);
            Controls.Add(btnDeleteDeceased);
            Controls.Add(btnEditDeceased);
            Controls.Add(btnAddDeceased);
            Controls.Add(dgvDeceased);
            Controls.Add(txtSearchDeceased);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDeceased";
            Text = "FrmDeceased";
            ((System.ComponentModel.ISupportInitialize)dgvDeceased).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnEditDeceased;
        private MaterialSkin.Controls.MaterialButton btnAddDeceased;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDeceased;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchDeceased;
        private MaterialSkin.Controls.MaterialButton btnDeleteDeceased;
    }
}