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
            headerPanel = new Panel();
            panelNavBar = new Bunifu.UI.WinForms.BunifuGradientPanel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnUserManagement = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnTransaction = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            picBoxPanel = new Panel();
            pictureBox1 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            panelMain = new Panel();
            panelNavBar.SuspendLayout();
            picBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnHome.Location = new Point(0, 219);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(219, 60);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(99, 120, 189);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1380, 0);
            headerPanel.TabIndex = 1;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Transparent;
            panelNavBar.BackgroundImage = (Image)resources.GetObject("panelNavBar.BackgroundImage");
            panelNavBar.BackgroundImageLayout = ImageLayout.Stretch;
            panelNavBar.BorderRadius = 0;
            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Controls.Add(btnUserManagement);
            panelNavBar.Controls.Add(btnReports);
            panelNavBar.Controls.Add(btnTransaction);
            panelNavBar.Controls.Add(btnCustomer);
            panelNavBar.Controls.Add(btnHome);
            panelNavBar.Controls.Add(picBoxPanel);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.GradientBottomLeft = Color.FromArgb(139, 145, 181);
            panelNavBar.GradientBottomRight = Color.FromArgb(139, 145, 181);
            panelNavBar.GradientTopLeft = Color.FromArgb(99, 120, 175);
            panelNavBar.GradientTopRight = Color.FromArgb(99, 120, 175);
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Quality = 10;
            panelNavBar.Size = new Size(219, 788);
            panelNavBar.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnLogout.IconColor = Color.Black;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 30;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 718);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(219, 70);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnUserManagement.IconColor = Color.Black;
            btnUserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserManagement.IconSize = 30;
            btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.Location = new Point(0, 459);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(219, 60);
            btnUserManagement.TabIndex = 14;
            btnUserManagement.Text = "Reports";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            btnReports.IconColor = Color.Black;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 30;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 399);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(219, 60);
            btnReports.TabIndex = 13;
            btnReports.Text = "Transaction";
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
            btnTransaction.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnTransaction.IconColor = Color.Black;
            btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransaction.IconSize = 30;
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 339);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(219, 60);
            btnTransaction.TabIndex = 12;
            btnTransaction.Text = "Search";
            btnTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnCustomer.IconColor = Color.Black;
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.IconSize = 30;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 279);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(219, 60);
            btnCustomer.TabIndex = 10;
            btnCustomer.Text = "Reservation";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click_1;
            // 
            // picBoxPanel
            // 
            picBoxPanel.Controls.Add(pictureBox1);
            picBoxPanel.Dock = DockStyle.Top;
            picBoxPanel.Location = new Point(0, 0);
            picBoxPanel.Name = "picBoxPanel";
            picBoxPanel.Size = new Size(219, 219);
            picBoxPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._362653007_238664698993364_1155547492567031378_n;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(1568, 21);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            bunifuGradientPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bunifuGradientPanel2.BackColor = Color.Transparent;
            bunifuGradientPanel2.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel2.BackgroundImage");
            bunifuGradientPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel2.BorderRadius = 0;
            bunifuGradientPanel2.Controls.Add(iconPictureBox1);
            bunifuGradientPanel2.GradientBottomLeft = Color.FromArgb(139, 145, 181);
            bunifuGradientPanel2.GradientBottomRight = Color.FromArgb(139, 145, 181);
            bunifuGradientPanel2.GradientTopLeft = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel2.GradientTopRight = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel2.Location = new Point(219, 0);
            bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            bunifuGradientPanel2.Quality = 10;
            bunifuGradientPanel2.Size = new Size(1222, 85);
            bunifuGradientPanel2.TabIndex = 10;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(219, 91);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1159, 694);
            panelMain.TabIndex = 11;
            panelMain.Paint += panelMain_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 788);
            Controls.Add(bunifuGradientPanel2);
            Controls.Add(panelMain);
            Controls.Add(panelNavBar);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            panelNavBar.ResumeLayout(false);
            picBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            bunifuGradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel headerPanel;
        private FontAwesome.Sharp.IconButton btnHome;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelNavBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel picBoxPanel;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private FontAwesome.Sharp.IconButton btnUserManagement;
        private FontAwesome.Sharp.IconButton btnReports;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}