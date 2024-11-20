namespace Mini_Cs
{
    partial class FrmService
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
            txtSearchService = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dgvServices = new Bunifu.UI.WinForms.BunifuDataGridView();
            btnAddService = new MaterialSkin.Controls.MaterialButton();
            btnEditService = new MaterialSkin.Controls.MaterialButton();
            btnDeleteServices = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // txtSearchService
            // 
            txtSearchService.AllowPromptAsInput = true;
            txtSearchService.AnimateReadOnly = false;
            txtSearchService.AsciiOnly = false;
            txtSearchService.BackgroundImageLayout = ImageLayout.None;
            txtSearchService.BeepOnError = false;
            txtSearchService.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchService.Depth = 0;
            txtSearchService.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchService.HidePromptOnLeave = false;
            txtSearchService.HideSelection = true;
            txtSearchService.InsertKeyMode = InsertKeyMode.Default;
            txtSearchService.LeadingIcon = null;
            txtSearchService.Location = new Point(47, 56);
            txtSearchService.Mask = "";
            txtSearchService.MaxLength = 32767;
            txtSearchService.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchService.Name = "txtSearchService";
            txtSearchService.PasswordChar = '\0';
            txtSearchService.PrefixSuffixText = null;
            txtSearchService.PromptChar = '_';
            txtSearchService.ReadOnly = false;
            txtSearchService.RejectInputOnFirstFailure = false;
            txtSearchService.ResetOnPrompt = true;
            txtSearchService.ResetOnSpace = true;
            txtSearchService.RightToLeft = RightToLeft.No;
            txtSearchService.SelectedText = "";
            txtSearchService.SelectionLength = 0;
            txtSearchService.SelectionStart = 0;
            txtSearchService.ShortcutsEnabled = true;
            txtSearchService.Size = new Size(332, 48);
            txtSearchService.SkipLiterals = true;
            txtSearchService.TabIndex = 0;
            txtSearchService.TabStop = false;
            txtSearchService.TextAlign = HorizontalAlignment.Left;
            txtSearchService.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchService.TrailingIcon = null;
            txtSearchService.UseSystemPasswordChar = false;
            txtSearchService.ValidatingType = null;
            // 
            // dgvServices
            // 
            dgvServices.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BorderStyle = BorderStyle.None;
            dgvServices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvServices.ColumnHeadersHeight = 60;
            dgvServices.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvServices.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvServices.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvServices.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvServices.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvServices.CurrentTheme.BackColor = Color.White;
            dgvServices.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvServices.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvServices.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvServices.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvServices.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvServices.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvServices.CurrentTheme.Name = null;
            dgvServices.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvServices.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvServices.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvServices.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvServices.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvServices.DefaultCellStyle = dataGridViewCellStyle3;
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.GridColor = Color.FromArgb(221, 238, 255);
            dgvServices.HeaderBackColor = Color.DodgerBlue;
            dgvServices.HeaderBgColor = Color.Empty;
            dgvServices.HeaderForeColor = Color.White;
            dgvServices.Location = new Point(47, 119);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersVisible = false;
            dgvServices.RowTemplate.Height = 40;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(1083, 317);
            dgvServices.TabIndex = 1;
            dgvServices.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnAddService
            // 
            btnAddService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddService.Depth = 0;
            btnAddService.HighEmphasis = true;
            btnAddService.Icon = null;
            btnAddService.Location = new Point(47, 460);
            btnAddService.Margin = new Padding(4, 6, 4, 6);
            btnAddService.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddService.Name = "btnAddService";
            btnAddService.NoAccentTextColor = Color.Empty;
            btnAddService.Size = new Size(64, 36);
            btnAddService.TabIndex = 2;
            btnAddService.Text = "Add";
            btnAddService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddService.UseAccentColor = false;
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnEditService
            // 
            btnEditService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditService.Depth = 0;
            btnEditService.HighEmphasis = true;
            btnEditService.Icon = null;
            btnEditService.Location = new Point(144, 460);
            btnEditService.Margin = new Padding(4, 6, 4, 6);
            btnEditService.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditService.Name = "btnEditService";
            btnEditService.NoAccentTextColor = Color.Empty;
            btnEditService.Size = new Size(64, 36);
            btnEditService.TabIndex = 3;
            btnEditService.Text = "Edit";
            btnEditService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditService.UseAccentColor = false;
            btnEditService.UseVisualStyleBackColor = true;
            btnEditService.Click += btnEditService_Click;
            // 
            // btnDeleteServices
            // 
            btnDeleteServices.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteServices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteServices.Depth = 0;
            btnDeleteServices.HighEmphasis = true;
            btnDeleteServices.Icon = null;
            btnDeleteServices.Location = new Point(239, 460);
            btnDeleteServices.Margin = new Padding(4, 6, 4, 6);
            btnDeleteServices.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteServices.Name = "btnDeleteServices";
            btnDeleteServices.NoAccentTextColor = Color.Empty;
            btnDeleteServices.Size = new Size(73, 36);
            btnDeleteServices.TabIndex = 4;
            btnDeleteServices.Text = "Delete";
            btnDeleteServices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteServices.UseAccentColor = false;
            btnDeleteServices.UseVisualStyleBackColor = true;
            btnDeleteServices.Click += btnDeleteServices_Click;
            // 
            // FrmService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1255, 538);
            Controls.Add(btnDeleteServices);
            Controls.Add(btnEditService);
            Controls.Add(btnAddService);
            Controls.Add(dgvServices);
            Controls.Add(txtSearchService);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmService";
            Text = "FrmService";
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchService;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvServices;
        private MaterialSkin.Controls.MaterialButton btnAddService;
        private MaterialSkin.Controls.MaterialButton btnEditService;
        private MaterialSkin.Controls.MaterialButton btnDeleteServices;
    }
}