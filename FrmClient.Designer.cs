namespace Mini_Cs
{
    partial class FrmClient
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
            txtSearchClient = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dgvClients = new Bunifu.UI.WinForms.BunifuDataGridView();
            btnAddClient = new MaterialSkin.Controls.MaterialButton();
            btnEditClient = new MaterialSkin.Controls.MaterialButton();
            btnDeleteClient = new MaterialSkin.Controls.MaterialButton();
            btnViewDetails = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // txtSearchClient
            // 
            txtSearchClient.AllowPromptAsInput = true;
            txtSearchClient.AnimateReadOnly = false;
            txtSearchClient.AsciiOnly = false;
            txtSearchClient.BackgroundImageLayout = ImageLayout.None;
            txtSearchClient.BeepOnError = false;
            txtSearchClient.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchClient.Depth = 0;
            txtSearchClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchClient.HidePromptOnLeave = false;
            txtSearchClient.HideSelection = true;
            txtSearchClient.InsertKeyMode = InsertKeyMode.Default;
            txtSearchClient.LeadingIcon = null;
            txtSearchClient.Location = new Point(47, 56);
            txtSearchClient.Mask = "";
            txtSearchClient.MaxLength = 32767;
            txtSearchClient.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.PasswordChar = '\0';
            txtSearchClient.PrefixSuffixText = null;
            txtSearchClient.PromptChar = '_';
            txtSearchClient.ReadOnly = false;
            txtSearchClient.RejectInputOnFirstFailure = false;
            txtSearchClient.ResetOnPrompt = true;
            txtSearchClient.ResetOnSpace = true;
            txtSearchClient.RightToLeft = RightToLeft.No;
            txtSearchClient.SelectedText = "";
            txtSearchClient.SelectionLength = 0;
            txtSearchClient.SelectionStart = 0;
            txtSearchClient.ShortcutsEnabled = true;
            txtSearchClient.Size = new Size(332, 48);
            txtSearchClient.SkipLiterals = true;
            txtSearchClient.TabIndex = 0;
            txtSearchClient.TabStop = false;
            txtSearchClient.TextAlign = HorizontalAlignment.Left;
            txtSearchClient.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearchClient.TrailingIcon = null;
            txtSearchClient.UseSystemPasswordChar = false;
            txtSearchClient.ValidatingType = null;
            txtSearchClient.Click += txtSearchClient_Click;
            // 
            // dgvClients
            // 
            dgvClients.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.ColumnHeadersHeight = 40;
            dgvClients.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvClients.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvClients.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvClients.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvClients.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvClients.CurrentTheme.BackColor = Color.White;
            dgvClients.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvClients.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dgvClients.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvClients.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvClients.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvClients.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvClients.CurrentTheme.Name = null;
            dgvClients.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvClients.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvClients.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvClients.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvClients.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.GridColor = Color.FromArgb(221, 238, 255);
            dgvClients.HeaderBackColor = Color.DodgerBlue;
            dgvClients.HeaderBgColor = Color.Empty;
            dgvClients.HeaderForeColor = Color.White;
            dgvClients.Location = new Point(47, 119);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersVisible = false;
            dgvClients.RowTemplate.Height = 40;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(1010, 317);
            dgvClients.TabIndex = 1;
            dgvClients.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
            // 
            // btnAddClient
            // 
            btnAddClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddClient.Depth = 0;
            btnAddClient.HighEmphasis = true;
            btnAddClient.Icon = null;
            btnAddClient.Location = new Point(47, 460);
            btnAddClient.Margin = new Padding(4, 6, 4, 6);
            btnAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddClient.Name = "btnAddClient";
            btnAddClient.NoAccentTextColor = Color.Empty;
            btnAddClient.Size = new Size(64, 36);
            btnAddClient.TabIndex = 2;
            btnAddClient.Text = "Add";
            btnAddClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddClient.UseAccentColor = false;
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditClient.Depth = 0;
            btnEditClient.HighEmphasis = true;
            btnEditClient.Icon = null;
            btnEditClient.Location = new Point(144, 460);
            btnEditClient.Margin = new Padding(4, 6, 4, 6);
            btnEditClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditClient.Name = "btnEditClient";
            btnEditClient.NoAccentTextColor = Color.Empty;
            btnEditClient.Size = new Size(64, 36);
            btnEditClient.TabIndex = 3;
            btnEditClient.Text = "Edit";
            btnEditClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditClient.UseAccentColor = false;
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteClient.Depth = 0;
            btnDeleteClient.HighEmphasis = true;
            btnDeleteClient.Icon = null;
            btnDeleteClient.Location = new Point(339, 460);
            btnDeleteClient.Margin = new Padding(4, 6, 4, 6);
            btnDeleteClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.NoAccentTextColor = Color.Empty;
            btnDeleteClient.Size = new Size(73, 36);
            btnDeleteClient.TabIndex = 4;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteClient.UseAccentColor = false;
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewDetails.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewDetails.Depth = 0;
            btnViewDetails.HighEmphasis = true;
            btnViewDetails.Icon = null;
            btnViewDetails.Location = new Point(244, 460);
            btnViewDetails.Margin = new Padding(4, 6, 4, 6);
            btnViewDetails.MouseState = MaterialSkin.MouseState.HOVER;
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.NoAccentTextColor = Color.Empty;
            btnViewDetails.Size = new Size(64, 36);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View";
            btnViewDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewDetails.UseAccentColor = false;
            btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // FrmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 538);
            Controls.Add(btnViewDetails);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(dgvClients);
            Controls.Add(txtSearchClient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClient";
            Text = "FrmClient";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchClient;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvClients;
        private MaterialSkin.Controls.MaterialButton btnAddClient;
        private MaterialSkin.Controls.MaterialButton btnEditClient;
        private MaterialSkin.Controls.MaterialButton btnDeleteClient;
        private MaterialSkin.Controls.MaterialButton btnViewDetails;
    }
}