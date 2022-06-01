
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
            this.pcb_MainPictureShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_MainPictureShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_MainPictureShow
            // 
            this.pcb_MainPictureShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_MainPictureShow.Location = new System.Drawing.Point(1, -2);
            this.pcb_MainPictureShow.Name = "pcb_MainPictureShow";
            this.pcb_MainPictureShow.Size = new System.Drawing.Size(766, 417);
            this.pcb_MainPictureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_MainPictureShow.TabIndex = 0;
            this.pcb_MainPictureShow.TabStop = false;
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 415);
            this.Controls.Add(this.pcb_MainPictureShow);
            this.Name = "OverlayForm";
            this.Text = "OverlayForm";
            this.Load += new System.EventHandler(this.OverlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_MainPictureShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_MainPictureShow;
    }
}