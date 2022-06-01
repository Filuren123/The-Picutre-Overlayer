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
        private Form OverlayForm;
        private Form PictureChooseHub;

        public OverlayFormControl(Form OverlayForm, Form PictureChooseHub)
        {
            InitializeComponent();
            this.OverlayForm = OverlayForm;
            this.PictureChooseHub = PictureChooseHub;
        }


    }
}
