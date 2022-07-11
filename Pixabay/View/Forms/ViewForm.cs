using Pixabay.Controller;
using Pixabay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixabay.View
{
    public partial class ViewForm : Form
    {
        private HitsController _hitsController;
        private string _resForDownload;
        public ViewForm()
        {
            InitializeComponent();
        }
        public ViewForm(Hits hit) : this()
        {
            _hitsController = new HitsController(hit);
            byte[] bytes = File.ReadAllBytes(_hitsController.FilePath);
            FileStream fs = new FileStream(_hitsController.FilePath, FileMode.Open, FileAccess.Read, FileShare.None);
            fs.Read(bytes, 0, bytes.Length);
            mainImagePB.Image = Image.FromStream(fs);
            fs.Close();

            tagsL.Text = hit.tags.Replace(',', ' ');

            userNameL.Text = hit.user;

            if (!_hitsController.UserImage.Equals(String.Empty))
            {
                bytes = File.ReadAllBytes(_hitsController.UserImage);
                fs = new FileStream(_hitsController.UserImage, FileMode.Open, FileAccess.Read, FileShare.None);
                fs.Read(bytes, 0, bytes.Length);
                userPB.Image = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
            }
            else
            {
                userPB.Image = userPB.InitialImage;
            }
            GC.Collect(GC.GetGeneration(bytes));
            GC.Collect(GC.GetGeneration(fs));

            string type = _hitsController.FileName.Substring(_hitsController.FileName.LastIndexOf('.') + 1);
            string res = $"{hit.imageWidth}x{hit.imageHeight}";
            pictureInformationControl1.UpdateText(type, res, hit.views.ToString(), hit.downloads.ToString());

            res1RB.Text = $"{hit.webformatWidth}x{hit.webformatHeight}";
            res2RB.Text = $"{hit.webformatWidth * 2}x{hit.webformatHeight * 2}";
            res3RB.Text = $"{hit.webformatWidth * 3}x{hit.webformatHeight * 3}";
            res4RB.Text = $"{hit.imageWidth}x{hit.imageHeight}";
            _resForDownload = res1RB.Text;
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hitsController.ClearDirectory();
        }

        private void resRB_CheckedChanged(object sender, EventArgs e)
        {
            _resForDownload = (sender as RadioButton).Text;
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (_resForDownload.Equals(String.Empty))
                return;

            _hitsController.DownloadFile(_resForDownload);
        }
    }
}
