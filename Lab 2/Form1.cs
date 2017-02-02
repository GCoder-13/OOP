using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPortretPhoto_Click(object sender, EventArgs e)
        {
            picturePortretPhoto.Visible = true;
            picturePortretPhoto.Image = global::Lab_2.Resource.PortretPhoto;
        }

        private void btnArtPhoto_Click(object sender, EventArgs e)
        {
            picturePortretPhoto.Visible = true;
            picturePortretPhoto.Image = global::Lab_2.Resource.ArtPhoto;
        }

        private void btnHomePhoto_Click(object sender, EventArgs e)
        {
            picturePortretPhoto.Visible = true;
            picturePortretPhoto.Image = global::Lab_2.Resource.HomePhoto;
        }
    }
}
