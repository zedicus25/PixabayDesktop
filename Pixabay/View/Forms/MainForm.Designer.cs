﻿namespace Pixabay.View
{
    partial class MainForm
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
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pageTB = new System.Windows.Forms.TextBox();
            this.jumpToBtn = new System.Windows.Forms.Button();
            this.searchingTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.pageL = new System.Windows.Forms.Label();
            this.logoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevBtn.Location = new System.Drawing.Point(12, 807);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(107, 62);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(125, 807);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(107, 62);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageTB
            // 
            this.pageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTB.Location = new System.Drawing.Point(719, 827);
            this.pageTB.Name = "pageTB";
            this.pageTB.Size = new System.Drawing.Size(69, 23);
            this.pageTB.TabIndex = 2;
            this.pageTB.TextChanged += new System.EventHandler(this.pageTB_TextChanged);
            // 
            // jumpToBtn
            // 
            this.jumpToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jumpToBtn.Location = new System.Drawing.Point(606, 807);
            this.jumpToBtn.Name = "jumpToBtn";
            this.jumpToBtn.Size = new System.Drawing.Size(107, 62);
            this.jumpToBtn.TabIndex = 3;
            this.jumpToBtn.Text = "Jump to";
            this.jumpToBtn.UseVisualStyleBackColor = true;
            this.jumpToBtn.Click += new System.EventHandler(this.jumpToBtn_Click);
            // 
            // searchingTB
            // 
            this.searchingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchingTB.Location = new System.Drawing.Point(12, 29);
            this.searchingTB.MaxLength = 100;
            this.searchingTB.Name = "searchingTB";
            this.searchingTB.Size = new System.Drawing.Size(330, 26);
            this.searchingTB.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(348, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 62);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pageL
            // 
            this.pageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageL.Location = new System.Drawing.Point(330, 828);
            this.pageL.Name = "pageL";
            this.pageL.Size = new System.Drawing.Size(160, 23);
            this.pageL.TabIndex = 7;
            this.pageL.Text = "label2";
            // 
            // logoPB
            // 
            this.logoPB.Image = global::Pixabay.Properties.Resources.logo;
            this.logoPB.Location = new System.Drawing.Point(461, 12);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(327, 62);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 8;
            this.logoPB.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 881);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.pageL);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchingTB);
            this.Controls.Add(this.jumpToBtn);
            this.Controls.Add(this.pageTB);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Name = "MainForm";
            this.Text = "Pixabay";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox pageTB;
        private System.Windows.Forms.Button jumpToBtn;
        private System.Windows.Forms.TextBox searchingTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label pageL;
        private System.Windows.Forms.PictureBox logoPB;
    }
}

