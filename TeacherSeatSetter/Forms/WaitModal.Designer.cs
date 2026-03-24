using System.Drawing;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    partial class WaitModal {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.lblMessage = new Label();
            this.pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new Font("맑은 고딕", 9.5F);
            this.lblMessage.Location = new Point(23, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new Size(100, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "";
            //
            // pictureBox1
            //
            this.pictureBox1.Image = global::TeacherSeatSetter.Properties.Resources.loading;
            this.pictureBox1.Location = new Point(13, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(177, 90);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            //
            // WaitModal
            //
            this.AutoScaleDimensions = new SizeF(7F, 12F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(203, 140);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitModal";
            this.Opacity = 0.6D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "WaitModal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private PictureBox pictureBox1;
    }
}
