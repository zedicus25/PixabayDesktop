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
            gl.Location = new System.Drawing.Point(10, 180);
            gl.Name = "galleryControl";
            this.Controls.Add(gl);
        }

        private void CreateGalleryControl()
        {
            for (int i = 0; i < this.Controls.Find("galleryControl", true).Length; i++)
            {
                this.Controls.Find("galleryControl", true)[i].Dispose();
            }
            InitializeGalleryControl();
            SetCurrentPage();
        }

        private void GetMsg(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void nextBtn_Click(object sender, System.EventArgs e)
        {
            _galleryController.GoToPage(_galleryController.CurrentPage + 1);
            CreateGalleryControl();

        }

        private void prevBtn_Click(object sender, System.EventArgs e)
        {
            if (_galleryController.CurrentPage == 1)
                return;
            _galleryController.GoToPage(_galleryController.CurrentPage - 1);
            CreateGalleryControl();
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
            CreateGalleryControl();
            pageTB.Text = string.Empty;
        }

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            _galleryController.Search(searchingTB.Text);
            CreateGalleryControl();
        }

        private void saveSearchCB_CheckedChanged(object sender, System.EventArgs e)
        {
            _galleryController.SetSaveSearch((sender as CheckBox).Checked);
            CreateGalleryControl();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _galleryController.ClearFilters();
            saveSearchCB.Checked = false;
            widthTB.Text = "0";
            heightTB.Text = "0";
            anyOrientationRB.Checked = true;
            anyTypeRB.Checked = true;
            popularOrderRB.Checked = true;
        }

        private void goBtn_Click(object sender, System.EventArgs e)
        {
            int minWidth = 0;
            int minHeight = 0;
            minWidth = int.Parse(widthTB.Text);
            minHeight = int.Parse(heightTB.Text);
            _galleryController.SetMinSize(minWidth, minHeight);
            CreateGalleryControl();
        }

        private void sizeTB_Enter(object sender, System.EventArgs e)
        {
            if((sender as TextBox).Text.Equals("0"))
                (sender as TextBox).Text = string.Empty;
        }

        private void sizeTB_Leave(object sender, System.EventArgs e)
        {
            if ((sender as TextBox).Name.Equals("widthTB") && (sender as TextBox).Text.Equals(string.Empty))
                (sender as TextBox).Text = "0";
            if ((sender as TextBox).Name.Equals("heightTB") && (sender as TextBox).Text.Equals(string.Empty))
                (sender as TextBox).Text = "0";
        }

        private void TypeRB_CheckedChanged(object sender, System.EventArgs e)
        {
            if((sender as RadioButton).Name.Contains("Type") && (sender as RadioButton).Checked == true)
            {
                _galleryController.SetImageType((sender as RadioButton).Text);
                CreateGalleryControl();
            }
            
        }

        private void OrientationRB_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Name.Contains("Orientation") && (sender as RadioButton).Checked == true)
            {
                _galleryController.SetOrientation((sender as RadioButton).Text);
                CreateGalleryControl();
            }
        }

        private void OrderRB_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Name.Contains("Order") && (sender as RadioButton).Checked == true)
            {
                _galleryController.SetOrder((sender as RadioButton).Text);
                CreateGalleryControl();
            }
        }
    }
}
