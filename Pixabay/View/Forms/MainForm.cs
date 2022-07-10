using System.Windows.Forms;
using Pixabay.Controller;
using Pixabay.View.CustomControlls;

namespace Pixabay.View
{
    public partial class MainForm : Form
    {
        private GalleryController _galleryController;
        public MainForm()
        {
            InitializeComponent();
            _galleryController = new GalleryController();

            GalleryControl gl = new GalleryControl(this.Size,_galleryController.Gallery.hits, _galleryController.AddressForDownload);
            gl.Location = new System.Drawing.Point(10, 100);
            this.Controls.Add(gl);
        }
    }
}
