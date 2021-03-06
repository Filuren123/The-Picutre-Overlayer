using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePictureOverlayer
{
    public partial class PictureChooseHub : Form
    {
        public static string FilePathPicture = string.Empty;

        public PictureChooseHub()
        {
            InitializeComponent();
        }

        private void btn_ChoosePicture_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlg_ChoosePicture.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txb_FileLocation.Text = dlg_ChoosePicture.FileName;
                UpdatePicturePreview();
            }
        }

        private void UpdatePicturePreview()
        {
            pcb_PicturePreview.ImageLocation = dlg_ChoosePicture.FileName;
            FilePathPicture = dlg_ChoosePicture.FileName;
        }

        private bool ValidateOpacityValue()
        {
            double opacityValue = 0;
            try
            {
                opacityValue = double.Parse(txb_OverlayOpacity.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The opacity value has to be a number between 0 and 100.", "Opacity Error");
                return false;
            }

            if (opacityValue >= 0 && opacityValue <= 100)
            {
                return true;
            }
            MessageBox.Show("The opacity value has to be a number between 0 and 100.", "Opacity Error");
            return false;
        }

        private void btn_CreateOverlay_Click(object sender, EventArgs e)
        {
            if (!ValidateOpacityValue()) return;

            var overlayFormOpacity = double.Parse(txb_OverlayOpacity.Text) / 100;
            OverlayForm overlayForm = new OverlayForm(overlayFormOpacity);
            overlayForm.Show();

            OverlayFormControl overlayFormControl = new OverlayFormControl(overlayForm, this);
            overlayFormControl.Show();
            this.Hide();
        }
    }
}
