using Pixabay.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pixabay.View.CustomControlls
{
    public partial class PreviewImageControl : UserControl
    {
        public event Action<Hits> ShowViewForm;
        private string _file;
        private Hits _hit;
        public PreviewImageControl()
        {
            _file = string.Empty;
            InitializeComponent();
        }
        public PreviewImageControl(Hits hit, string filePath) : this()
        {
            _hit = hit;
            _file = hit.previewURL.Substring(hit.previewURL.LastIndexOf('/')+1);
            filePath += $"\\{_file}";
            _file = filePath;
            this.Size = new System.Drawing.Size(150,100+65);

            previewPB.Size = new System.Drawing.Size(150, 100);

            byte[] bytes = File.ReadAllBytes(_file);
            FileStream fs = new FileStream(_file, FileMode.Open,FileAccess.Read,FileShare.None);
            fs.Read(bytes, 0,bytes.Length);
            previewPB.Image = Image.FromStream(fs);
            fs.Close();

            tagsL.Location = new System.Drawing.Point(5, previewPB.Size.Height + 5);
            tagsL.Size = new System.Drawing.Size(hit.previewWidth, 35);
            tagsL.Text = hit.tags.ToString().Replace(',',' ');

            likePB.Location = new System.Drawing.Point(5, tagsL.Location.Y+likePB.Height+5);
            likesL.Location = new System.Drawing.Point(likePB.Size.Width + 5, tagsL.Location.Y + likePB.Height+5);
            likesL.Text = hit.likes.ToString();

            commentsPB.Location = new System.Drawing.Point(likesL.Location.X+32, tagsL.Location.Y + commentsPB.Size.Height+5);
            commentsL.Location = new System.Drawing.Point(commentsPB.Location.X + 35, tagsL.Location.Y + commentsPB.Size.Height);
            commentsL.Text = hit.comments.ToString();

        }

        private void previewPB_Click(object sender, System.EventArgs e)
        {
            ShowViewForm?.Invoke(_hit);
        }
    }
}