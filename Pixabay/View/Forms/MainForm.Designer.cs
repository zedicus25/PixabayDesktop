namespace Pixabay.View
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
            this.orientationP = new System.Windows.Forms.Panel();
            this.imageTypeP = new System.Windows.Forms.Panel();
            this.orderP = new System.Windows.Forms.Panel();
            this.latestRB = new System.Windows.Forms.RadioButton();
            this.popularRB = new System.Windows.Forms.RadioButton();
            this.editorChoiseRB = new System.Windows.Forms.RadioButton();
            this.saveSearchCB = new System.Windows.Forms.CheckBox();
            this.anyOrientRB = new System.Windows.Forms.RadioButton();
            this.verticalRB = new System.Windows.Forms.RadioButton();
            this.horizontalRB = new System.Windows.Forms.RadioButton();
            this.vectorTypeRB = new System.Windows.Forms.RadioButton();
            this.phootTypeRB = new System.Windows.Forms.RadioButton();
            this.illustrationsTypeRB = new System.Windows.Forms.RadioButton();
            this.anyTypeRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizeL = new System.Windows.Forms.Label();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.xL = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.orientationP.SuspendLayout();
            this.imageTypeP.SuspendLayout();
            this.orderP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevBtn.Location = new System.Drawing.Point(11, 867);
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
            this.nextBtn.Location = new System.Drawing.Point(124, 867);
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
            this.pageTB.Location = new System.Drawing.Point(718, 887);
            this.pageTB.Name = "pageTB";
            this.pageTB.Size = new System.Drawing.Size(69, 23);
            this.pageTB.TabIndex = 2;
            this.pageTB.TextChanged += new System.EventHandler(this.pageTB_TextChanged);
            // 
            // jumpToBtn
            // 
            this.jumpToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jumpToBtn.Location = new System.Drawing.Point(605, 867);
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
            this.pageL.Location = new System.Drawing.Point(329, 888);
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
            // orientationP
            // 
            this.orientationP.Controls.Add(this.horizontalRB);
            this.orientationP.Controls.Add(this.verticalRB);
            this.orientationP.Controls.Add(this.anyOrientRB);
            this.orientationP.Location = new System.Drawing.Point(153, 80);
            this.orientationP.Name = "orientationP";
            this.orientationP.Size = new System.Drawing.Size(106, 82);
            this.orientationP.TabIndex = 9;
            // 
            // imageTypeP
            // 
            this.imageTypeP.Controls.Add(this.anyTypeRB);
            this.imageTypeP.Controls.Add(this.illustrationsTypeRB);
            this.imageTypeP.Controls.Add(this.phootTypeRB);
            this.imageTypeP.Controls.Add(this.vectorTypeRB);
            this.imageTypeP.Location = new System.Drawing.Point(265, 80);
            this.imageTypeP.Name = "imageTypeP";
            this.imageTypeP.Size = new System.Drawing.Size(156, 82);
            this.imageTypeP.TabIndex = 10;
            // 
            // orderP
            // 
            this.orderP.Controls.Add(this.editorChoiseRB);
            this.orderP.Controls.Add(this.latestRB);
            this.orderP.Controls.Add(this.popularRB);
            this.orderP.Location = new System.Drawing.Point(12, 80);
            this.orderP.Name = "orderP";
            this.orderP.Size = new System.Drawing.Size(135, 82);
            this.orderP.TabIndex = 10;
            // 
            // latestRB
            // 
            this.latestRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latestRB.Location = new System.Drawing.Point(3, 30);
            this.latestRB.Name = "latestRB";
            this.latestRB.Size = new System.Drawing.Size(91, 24);
            this.latestRB.TabIndex = 1;
            this.latestRB.TabStop = true;
            this.latestRB.Text = "Latest";
            this.latestRB.UseVisualStyleBackColor = true;
            // 
            // popularRB
            // 
            this.popularRB.Checked = true;
            this.popularRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularRB.Location = new System.Drawing.Point(3, 7);
            this.popularRB.Name = "popularRB";
            this.popularRB.Size = new System.Drawing.Size(91, 24);
            this.popularRB.TabIndex = 0;
            this.popularRB.TabStop = true;
            this.popularRB.Text = "Popular";
            this.popularRB.UseVisualStyleBackColor = true;
            // 
            // editorChoiseRB
            // 
            this.editorChoiseRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editorChoiseRB.Location = new System.Drawing.Point(3, 54);
            this.editorChoiseRB.Name = "editorChoiseRB";
            this.editorChoiseRB.Size = new System.Drawing.Size(122, 24);
            this.editorChoiseRB.TabIndex = 2;
            this.editorChoiseRB.TabStop = true;
            this.editorChoiseRB.Text = "Editor\'s Choise";
            this.editorChoiseRB.UseVisualStyleBackColor = true;
            // 
            // saveSearchCB
            // 
            this.saveSearchCB.AutoSize = true;
            this.saveSearchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSearchCB.Location = new System.Drawing.Point(682, 83);
            this.saveSearchCB.Name = "saveSearchCB";
            this.saveSearchCB.Size = new System.Drawing.Size(106, 21);
            this.saveSearchCB.TabIndex = 4;
            this.saveSearchCB.Text = "Save search";
            this.saveSearchCB.UseVisualStyleBackColor = true;
            // 
            // anyOrientRB
            // 
            this.anyOrientRB.Checked = true;
            this.anyOrientRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anyOrientRB.Location = new System.Drawing.Point(3, 7);
            this.anyOrientRB.Name = "anyOrientRB";
            this.anyOrientRB.Size = new System.Drawing.Size(91, 24);
            this.anyOrientRB.TabIndex = 3;
            this.anyOrientRB.TabStop = true;
            this.anyOrientRB.Text = "Any";
            this.anyOrientRB.UseVisualStyleBackColor = true;
            // 
            // verticalRB
            // 
            this.verticalRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verticalRB.Location = new System.Drawing.Point(3, 30);
            this.verticalRB.Name = "verticalRB";
            this.verticalRB.Size = new System.Drawing.Size(91, 24);
            this.verticalRB.TabIndex = 4;
            this.verticalRB.TabStop = true;
            this.verticalRB.Text = "Vertical";
            this.verticalRB.UseVisualStyleBackColor = true;
            // 
            // horizontalRB
            // 
            this.horizontalRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horizontalRB.Location = new System.Drawing.Point(3, 55);
            this.horizontalRB.Name = "horizontalRB";
            this.horizontalRB.Size = new System.Drawing.Size(91, 24);
            this.horizontalRB.TabIndex = 5;
            this.horizontalRB.TabStop = true;
            this.horizontalRB.Text = "Horizontal";
            this.horizontalRB.UseVisualStyleBackColor = true;
            // 
            // vectorTypeRB
            // 
            this.vectorTypeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vectorTypeRB.Location = new System.Drawing.Point(3, 7);
            this.vectorTypeRB.Name = "vectorTypeRB";
            this.vectorTypeRB.Size = new System.Drawing.Size(91, 24);
            this.vectorTypeRB.TabIndex = 6;
            this.vectorTypeRB.TabStop = true;
            this.vectorTypeRB.Text = "Vector";
            this.vectorTypeRB.UseVisualStyleBackColor = true;
            // 
            // phootTypeRB
            // 
            this.phootTypeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phootTypeRB.Location = new System.Drawing.Point(3, 30);
            this.phootTypeRB.Name = "phootTypeRB";
            this.phootTypeRB.Size = new System.Drawing.Size(91, 24);
            this.phootTypeRB.TabIndex = 7;
            this.phootTypeRB.TabStop = true;
            this.phootTypeRB.Text = "Photos";
            this.phootTypeRB.UseVisualStyleBackColor = true;
            // 
            // illustrationsTypeRB
            // 
            this.illustrationsTypeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.illustrationsTypeRB.Location = new System.Drawing.Point(3, 54);
            this.illustrationsTypeRB.Name = "illustrationsTypeRB";
            this.illustrationsTypeRB.Size = new System.Drawing.Size(91, 24);
            this.illustrationsTypeRB.TabIndex = 8;
            this.illustrationsTypeRB.TabStop = true;
            this.illustrationsTypeRB.Text = "Illustrations";
            this.illustrationsTypeRB.UseVisualStyleBackColor = true;
            // 
            // anyTypeRB
            // 
            this.anyTypeRB.Checked = true;
            this.anyTypeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anyTypeRB.Location = new System.Drawing.Point(91, 30);
            this.anyTypeRB.Name = "anyTypeRB";
            this.anyTypeRB.Size = new System.Drawing.Size(62, 24);
            this.anyTypeRB.TabIndex = 9;
            this.anyTypeRB.TabStop = true;
            this.anyTypeRB.Text = "Any";
            this.anyTypeRB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.goBtn);
            this.panel1.Controls.Add(this.heightTB);
            this.panel1.Controls.Add(this.xL);
            this.panel1.Controls.Add(this.widthTB);
            this.panel1.Controls.Add(this.sizeL);
            this.panel1.Location = new System.Drawing.Point(427, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 82);
            this.panel1.TabIndex = 11;
            // 
            // sizeL
            // 
            this.sizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeL.Location = new System.Drawing.Point(3, 4);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(100, 23);
            this.sizeL.TabIndex = 0;
            this.sizeL.Text = "Large than";
            // 
            // widthTB
            // 
            this.widthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthTB.Location = new System.Drawing.Point(6, 31);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(72, 23);
            this.widthTB.TabIndex = 1;
            this.widthTB.Text = "Width";
            // 
            // xL
            // 
            this.xL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xL.Location = new System.Drawing.Point(84, 31);
            this.xL.Name = "xL";
            this.xL.Size = new System.Drawing.Size(19, 23);
            this.xL.TabIndex = 2;
            this.xL.Text = "x";
            this.xL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightTB
            // 
            this.heightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightTB.Location = new System.Drawing.Point(109, 31);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(72, 23);
            this.heightTB.TabIndex = 3;
            this.heightTB.Text = "Height";
            // 
            // goBtn
            // 
            this.goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBtn.Location = new System.Drawing.Point(187, 25);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(47, 35);
            this.goBtn.TabIndex = 4;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(682, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear filters";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 941);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveSearchCB);
            this.Controls.Add(this.orderP);
            this.Controls.Add(this.imageTypeP);
            this.Controls.Add(this.orientationP);
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
            this.orientationP.ResumeLayout(false);
            this.imageTypeP.ResumeLayout(false);
            this.orderP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel orientationP;
        private System.Windows.Forms.Panel imageTypeP;
        private System.Windows.Forms.Panel orderP;
        private System.Windows.Forms.RadioButton latestRB;
        private System.Windows.Forms.RadioButton popularRB;
        private System.Windows.Forms.RadioButton editorChoiseRB;
        private System.Windows.Forms.RadioButton horizontalRB;
        private System.Windows.Forms.RadioButton verticalRB;
        private System.Windows.Forms.RadioButton anyOrientRB;
        private System.Windows.Forms.RadioButton anyTypeRB;
        private System.Windows.Forms.RadioButton illustrationsTypeRB;
        private System.Windows.Forms.RadioButton phootTypeRB;
        private System.Windows.Forms.RadioButton vectorTypeRB;
        private System.Windows.Forms.CheckBox saveSearchCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Label xL;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.Label sizeL;
        private System.Windows.Forms.Button button1;
    }
}

