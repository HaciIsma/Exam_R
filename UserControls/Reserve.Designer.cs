namespace Exam_R.UserControls
{
    partial class Reserve
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.Button = new MetroFramework.Controls.MetroButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cb = new System.Windows.Forms.CheckBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Button);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.materialLabel11);
            this.panel6.Controls.Add(this.materialLabel12);
            this.panel6.Controls.Add(this.cb);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 75);
            this.panel6.TabIndex = 5;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(238, 11);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(76, 57);
            this.Button.TabIndex = 5;
            this.Button.Text = "Reserve";
            this.Button.UseSelectable = true;
            this.Button.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Exam_R.Properties.Resources.table;
            this.pictureBox6.Location = new System.Drawing.Point(0, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(100, 39);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(89, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "Table count:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(100, 11);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(81, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Table num:";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(238, 54);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(15, 14);
            this.cb.TabIndex = 5;
            this.cb.UseVisualStyleBackColor = true;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "Reserve";
            this.Size = new System.Drawing.Size(322, 82);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroButton Button;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.CheckBox cb;
    }
}
