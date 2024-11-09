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
            tbUsername = new TextBox();
            label1 = new Label();
            tbPassword = new TextBox();
            label2 = new Label();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            cbShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblDate = new Label();
            panel1 = new Panel();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(263, 120);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(192, 23);
            tbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 102);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(263, 181);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(192, 23);
            tbPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 163);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
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
            btnLogin.Location = new Point(280, 285);
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
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(347, 210);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(108, 19);
            cbShowPassword.TabIndex = 4;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_design;
            pictureBox1.Location = new Point(55, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.CornflowerBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(234, 120);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 23);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.CornflowerBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 23;
            iconPictureBox2.Location = new Point(234, 181);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(23, 23);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 7;
            iconPictureBox2.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.FromArgb(30, 0, 0, 0);
            lblDate.Dock = DockStyle.Top;
            lblDate.Location = new Point(0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(254, 51);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
            panel1.Location = new Point(222, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 99);
            panel1.TabIndex = 9;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Bottom;
            lblTime.Location = new Point(0, 51);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(254, 48);
            lblTime.TabIndex = 9;
            lblTime.Text = "Time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(476, 437);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(pictureBox1);
            Controls.Add(cbShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbUsername;
        private Label label1;
        private TextBox tbPassword;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private CheckBox cbShowPassword;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblDate;
        private Panel panel1;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
