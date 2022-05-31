
namespace ThePictureOverlayer
{
    partial class PictureChooseHub
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ProgramHeader = new System.Windows.Forms.Label();
            this.pcb_PicturePreview = new System.Windows.Forms.PictureBox();
            this.btn_CreateOverlay = new System.Windows.Forms.Button();
            this.dlg_ChoosePicture = new System.Windows.Forms.OpenFileDialog();
            this.btn_ChoosePicture = new System.Windows.Forms.Button();
            this.txb_FileLocation = new System.Windows.Forms.TextBox();
            this.txb_OverlayOpacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProgramHeader
            // 
            this.lbl_ProgramHeader.AutoSize = true;
            this.lbl_ProgramHeader.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProgramHeader.Location = new System.Drawing.Point(12, 9);
            this.lbl_ProgramHeader.Name = "lbl_ProgramHeader";
            this.lbl_ProgramHeader.Size = new System.Drawing.Size(218, 47);
            this.lbl_ProgramHeader.TabIndex = 0;
            this.lbl_ProgramHeader.Text = "The Overlayer";
            // 
            // pcb_PicturePreview
            // 
            this.pcb_PicturePreview.Location = new System.Drawing.Point(12, 59);
            this.pcb_PicturePreview.MaximumSize = new System.Drawing.Size(536, 302);
            this.pcb_PicturePreview.MinimumSize = new System.Drawing.Size(536, 302);
            this.pcb_PicturePreview.Name = "pcb_PicturePreview";
            this.pcb_PicturePreview.Size = new System.Drawing.Size(536, 302);
            this.pcb_PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_PicturePreview.TabIndex = 1;
            this.pcb_PicturePreview.TabStop = false;
            // 
            // btn_CreateOverlay
            // 
            this.btn_CreateOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateOverlay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateOverlay.Location = new System.Drawing.Point(269, 396);
            this.btn_CreateOverlay.Name = "btn_CreateOverlay";
            this.btn_CreateOverlay.Size = new System.Drawing.Size(279, 66);
            this.btn_CreateOverlay.TabIndex = 2;
            this.btn_CreateOverlay.Text = "Create Overlay";
            this.btn_CreateOverlay.UseVisualStyleBackColor = true;
            this.btn_CreateOverlay.Click += new System.EventHandler(this.btn_CreateOverlay_Click);
            // 
            // dlg_ChoosePicture
            // 
            this.dlg_ChoosePicture.FileName = "openFileDialog1";
            // 
            // btn_ChoosePicture
            // 
            this.btn_ChoosePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChoosePicture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChoosePicture.Location = new System.Drawing.Point(12, 396);
            this.btn_ChoosePicture.Name = "btn_ChoosePicture";
            this.btn_ChoosePicture.Size = new System.Drawing.Size(251, 66);
            this.btn_ChoosePicture.TabIndex = 3;
            this.btn_ChoosePicture.Text = "Choose Picutre";
            this.btn_ChoosePicture.UseVisualStyleBackColor = true;
            this.btn_ChoosePicture.Click += new System.EventHandler(this.btn_ChoosePicture_Click);
            // 
            // txb_FileLocation
            // 
            this.txb_FileLocation.Location = new System.Drawing.Point(12, 367);
            this.txb_FileLocation.Name = "txb_FileLocation";
            this.txb_FileLocation.Size = new System.Drawing.Size(251, 23);
            this.txb_FileLocation.TabIndex = 4;
            // 
            // txb_OverlayOpacity
            // 
            this.txb_OverlayOpacity.Location = new System.Drawing.Point(372, 367);
            this.txb_OverlayOpacity.Name = "txb_OverlayOpacity";
            this.txb_OverlayOpacity.Size = new System.Drawing.Size(49, 23);
            this.txb_OverlayOpacity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opacity ( 0-100 ):";
            // 
            // PictureChooseHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_OverlayOpacity);
            this.Controls.Add(this.txb_FileLocation);
            this.Controls.Add(this.btn_ChoosePicture);
            this.Controls.Add(this.btn_CreateOverlay);
            this.Controls.Add(this.pcb_PicturePreview);
            this.Controls.Add(this.lbl_ProgramHeader);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 1000);
            this.MinimumSize = new System.Drawing.Size(577, 500);
            this.Name = "PictureChooseHub";
            this.Text = "The Overlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProgramHeader;
        private System.Windows.Forms.PictureBox pcb_PicturePreview;
        private System.Windows.Forms.Button btn_CreateOverlay;
        private System.Windows.Forms.OpenFileDialog dlg_ChoosePicture;
        private System.Windows.Forms.Button btn_ChoosePicture;
        private System.Windows.Forms.TextBox txb_FileLocation;
        private System.Windows.Forms.TextBox txb_OverlayOpacity;
        private System.Windows.Forms.Label label1;
    }
}

