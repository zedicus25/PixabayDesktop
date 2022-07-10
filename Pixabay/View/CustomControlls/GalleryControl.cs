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
        public GalleryControl()
        {
            InitializeComponent();
        }
        public GalleryControl(Size formSize, List<Hits> hits, string pathForDownload) : this()
        {
            this.Size = formSize;
            mainPanel.Size = formSize;
            InitializeHits(hits, pathForDownload);
        }

        private void InitializeHits(List<Hits> hits, string path)
        {
            int maxCountInRow = this.Width / hits[0].previewWidth;
            for (int i = 0; i < hits.Count; i++)
            {
                PreviewImageControl pr = new PreviewImageControl(hits[i],path);

                if (i != 0)
                    pr.Location = new Point(mainPanel.Controls[mainPanel.Controls.Count - 1].Location.X + pr.Width+5,
                        mainPanel.Controls[mainPanel.Controls.Count - 1].Location.Y);
                else
                    pr.Location = new Point(0, 0);

                if (i % maxCountInRow == 0 && i != 0)
                {
                    pr.Location = new Point(0, mainPanel.Controls[mainPanel.Controls.Count - 1].Location.Y + pr.Height+5);
                }

                /*if (i == 0)
                {
                    pr.Location = new Point(10, 10);
                    mainPanel.Controls.Add(pr);
                    continue;
                }

                pr.Location = new Point(mainPanel.Controls[mainPanel.Controls.Count - 1].Width + 10,
                                            mainPanel.Controls[mainPanel.Controls.Count - 1].Location.Y + 50);

                if (i % maxCountInRow == 0)
                {
                    pr.Location = new Point(mainPanel.Controls[mainPanel.Controls.Count - 1].Width + 10,
                        mainPanel.Controls[mainPanel.Controls.Count - 1].Height+10);
                }*/




                mainPanel.Controls.Add(pr);
            }
        }
    }
}
