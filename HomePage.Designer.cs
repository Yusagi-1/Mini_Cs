namespace Mini_Cs
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            btnHome = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panelNavBar = new Bunifu.UI.WinForms.BunifuGradientPanel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnAuditLog = new FontAwesome.Sharp.IconButton();
            btnUserManagement = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnTransaction = new FontAwesome.Sharp.IconButton();
            btnService = new FontAwesome.Sharp.IconButton();
            btnDeceased = new FontAwesome.Sharp.IconButton();
            btnClient = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            panelMain = new Panel();
            btnPayment = new FontAwesome.Sharp.IconButton();
            panelNavBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            bunifuGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.Black;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 189);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(212, 60);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(99, 120, 189);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 0);
            panel3.TabIndex = 1;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Transparent;
            panelNavBar.BackgroundImage = (Image)resources.GetObject("panelNavBar.BackgroundImage");
            panelNavBar.BackgroundImageLayout = ImageLayout.Stretch;
            panelNavBar.BorderRadius = 0;

            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Controls.Add(btnAuditLog);
            panelNavBar.Controls.Add(btnUserManagement);
            panelNavBar.Controls.Add(btnReports);
            panelNavBar.Controls.Add(btnPayment);
            panelNavBar.Controls.Add(btnTransaction);
            panelNavBar.Controls.Add(btnService);
            panelNavBar.Controls.Add(btnDeceased);
            panelNavBar.Controls.Add(btnClient);
            panelNavBar.Controls.Add(btnHome);
            panelNavBar.Controls.Add(panel2);
            panelNavBar.GradientBottomLeft = Color.FromArgb(139, 145, 181);
            panelNavBar.GradientBottomRight = Color.FromArgb(139, 145, 181);
            panelNavBar.GradientTopLeft = Color.FromArgb(99, 120, 175);
            panelNavBar.GradientTopRight = Color.FromArgb(99, 120, 175);
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Quality = 10;
            panelNavBar.Size = new Size(212, 789);
            panelNavBar.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnLogout.IconColor = Color.Black;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 30;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 609);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(212, 60);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.Dock = DockStyle.Top;
            btnAuditLog.FlatAppearance.BorderSize = 0;
            btnAuditLog.FlatStyle = FlatStyle.Flat;
            btnAuditLog.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditLog.ForeColor = Color.White;
            btnAuditLog.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnAuditLog.IconColor = Color.Black;
            btnAuditLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuditLog.IconSize = 30;
            btnAuditLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditLog.Location = new Point(0, 549);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(212, 60);
            btnAuditLog.TabIndex = 15;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnUserManagement.IconColor = Color.Black;
            btnUserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserManagement.IconSize = 30;
            btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.Location = new Point(3, 550);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(212, 60);
            btnUserManagement.TabIndex = 14;
            btnUserManagement.Text = "User ";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnReports.IconColor = Color.Black;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 30;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 489);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(212, 60);
            btnReports.TabIndex = 13;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Dock = DockStyle.Top;
            btnTransaction.FlatAppearance.BorderSize = 0;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            btnTransaction.IconColor = Color.Black;
            btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransaction.IconSize = 30;
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 429);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(212, 60);
            btnTransaction.TabIndex = 12;
            btnTransaction.Text = "Transaction";
            btnTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnService
            // 
            btnService.Dock = DockStyle.Top;
            btnService.FlatAppearance.BorderSize = 0;
            btnService.FlatStyle = FlatStyle.Flat;
            btnService.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnService.ForeColor = Color.White;
            btnService.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnService.IconColor = Color.Black;
            btnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnService.IconSize = 30;
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(0, 369);
            btnService.Name = "btnService";
            btnService.Size = new Size(212, 60);
            btnService.TabIndex = 11;
            btnService.Text = "Service ";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnService.UseVisualStyleBackColor = false;
            btnService.Click += btnService_Click;
            // 
            // btnDeceased
            // 
            btnDeceased.Dock = DockStyle.Top;
            btnDeceased.FlatAppearance.BorderSize = 0;
            btnDeceased.FlatStyle = FlatStyle.Flat;
            btnDeceased.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeceased.ForeColor = Color.White;
            btnDeceased.IconChar = FontAwesome.Sharp.IconChar.Cross;
            btnDeceased.IconColor = Color.Black;
            btnDeceased.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeceased.IconSize = 30;
            btnDeceased.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeceased.Location = new Point(0, 309);
            btnDeceased.Name = "btnDeceased";
            btnDeceased.Size = new Size(212, 60);
            btnDeceased.TabIndex = 17;
            btnDeceased.Text = "Deceased Record";
            btnDeceased.TextAlign = ContentAlignment.MiddleLeft;
            btnDeceased.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeceased.UseVisualStyleBackColor = false;
            btnDeceased.Click += btnDeceased_Click;
            // 
            // btnClient
            // 
            btnClient.Dock = DockStyle.Top;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClient.ForeColor = Color.White;
            btnClient.IconChar = FontAwesome.Sharp.IconChar.Male;
            btnClient.IconColor = Color.Black;
            btnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClient.IconSize = 30;
            btnClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnClient.Location = new Point(0, 249);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(212, 60);
            btnClient.TabIndex = 10;
            btnClient.Text = "Client Records";
            btnClient.TextAlign = ContentAlignment.MiddleLeft;
            btnClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(bunifuPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 189);
            panel2.TabIndex = 9;
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 63;
            bunifuPictureBox1.Image = (Image)resources.GetObject("bunifuPictureBox1.Image");
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(41, 12);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(127, 127);
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox1.TabIndex = 8;
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(1148, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            bunifuGradientPanel2.BackColor = Color.Transparent;
            bunifuGradientPanel2.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel2.BackgroundImage");
            bunifuGradientPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel2.BorderRadius = 0;
            bunifuGradientPanel2.Controls.Add(iconPictureBox1);
            bunifuGradientPanel2.Dock = DockStyle.Top;
            bunifuGradientPanel2.GradientBottomLeft = Color.FromArgb(139, 145, 181);
            bunifuGradientPanel2.GradientBottomRight = Color.FromArgb(139, 145, 181);
            bunifuGradientPanel2.GradientTopLeft = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel2.GradientTopRight = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel2.Location = new Point(0, 0);
            bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            bunifuGradientPanel2.Quality = 10;
            bunifuGradientPanel2.Size = new Size(1200, 85);
            bunifuGradientPanel2.TabIndex = 10;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Location = new Point(218, 86);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(982, 703);
            panelMain.TabIndex = 11;
            // 
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            btnPayment.IconColor = Color.Black;
            btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayment.IconSize = 30;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 669);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(212, 60);
            btnPayment.TabIndex = 18;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 788);
            Controls.Add(panelMain);
            Controls.Add(panelNavBar);
            Controls.Add(panel3);
            Controls.Add(bunifuGradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            panelNavBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            bunifuGradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnHome;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelNavBar;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnService;
        private FontAwesome.Sharp.IconButton btnClient;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnAuditLog;
        private FontAwesome.Sharp.IconButton btnUserManagement;
        private FontAwesome.Sharp.IconButton btnReports;
        private Panel panelMain;
        private FontAwesome.Sharp.IconButton btnDeceased;
        private FontAwesome.Sharp.IconButton btnPayment;
    }
}