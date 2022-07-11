namespace Pixabay.View.CustomControlls
{
    partial class PictureInformationControl
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
            this.typeL = new System.Windows.Forms.Label();
            this.resL = new System.Windows.Forms.Label();
            this.viewsL = new System.Windows.Forms.Label();
            this.downloadL = new System.Windows.Forms.Label();
            this.typeValL = new System.Windows.Forms.Label();
            this.resValL = new System.Windows.Forms.Label();
            this.viewsValL = new System.Windows.Forms.Label();
            this.downValL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeL
            // 
            this.typeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeL.Location = new System.Drawing.Point(3, 9);
            this.typeL.Name = "typeL";
            this.typeL.Size = new System.Drawing.Size(100, 23);
            this.typeL.TabIndex = 0;
            this.typeL.Text = "Image type:";
            this.typeL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resL
            // 
            this.resL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resL.Location = new System.Drawing.Point(3, 32);
            this.resL.Name = "resL";
            this.resL.Size = new System.Drawing.Size(100, 23);
            this.resL.TabIndex = 1;
            this.resL.Text = "Resolution:";
            this.resL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewsL
            // 
            this.viewsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewsL.Location = new System.Drawing.Point(3, 55);
            this.viewsL.Name = "viewsL";
            this.viewsL.Size = new System.Drawing.Size(100, 23);
            this.viewsL.TabIndex = 2;
            this.viewsL.Text = "Views:";
            this.viewsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadL
            // 
            this.downloadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadL.Location = new System.Drawing.Point(3, 78);
            this.downloadL.Name = "downloadL";
            this.downloadL.Size = new System.Drawing.Size(100, 23);
            this.downloadL.TabIndex = 3;
            this.downloadL.Text = "Downloads:";
            this.downloadL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeValL
            // 
            this.typeValL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeValL.Location = new System.Drawing.Point(109, 9);
            this.typeValL.Name = "typeValL";
            this.typeValL.Size = new System.Drawing.Size(100, 23);
            this.typeValL.TabIndex = 4;
            this.typeValL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resValL
            // 
            this.resValL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resValL.Location = new System.Drawing.Point(109, 32);
            this.resValL.Name = "resValL";
            this.resValL.Size = new System.Drawing.Size(100, 23);
            this.resValL.TabIndex = 5;
            this.resValL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewsValL
            // 
            this.viewsValL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewsValL.Location = new System.Drawing.Point(109, 55);
            this.viewsValL.Name = "viewsValL";
            this.viewsValL.Size = new System.Drawing.Size(100, 23);
            this.viewsValL.TabIndex = 6;
            this.viewsValL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downValL
            // 
            this.downValL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downValL.Location = new System.Drawing.Point(109, 78);
            this.downValL.Name = "downValL";
            this.downValL.Size = new System.Drawing.Size(100, 23);
            this.downValL.TabIndex = 7;
            this.downValL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downValL);
            this.Controls.Add(this.viewsValL);
            this.Controls.Add(this.resValL);
            this.Controls.Add(this.typeValL);
            this.Controls.Add(this.downloadL);
            this.Controls.Add(this.viewsL);
            this.Controls.Add(this.resL);
            this.Controls.Add(this.typeL);
            this.Name = "PictureInformationControl";
            this.Size = new System.Drawing.Size(224, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label typeL;
        private System.Windows.Forms.Label resL;
        private System.Windows.Forms.Label viewsL;
        private System.Windows.Forms.Label downloadL;
        private System.Windows.Forms.Label typeValL;
        private System.Windows.Forms.Label resValL;
        private System.Windows.Forms.Label viewsValL;
        private System.Windows.Forms.Label downValL;
    }
}
