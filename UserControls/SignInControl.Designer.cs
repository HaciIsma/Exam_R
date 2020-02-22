namespace Exam_R
{
    partial class SignInControl
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.passwordbox = new MetroFramework.Controls.MetroTextBox();
            this.emailbox = new MetroFramework.Controls.MetroTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(13, 58);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Email";
            // 
            // passwordbox
            // 
            // 
            // 
            // 
            this.passwordbox.CustomButton.Image = null;
            this.passwordbox.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.passwordbox.CustomButton.Name = "";
            this.passwordbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordbox.CustomButton.TabIndex = 1;
            this.passwordbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordbox.CustomButton.UseSelectable = true;
            this.passwordbox.CustomButton.Visible = false;
            this.passwordbox.Lines = new string[0];
            this.passwordbox.Location = new System.Drawing.Point(16, 80);
            this.passwordbox.MaxLength = 32767;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '\0';
            this.passwordbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordbox.SelectedText = "";
            this.passwordbox.SelectionLength = 0;
            this.passwordbox.SelectionStart = 0;
            this.passwordbox.ShortcutsEnabled = true;
            this.passwordbox.Size = new System.Drawing.Size(209, 23);
            this.passwordbox.TabIndex = 10;
            this.passwordbox.UseSelectable = true;
            this.passwordbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailbox
            // 
            // 
            // 
            // 
            this.emailbox.CustomButton.Image = null;
            this.emailbox.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.emailbox.CustomButton.Name = "";
            this.emailbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailbox.CustomButton.TabIndex = 1;
            this.emailbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailbox.CustomButton.UseSelectable = true;
            this.emailbox.CustomButton.Visible = false;
            this.emailbox.Lines = new string[0];
            this.emailbox.Location = new System.Drawing.Point(16, 32);
            this.emailbox.MaxLength = 32767;
            this.emailbox.Name = "emailbox";
            this.emailbox.PasswordChar = '\0';
            this.emailbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailbox.SelectedText = "";
            this.emailbox.SelectionLength = 0;
            this.emailbox.SelectionStart = 0;
            this.emailbox.ShortcutsEnabled = true;
            this.emailbox.Size = new System.Drawing.Size(209, 23);
            this.emailbox.TabIndex = 9;
            this.emailbox.UseSelectable = true;
            this.emailbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(92, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Sign In";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // SignInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.emailbox);
            this.Name = "SignInControl";
            this.Size = new System.Drawing.Size(243, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroTextBox passwordbox;
        private MetroFramework.Controls.MetroTextBox emailbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
