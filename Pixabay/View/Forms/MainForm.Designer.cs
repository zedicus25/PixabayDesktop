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
            this.previewImageControl1 = new Pixabay.View.CustomControlls.PreviewImageControl();
            this.SuspendLayout();
            // 
            // previewImageControl1
            // 
            this.previewImageControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.previewImageControl1.Location = new System.Drawing.Point(12, 12);
            this.previewImageControl1.Name = "previewImageControl1";
            this.previewImageControl1.Size = new System.Drawing.Size(471, 357);
            this.previewImageControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previewImageControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlls.PreviewImageControl previewImageControl1;
    }
}

