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
            pictureEx1.Image = global::Lab_2.Resource.PortretPhoto;
        }

        private void btnArtPhoto_Click(object sender, EventArgs e)
        {
            pictureEx1.Image = global::Lab_2.Resource.ArtPhoto;
        }

        private void btnHomePhoto_Click(object sender, EventArgs e)
        {
            pictureEx1.Image = global::Lab_2.Resource.HomePhoto;
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            
            count++;
            if (count == 3)
                count = 0;

            if (pictureEx2.Image == null)
            {
                pictureEx2.Image = global::Lab_2.Resource.PortretPhoto;
                btnEditPhoto.Text = "Змінити фотографію";
                count = 0;
            }

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

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            pictureEx2.Image = null;
            btnEditPhoto.Text = "Портретна фотографія";
        }

        private void btnPortretPhotoEx3_Click(object sender, EventArgs e)
        {
            btnTakePhotoEx3.Enabled = true;
            btnTakePhotoEx3.Visible = true;

            if (btnPortretPhotoEx3.Text == "Портретна фотографія")
            {
                pictureEx3.Image = global::Lab_2.Resource.PortretPhoto;
                labelNamePhoto.Text = "Портретна фотографія";
                btnPortretPhotoEx3.Text = "Художня фотографія";
            }
            else if(btnPortretPhotoEx3.Text == "Художня фотографія")
            {
                pictureEx3.Image = global::Lab_2.Resource.ArtPhoto;
                labelNamePhoto.Text = "Художня фотографія";
                btnPortretPhotoEx3.Text = "Третя фотографія";
            }
            else if(btnPortretPhotoEx3.Text == "Третя фотографія")
            {
                pictureEx3.Image = global::Lab_2.Resource.HomePhoto;
                labelNamePhoto.Text = "Фотографія будинку";
                btnPortretPhotoEx3.Text = "Портретна фотографія";
            }
        }

        private void btnTakePhotoEx3_Click(object sender, EventArgs e)
        {
            pictureEx3.Image = null;
            btnTakePhotoEx3.Enabled = false;
            btnTakePhotoEx3.Visible = false;
            labelNamePhoto.Text = null;
        }
    }
}
