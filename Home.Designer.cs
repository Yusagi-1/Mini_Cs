namespace Mini_Cs
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Digital-7", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(99, 120, 175);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "00:00";
            label1.Click += label1_Click;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.Black;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(label1);
            bunifuPanel1.Location = new Point(12, 12);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(126, 58);
            bunifuPanel1.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bunifuPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}