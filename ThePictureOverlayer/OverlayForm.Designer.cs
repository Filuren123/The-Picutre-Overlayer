
namespace ThePictureOverlayer
{
    partial class OverlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_MainPictureShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MainPictureShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_MainPictureShow
            // 
            this.txb_MainPictureShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_MainPictureShow.Location = new System.Drawing.Point(12, 12);
            this.txb_MainPictureShow.Name = "txb_MainPictureShow";
            this.txb_MainPictureShow.Size = new System.Drawing.Size(744, 391);
            this.txb_MainPictureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txb_MainPictureShow.TabIndex = 0;
            this.txb_MainPictureShow.TabStop = false;
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 415);
            this.Controls.Add(this.txb_MainPictureShow);
            this.Name = "OverlayForm";
            this.Text = "OverlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.txb_MainPictureShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox txb_MainPictureShow;
    }
}