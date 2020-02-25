namespace Exam_R.UserControls
{
    partial class UserInfoControl
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.emailbox = new MaterialSkin.Controls.MaterialLabel();
            this.tnumbox = new MaterialSkin.Controls.MaterialLabel();
            this.mnbox = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Email:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 59);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Reserved Table num:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(20, 90);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Meal name:";
            // 
            // emailbox
            // 
            this.emailbox.AutoSize = true;
            this.emailbox.Depth = 0;
            this.emailbox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailbox.Location = new System.Drawing.Point(71, 26);
            this.emailbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(5, 19);
            this.emailbox.TabIndex = 4;
            this.emailbox.Text = " ";
            // 
            // tnumbox
            // 
            this.tnumbox.AutoSize = true;
            this.tnumbox.Depth = 0;
            this.tnumbox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnumbox.Location = new System.Drawing.Point(172, 59);
            this.tnumbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tnumbox.Name = "tnumbox";
            this.tnumbox.Size = new System.Drawing.Size(5, 19);
            this.tnumbox.TabIndex = 5;
            this.tnumbox.Text = " ";
            // 
            // mnbox
            // 
            this.mnbox.AutoSize = true;
            this.mnbox.Depth = 0;
            this.mnbox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mnbox.Location = new System.Drawing.Point(110, 90);
            this.mnbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mnbox.Name = "mnbox";
            this.mnbox.Size = new System.Drawing.Size(5, 19);
            this.mnbox.TabIndex = 7;
            this.mnbox.Text = " ";
            // 
            // UserInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnbox);
            this.Controls.Add(this.tnumbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserInfoControl";
            this.Size = new System.Drawing.Size(315, 132);
            this.Load += new System.EventHandler(this.UserInfoControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel emailbox;
        private MaterialSkin.Controls.MaterialLabel tnumbox;
        private MaterialSkin.Controls.MaterialLabel mnbox;
    }
}
