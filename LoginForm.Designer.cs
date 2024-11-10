namespace Mini_Cs
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            timer1 = new System.Windows.Forms.Timer(components);
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            pictureBox1 = new PictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            checkBox1 = new CheckBox();
            lblDate = new Label();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(71, 281);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(241, 23);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(71, 331);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(241, 23);
            tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.Aqua;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(107, 397);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(141, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(42, 281);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 23);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Segoe UI", 9F);
            bunifuLabel1.Location = new Point(71, 260);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(53, 15);
            bunifuLabel1.TabIndex = 5;
            bunifuLabel1.Text = "Username";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Segoe UI", 9F);
            bunifuLabel2.Location = new Point(71, 310);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(57, 15);
            bunifuLabel2.TabIndex = 5;
            bunifuLabel2.Text = "Passowrod";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGradientPanel1
            // 
            bunifuGradientPanel1.BackColor = Color.Transparent;
            bunifuGradientPanel1.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel1.BackgroundImage");
            bunifuGradientPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel1.BorderRadius = 1;
            bunifuGradientPanel1.Controls.Add(lblTime);
            bunifuGradientPanel1.Controls.Add(lblDate);
            bunifuGradientPanel1.Controls.Add(checkBox1);
            bunifuGradientPanel1.Controls.Add(bunifuLabel2);
            bunifuGradientPanel1.Controls.Add(pictureBox1);
            bunifuGradientPanel1.Controls.Add(bunifuLabel1);
            bunifuGradientPanel1.Controls.Add(tbPassword);
            bunifuGradientPanel1.Controls.Add(tbUsername);
            bunifuGradientPanel1.Controls.Add(iconPictureBox2);
            bunifuGradientPanel1.Controls.Add(iconPictureBox1);
            bunifuGradientPanel1.Controls.Add(btnLogin);
            bunifuGradientPanel1.Dock = DockStyle.Fill;
            bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(205, 203, 192);
            bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(139, 145, 181);
            bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel1.GradientTopRight = Color.FromArgb(99, 120, 175);
            bunifuGradientPanel1.Location = new Point(0, 0);
            bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            bunifuGradientPanel1.Quality = 10;
            bunifuGradientPanel1.Size = new Size(354, 466);
            bunifuGradientPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_design;
            pictureBox1.Location = new Point(100, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 23;
            iconPictureBox2.Location = new Point(42, 331);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(23, 23);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(204, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(100, 188);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(150, 23);
            lblDate.TabIndex = 7;
            lblDate.Text = "Date Label";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.Location = new Point(98, 220);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 23);
            lblTime.TabIndex = 7;
            lblTime.Text = "Time Label";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(354, 466);
            Controls.Add(bunifuGradientPanel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            bunifuGradientPanel1.ResumeLayout(false);
            bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbUsername;
        private TextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblTime;
        private Label lblDate;
    }
}
