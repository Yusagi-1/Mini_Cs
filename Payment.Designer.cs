namespace Mini_Cs
{
    partial class Payment
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
            btnRegularServices = new MaterialSkin.Controls.MaterialButton();
            btnSeniorCitizen = new MaterialSkin.Controls.MaterialButton();
            panelChildForm = new Panel();
            SuspendLayout();
            // 
            // btnRegularServices
            // 
            btnRegularServices.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegularServices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegularServices.Depth = 0;
            btnRegularServices.HighEmphasis = true;
            btnRegularServices.Icon = null;
            btnRegularServices.Location = new Point(13, 15);
            btnRegularServices.Margin = new Padding(4, 6, 4, 6);
            btnRegularServices.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegularServices.Name = "btnRegularServices";
            btnRegularServices.NoAccentTextColor = Color.Empty;
            btnRegularServices.Size = new Size(156, 36);
            btnRegularServices.TabIndex = 1;
            btnRegularServices.Text = "Regular Services";
            btnRegularServices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegularServices.UseAccentColor = false;
            btnRegularServices.UseVisualStyleBackColor = true;
            btnRegularServices.Click += btnRegularServices_Click;
            // 
            // btnSeniorCitizen
            // 
            btnSeniorCitizen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSeniorCitizen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSeniorCitizen.Depth = 0;
            btnSeniorCitizen.HighEmphasis = true;
            btnSeniorCitizen.Icon = null;
            btnSeniorCitizen.Location = new Point(202, 15);
            btnSeniorCitizen.Margin = new Padding(4, 6, 4, 6);
            btnSeniorCitizen.MouseState = MaterialSkin.MouseState.HOVER;
            btnSeniorCitizen.Name = "btnSeniorCitizen";
            btnSeniorCitizen.NoAccentTextColor = Color.Empty;
            btnSeniorCitizen.Size = new Size(202, 36);
            btnSeniorCitizen.TabIndex = 2;
            btnSeniorCitizen.Text = "Senior Citizen Services";
            btnSeniorCitizen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSeniorCitizen.UseAccentColor = false;
            btnSeniorCitizen.UseVisualStyleBackColor = true;
            btnSeniorCitizen.Click += btnSeniorCitizen_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Location = new Point(13, 69);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(775, 460);
            panelChildForm.TabIndex = 3;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(panelChildForm);
            Controls.Add(btnSeniorCitizen);
            Controls.Add(btnRegularServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRegularServices;
        private MaterialSkin.Controls.MaterialButton btnSeniorCitizen;
        private Panel panelChildForm;
    }
}