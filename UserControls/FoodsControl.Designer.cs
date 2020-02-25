namespace Exam_R.UserControls
{
    partial class FoodsControl
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
            this.pics = new Manina.Windows.Forms.ImageListView();
            this.SuspendLayout();
            // 
            // pics
            // 
            this.pics.Location = new System.Drawing.Point(3, 3);
            this.pics.Name = "pics";
            this.pics.PersistentCacheDirectory = "";
            this.pics.PersistentCacheSize = ((long)(100));
            this.pics.Size = new System.Drawing.Size(545, 505);
            this.pics.TabIndex = 0;
            this.pics.UseWIC = true;
            this.pics.ItemClick += new Manina.Windows.Forms.ItemClickEventHandler(this.pics_ItemClick);
            // 
            // FoodsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pics);
            this.Name = "FoodsControl";
            this.Size = new System.Drawing.Size(554, 516);
            this.ResumeLayout(false);

        }

        #endregion

        private Manina.Windows.Forms.ImageListView pics;
    }
}
