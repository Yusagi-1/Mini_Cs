namespace Mini_Cs.TransacDetails
{
    partial class ViewTransac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransac));
            btnExit = new MaterialSkin.Controls.MaterialButton();
            dgvTransacDetails = new Bunifu.UI.WinForms.BunifuDataGridView();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)dgvTransacDetails).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(1061, 15);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(64, 36);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExist_Click;
            // 
            // dgvTransacDetails
            // 
            dgvTransacDetails.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvTransacDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransacDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvTransacDetails.BorderStyle = BorderStyle.None;
            dgvTransacDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransacDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransacDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransacDetails.ColumnHeadersHeight = 40;
            dgvTransacDetails.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvTransacDetails.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvTransacDetails.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvTransacDetails.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvTransacDetails.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvTransacDetails.CurrentTheme.BackColor = Color.White;
            dgvTransacDetails.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dgvTransacDetails.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(255, 128, 128);
            dgvTransacDetails.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dgvTransacDetails.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvTransacDetails.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dgvTransacDetails.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dgvTransacDetails.CurrentTheme.Name = null;
            dgvTransacDetails.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvTransacDetails.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvTransacDetails.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvTransacDetails.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgvTransacDetails.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransacDetails.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransacDetails.EnableHeadersVisualStyles = false;
            dgvTransacDetails.GridColor = Color.FromArgb(221, 238, 255);
            dgvTransacDetails.HeaderBackColor = Color.FromArgb(255, 128, 128);
            dgvTransacDetails.HeaderBgColor = Color.Empty;
            dgvTransacDetails.HeaderForeColor = Color.White;
            dgvTransacDetails.Location = new Point(12, 68);
            dgvTransacDetails.Name = "dgvTransacDetails";
            dgvTransacDetails.RowHeadersVisible = false;
            dgvTransacDetails.RowTemplate.Height = 40;
            dgvTransacDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransacDetails.Size = new Size(1114, 381);
            dgvTransacDetails.TabIndex = 1;
            dgvTransacDetails.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dgvTransacDetails.CellContentClick += dgvTransacDetails_CellContentClick;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(12, 25);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(246, 37);
            bunifuLabel1.TabIndex = 2;
            bunifuLabel1.Text = "Transaction Details";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ViewTransac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1138, 461);
            Controls.Add(bunifuLabel1);
            Controls.Add(dgvTransacDetails);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewTransac";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransacDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTransacDetails;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}