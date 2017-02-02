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
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPortretPhoto_Click(object sender, EventArgs e)
        {
            pictureEx1.Visible = true;
            pictureEx1.Image = global::Lab_2.Resource.PortretPhoto;
        }

        private void btnArtPhoto_Click(object sender, EventArgs e)
        {
            pictureEx1.Visible = true;
            pictureEx1.Image = global::Lab_2.Resource.ArtPhoto;
        }

        private void btnHomePhoto_Click(object sender, EventArgs e)
        {
            pictureEx1.Visible = true;
            pictureEx1.Image = global::Lab_2.Resource.HomePhoto;
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
                count = 0;
            switch (count)
            {
                case 0:
                    pictureEx2.Image = global::Lab_2.Resource.PortretPhoto;
                    break;
                case 1:
                    pictureEx2.Image = global::Lab_2.Resource.ArtPhoto;
                    break;
                case 2:
                    pictureEx2.Image = global::Lab_2.Resource.HomePhoto;
                    break;
            }
        }
    }
}
