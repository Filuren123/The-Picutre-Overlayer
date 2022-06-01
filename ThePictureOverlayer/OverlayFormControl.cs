using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThePictureOverlayer
{
    public partial class OverlayFormControl : Form
    {
        private OverlayForm ActiveOverlayForm;
        private PictureChooseHub PictureChooseHub;

        public OverlayFormControl(OverlayForm OverlayForm, PictureChooseHub PictureChooseHub)
        {
            InitializeComponent();
            this.ActiveOverlayForm = OverlayForm;
            this.PictureChooseHub = PictureChooseHub;
        }

        private void btn_CloseOverlay_Click(object sender, EventArgs e)
        {
            ActiveOverlayForm.Close();
            PictureChooseHub.Show();
            this.Close();
        }

        private void btn_ToggleOverlayBorder_Click(object sender, EventArgs e)
        {
            if (ActiveOverlayForm.FormBorderStyle == FormBorderStyle.Sizable)
            {
                ActiveOverlayForm.FormBorderStyle = FormBorderStyle.None;
                lbl_BorderState.Text = "Hidden";
            }
            else
            {
                ActiveOverlayForm.FormBorderStyle = FormBorderStyle.Sizable;
                lbl_BorderState.Text = "Shown";
            }
        }

        private void btn_ToggleClickThrough_Click(object sender, EventArgs e)
        {
            if (lbl_ClickthroughState.Text == "No")
            {
                ActiveOverlayForm.ActivateClickThrough();
                lbl_ClickthroughState.Text = "Yes";
            }
            else
            {
                if (ActiveOverlayForm.FormBorderStyle == FormBorderStyle.Sizable)
                {
                    ActiveOverlayForm.FormBorderStyle = FormBorderStyle.None;
                    ActiveOverlayForm.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    ActiveOverlayForm.FormBorderStyle = FormBorderStyle.Sizable;
                    ActiveOverlayForm.FormBorderStyle = FormBorderStyle.None;
                }
                lbl_ClickthroughState.Text = "No";
            }
        }
    }
}
