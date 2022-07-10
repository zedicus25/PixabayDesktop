using Pixabay.Model;
using System.Windows.Forms;

namespace Pixabay.View.CustomControlls
{
    public partial class PreviewImageControl : UserControl
    {
        public PreviewImageControl()
        {
            InitializeComponent();
        }
        public PreviewImageControl(Hits hit) : this()
        {
            
        }
    }
}