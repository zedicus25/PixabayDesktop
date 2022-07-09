using System.ComponentModel;

namespace Pixabay.View.CustomControlls
{
    partial class PreviewImageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.previewPB = new System.Windows.Forms.PictureBox();
            this.tag1L = new System.Windows.Forms.Label();
            this.likePB = new System.Windows.Forms.PictureBox();
            this.likesL = new System.Windows.Forms.Label();
            this.commentsL = new System.Windows.Forms.Label();
            this.commentsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPB
            // 
            this.previewPB.Location = new System.Drawing.Point(0, 0);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(471, 314);
            this.previewPB.TabIndex = 0;
            this.previewPB.TabStop = false;
            // 
            // tag1L
            // 
            this.tag1L.AutoSize = true;
            this.tag1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tag1L.Location = new System.Drawing.Point(3, 326);
            this.tag1L.Name = "tag1L";
            this.tag1L.Size = new System.Drawing.Size(51, 20);
            this.tag1L.TabIndex = 1;
            this.tag1L.Text = "label1";
            this.tag1L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // likePB
            // 
            this.likePB.Location = new System.Drawing.Point(277, 317);
            this.likePB.Name = "likePB";
            this.likePB.Size = new System.Drawing.Size(35, 35);
            this.likePB.TabIndex = 2;
            this.likePB.TabStop = false;
            // 
            // likesL
            // 
            this.likesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likesL.Location = new System.Drawing.Point(318, 317);
            this.likesL.Name = "likesL";
            this.likesL.Size = new System.Drawing.Size(51, 35);
            this.likesL.TabIndex = 3;
            this.likesL.Text = "label1";
            this.likesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentsL
            // 
            this.commentsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentsL.Location = new System.Drawing.Point(417, 317);
            this.commentsL.Name = "commentsL";
            this.commentsL.Size = new System.Drawing.Size(51, 35);
            this.commentsL.TabIndex = 5;
            this.commentsL.Text = "label1";
            this.commentsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentsPB
            // 
            this.commentsPB.Location = new System.Drawing.Point(376, 317);
            this.commentsPB.Name = "commentsPB";
            this.commentsPB.Size = new System.Drawing.Size(35, 35);
            this.commentsPB.TabIndex = 4;
            this.commentsPB.TabStop = false;
            // 
            // PreviewImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.commentsL);
            this.Controls.Add(this.commentsPB);
            this.Controls.Add(this.likesL);
            this.Controls.Add(this.likePB);
            this.Controls.Add(this.tag1L);
            this.Controls.Add(this.previewPB);
            this.Name = "PreviewImageControl";
            this.Size = new System.Drawing.Size(471, 357);
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPB;
        private System.Windows.Forms.Label tag1L;
        private System.Windows.Forms.PictureBox likePB;
        private System.Windows.Forms.Label likesL;
        private System.Windows.Forms.Label commentsL;
        private System.Windows.Forms.PictureBox commentsPB;
    }
}