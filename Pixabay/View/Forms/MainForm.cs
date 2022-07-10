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
            InitializeGalleryControl();
            _galleryController.SendMsg += GetMsg;
            SetCurrentPage();

        }

        private void InitializeGalleryControl()
        {
            GalleryControl gl = new GalleryControl(this.Size, _galleryController.Gallery.hits, _galleryController.AddressForDownload);
            gl.Location = new System.Drawing.Point(10, 100);
            gl.Name = "galleryControl";
            this.Controls.Add(gl);
        }

        private void GetMsg(string msg)
        {
            MessageBox.Show(msg,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void nextBtn_Click(object sender, System.EventArgs e)
        {
            _galleryController.GoToPage(_galleryController.CurrentPage + 1);
            this.Controls.RemoveByKey("galleryControl");
            InitializeGalleryControl();
            SetCurrentPage();
        }

        private void prevBtn_Click(object sender, System.EventArgs e)
        {
            if (_galleryController.CurrentPage == 1)
                return;
            _galleryController.GoToPage(_galleryController.CurrentPage - 1);
            this.Controls.RemoveByKey("galleryControl");
            InitializeGalleryControl();
            SetCurrentPage();
        }

        private void pageTB_TextChanged(object sender, System.EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);
            }
        }

        private void SetCurrentPage() => pageL.Text = $"Page {_galleryController.CurrentPage} of {_galleryController.MaxPage}";

        private void jumpToBtn_Click(object sender, System.EventArgs e)
        {
            if (pageTB.Text.Equals(string.Empty))
                return;
            _galleryController.GoToPage(int.Parse(pageTB.Text));
            this.Controls.RemoveByKey("galleryControl");
            InitializeGalleryControl();
            pageTB.Text = string.Empty;
            SetCurrentPage();
        }

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            _galleryController.Search(searchingTB.Text);
            this.Controls.RemoveByKey("galleryControl");
            InitializeGalleryControl();
        }
    }
}
