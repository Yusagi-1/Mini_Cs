namespace Mini_Cs
{
    partial class ucDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDays));
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            bunifuPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.White;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(bunifuLabel1);
            bunifuPanel1.Controls.Add(checkBox1);
            bunifuPanel1.Controls.Add(label1);
            bunifuPanel1.Dock = DockStyle.Fill;
            bunifuPanel1.Location = new Point(0, 0);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(148, 71);
            bunifuPanel1.TabIndex = 0;
            bunifuPanel1.Click += bunifuPanel1_Click;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(15, 23);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(117, 22);
            bunifuLabel1.TabIndex = 2;
            bunifuLabel1.Text = "Services for this day";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            bunifuLabel1.Click += bunifuLabel1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // ucDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bunifuPanel1);
            Name = "ucDays";
            Size = new Size(148, 71);
            Load += ucDays_Load;
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Label label1;
        private CheckBox checkBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
