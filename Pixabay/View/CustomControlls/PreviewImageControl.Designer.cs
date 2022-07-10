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
            this.tagsL = new System.Windows.Forms.Label();
            this.likesL = new System.Windows.Forms.Label();
            this.commentsL = new System.Windows.Forms.Label();
            this.commentsPB = new System.Windows.Forms.PictureBox();
            this.likePB = new System.Windows.Forms.PictureBox();
            this.previewPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tagsL
            // 
            this.tagsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagsL.Location = new System.Drawing.Point(3, 317);
            this.tagsL.Name = "tagsL";
            this.tagsL.Size = new System.Drawing.Size(465, 35);
            this.tagsL.TabIndex = 1;
            this.tagsL.Text = "label1";
            this.tagsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // likesL
            // 
            this.likesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likesL.Location = new System.Drawing.Point(44, 367);
            this.likesL.Name = "likesL";
            this.likesL.Size = new System.Drawing.Size(51, 23);
            this.likesL.TabIndex = 3;
            this.likesL.Text = "label1";
            this.likesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentsL
            // 
            this.commentsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentsL.Location = new System.Drawing.Point(142, 355);
            this.commentsL.Name = "commentsL";
            this.commentsL.Size = new System.Drawing.Size(51, 35);
            this.commentsL.TabIndex = 5;
            this.commentsL.Text = "label1";
            this.commentsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commentsPB
            // 
            this.commentsPB.Image = global::Pixabay.Properties.Resources.comment;
            this.commentsPB.Location = new System.Drawing.Point(101, 355);
            this.commentsPB.Name = "commentsPB";
            this.commentsPB.Size = new System.Drawing.Size(25, 25);
            this.commentsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentsPB.TabIndex = 4;
            this.commentsPB.TabStop = false;
            // 
            // likePB
            // 
            this.likePB.Image = global::Pixabay.Properties.Resources.like;
            this.likePB.Location = new System.Drawing.Point(3, 355);
            this.likePB.Name = "likePB";
            this.likePB.Size = new System.Drawing.Size(25, 25);
            this.likePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likePB.TabIndex = 2;
            this.likePB.TabStop = false;
            // 
            // previewPB
            // 
            this.previewPB.Location = new System.Drawing.Point(0, 0);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(471, 314);
            this.previewPB.TabIndex = 0;
            this.previewPB.TabStop = false;
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
            this.Controls.Add(this.tagsL);
            this.Controls.Add(this.previewPB);
            this.Name = "PreviewImageControl";
            this.Size = new System.Drawing.Size(471, 397);
            ((System.ComponentModel.ISupportInitialize)(this.commentsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPB;
        private System.Windows.Forms.Label tagsL;
        private System.Windows.Forms.PictureBox likePB;
        private System.Windows.Forms.Label likesL;
        private System.Windows.Forms.Label commentsL;
        private System.Windows.Forms.PictureBox commentsPB;
    }
}