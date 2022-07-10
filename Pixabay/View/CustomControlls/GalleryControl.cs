using Pixabay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixabay.View.CustomControlls
{
    public partial class GalleryControl : UserControl
    {
        private ViewForm _viewForm;
        public GalleryControl()
        {
            InitializeComponent();
            _viewForm = new ViewForm();
        }
        public GalleryControl(Size formSize, List<Hits> hits, string pathForDownload) : this()
        {
            this.Width = formSize.Width;
            this.Height = formSize.Height;
            mainPanel.Size = formSize;
            InitializeHits(hits, pathForDownload);
        }

        private void InitializeHits(List<Hits> hits, string path)
        {
            int maxCountInRow = this.Width / hits[0].previewWidth;
            for (int i = 0; i < hits.Count; i++)
            {
                PreviewImageControl pr = new PreviewImageControl(hits[i],path);
                pr.ShowViewForm += ShowViewForm;

                if (i != 0)
                    pr.Location = new Point(mainPanel.Controls[mainPanel.Controls.Count - 1].Location.X + pr.Width+5,
                        mainPanel.Controls[mainPanel.Controls.Count - 1].Location.Y);
                else
                    pr.Location = new Point(0, 0);

                if (i % maxCountInRow == 0 && i != 0)
                {
                    pr.Location = new Point(0, mainPanel.Controls[mainPanel.Controls.Count - 1].Location.Y + pr.Height+5);
                }
                mainPanel.Controls.Add(pr);
                GC.Collect(GC.GetGeneration(pr));
            }
        }

        private void ShowViewForm(Hits hit)
        {
            _viewForm = new ViewForm(hit);
            _viewForm.ShowDialog();
        }
    }
}
