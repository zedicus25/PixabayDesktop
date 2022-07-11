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
            this.tagsL = new System.Windows.Forms.Label();
            this.userNameL = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.resoulitionPanel = new System.Windows.Forms.Panel();
            this.res4RB = new System.Windows.Forms.RadioButton();
            this.res3RB = new System.Windows.Forms.RadioButton();
            this.res2RB = new System.Windows.Forms.RadioButton();
            this.res1RB = new System.Windows.Forms.RadioButton();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.mainImagePB = new System.Windows.Forms.PictureBox();
            this.pictureInformationControl1 = new Pixabay.View.CustomControlls.PictureInformationControl();
            this.resoulitionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePB)).BeginInit();
            this.SuspendLayout();
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
            // userNameL
            // 
            this.userNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameL.Location = new System.Drawing.Point(744, 30);
            this.userNameL.Name = "userNameL";
            this.userNameL.Size = new System.Drawing.Size(138, 41);
            this.userNameL.TabIndex = 3;
            this.userNameL.Text = "label1";
            this.userNameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.LightGreen;
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadBtn.Location = new System.Drawing.Point(658, 130);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(224, 61);
            this.downloadBtn.TabIndex = 4;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // resoulitionPanel
            // 
            this.resoulitionPanel.Controls.Add(this.res4RB);
            this.resoulitionPanel.Controls.Add(this.res3RB);
            this.resoulitionPanel.Controls.Add(this.res2RB);
            this.resoulitionPanel.Controls.Add(this.res1RB);
            this.resoulitionPanel.Location = new System.Drawing.Point(658, 197);
            this.resoulitionPanel.Name = "resoulitionPanel";
            this.resoulitionPanel.Size = new System.Drawing.Size(224, 139);
            this.resoulitionPanel.TabIndex = 5;
            // 
            // res4RB
            // 
            this.res4RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res4RB.Location = new System.Drawing.Point(3, 102);
            this.res4RB.Name = "res4RB";
            this.res4RB.Size = new System.Drawing.Size(129, 24);
            this.res4RB.TabIndex = 3;
            this.res4RB.Text = "radioButton1";
            this.res4RB.UseVisualStyleBackColor = true;
            this.res4RB.CheckedChanged += new System.EventHandler(this.resRB_CheckedChanged);
            // 
            // res3RB
            // 
            this.res3RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res3RB.Location = new System.Drawing.Point(3, 72);
            this.res3RB.Name = "res3RB";
            this.res3RB.Size = new System.Drawing.Size(129, 24);
            this.res3RB.TabIndex = 2;
            this.res3RB.Text = "radioButton1";
            this.res3RB.UseVisualStyleBackColor = true;
            this.res3RB.CheckedChanged += new System.EventHandler(this.resRB_CheckedChanged);
            // 
            // res2RB
            // 
            this.res2RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res2RB.Location = new System.Drawing.Point(3, 42);
            this.res2RB.Name = "res2RB";
            this.res2RB.Size = new System.Drawing.Size(129, 24);
            this.res2RB.TabIndex = 1;
            this.res2RB.Text = "radioButton1";
            this.res2RB.UseVisualStyleBackColor = true;
            this.res2RB.CheckedChanged += new System.EventHandler(this.resRB_CheckedChanged);
            // 
            // res1RB
            // 
            this.res1RB.Checked = true;
            this.res1RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res1RB.Location = new System.Drawing.Point(3, 12);
            this.res1RB.Name = "res1RB";
            this.res1RB.Size = new System.Drawing.Size(129, 24);
            this.res1RB.TabIndex = 0;
            this.res1RB.TabStop = true;
            this.res1RB.Text = "radioButton1";
            this.res1RB.UseVisualStyleBackColor = true;
            this.res1RB.CheckedChanged += new System.EventHandler(this.resRB_CheckedChanged);
            // 
            // userPB
            // 
            this.userPB.Location = new System.Drawing.Point(658, 12);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(80, 80);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 2;
            this.userPB.TabStop = false;
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
            // pictureInformationControl1
            // 
            this.pictureInformationControl1.Location = new System.Drawing.Point(658, 455);
            this.pictureInformationControl1.Name = "pictureInformationControl1";
            this.pictureInformationControl1.Size = new System.Drawing.Size(224, 109);
            this.pictureInformationControl1.TabIndex = 6;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 572);
            this.Controls.Add(this.pictureInformationControl1);
            this.Controls.Add(this.resoulitionPanel);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.userNameL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.tagsL);
            this.Controls.Add(this.mainImagePB);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm_FormClosing);
            this.resoulitionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImagePB;
        private System.Windows.Forms.Label tagsL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Label userNameL;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Panel resoulitionPanel;
        private System.Windows.Forms.RadioButton res4RB;
        private System.Windows.Forms.RadioButton res3RB;
        private System.Windows.Forms.RadioButton res2RB;
        private System.Windows.Forms.RadioButton res1RB;
        private CustomControlls.PictureInformationControl pictureInformationControl1;
    }
}