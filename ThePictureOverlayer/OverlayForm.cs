using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ThePictureOverlayer
{
    public partial class OverlayForm : Form
    {
        byte trueOpacity;

        public OverlayForm(double trueOpacity)
        {
            InitializeComponent();
            this.Opacity = trueOpacity;
            this.trueOpacity = (byte)(trueOpacity * 255);
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            pcb_MainPictureShow.ImageLocation = PictureChooseHub.FilePathPicture;
            this.TopMost = true;
        }

        // Enums for the click through
        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        // Imports a bunch of Dlls that allows the user to click through the form
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        public void ActivateClickThrough()
        {
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            SetLayeredWindowAttributes(this.Handle, 0, trueOpacity, LWA.Alpha);
        }
    }
}
