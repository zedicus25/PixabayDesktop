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
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hitsController.ClearDirectory();
        }
    }
}
