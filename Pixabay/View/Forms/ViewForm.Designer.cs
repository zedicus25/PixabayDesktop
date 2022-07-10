namespace Pixabay.View
{
    partial class ViewForm
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
            this.mainImagePB = new System.Windows.Forms.PictureBox();
            this.tagsL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainImagePB
            // 
            this.mainImagePB.Location = new System.Drawing.Point(12, 12);
            this.mainImagePB.Name = "mainImagePB";
            this.mainImagePB.Size = new System.Drawing.Size(640, 427);
            this.mainImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImagePB.TabIndex = 0;
            this.mainImagePB.TabStop = false;
            // 
            // tagsL
            // 
            this.tagsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagsL.Location = new System.Drawing.Point(12, 455);
            this.tagsL.Name = "tagsL";
            this.tagsL.Size = new System.Drawing.Size(640, 79);
            this.tagsL.TabIndex = 1;
            this.tagsL.Text = "label1";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 572);
            this.Controls.Add(this.tagsL);
            this.Controls.Add(this.mainImagePB);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImagePB;
        private System.Windows.Forms.Label tagsL;
    }
}