using System.Windows.Forms;

namespace Pixabay.View.CustomControlls
{
    public partial class PictureInformationControl : UserControl
    {
        public PictureInformationControl()
        {
            InitializeComponent();
        }

        public void UpdateText(string type, string resolution, string views, string downloads)
        {
            typeValL.Text = type;
            resValL.Text = resolution;
            viewsValL.Text = views;
            downValL.Text = downloads;
        }
    }
}
