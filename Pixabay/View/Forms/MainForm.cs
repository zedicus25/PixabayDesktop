using System.Windows.Forms;
using Pixabay.Controller;

namespace Pixabay.View
{
    public partial class MainForm : Form
    {
        private GalleryController _galleryController;
        public MainForm()
        {
            InitializeComponent();
            _galleryController = new GalleryController();
        }
    }
}
