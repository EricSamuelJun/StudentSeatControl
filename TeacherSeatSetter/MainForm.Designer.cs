using System.Windows.Forms;
using System.Drawing;

namespace TeacherSeatSetter {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new Panel();
            this.sidebarPanel = new Panel();
            this.btnClose = new Button();
            this.btnContact = new Button();
            this.btnShowFinalManage = new Button();
            this.btnStudentManage = new Button();
            this.btnSeatManage = new Button();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // contentPanel
            //
            this.contentPanel.BackColor = Color.White;
            this.contentPanel.Dock = DockStyle.Fill;
            this.contentPanel.Margin = new Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new Size(650, 650);
            this.contentPanel.TabIndex = 0;
            //
            // sidebarPanel
            //
            this.sidebarPanel.BackColor = Color.FromArgb(40, 53, 100);
            this.sidebarPanel.Controls.Add(this.btnClose);
            this.sidebarPanel.Controls.Add(this.btnContact);
            this.sidebarPanel.Controls.Add(this.btnShowFinalManage);
            this.sidebarPanel.Controls.Add(this.btnStudentManage);
            this.sidebarPanel.Controls.Add(this.btnSeatManage);
            this.sidebarPanel.Dock = DockStyle.Left;
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Padding = new Padding(10);
            this.sidebarPanel.Size = new Size(200, 650);
            this.sidebarPanel.TabIndex = 1;
            //
            // btnClose
            //
            this.btnClose.BackColor = Color.FromArgb(229, 57, 53);
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Dock = DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("맑은 고딕", 10F, FontStyle.Regular);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(180, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "종료";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // btnContact
            //
            this.btnContact.BackColor = Color.FromArgb(55, 71, 133);
            this.btnContact.Cursor = Cursors.Hand;
            this.btnContact.Dock = DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = FlatStyle.Flat;
            this.btnContact.Font = new Font("맑은 고딕", 10F, FontStyle.Regular);
            this.btnContact.ForeColor = Color.White;
            this.btnContact.Margin = new Padding(0, 0, 0, 10);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new Size(180, 60);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "문의하기";
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            //
            // btnShowFinalManage
            //
            this.btnShowFinalManage.BackColor = Color.FromArgb(55, 71, 133);
            this.btnShowFinalManage.Cursor = Cursors.Hand;
            this.btnShowFinalManage.Dock = DockStyle.Top;
            this.btnShowFinalManage.FlatAppearance.BorderSize = 0;
            this.btnShowFinalManage.FlatStyle = FlatStyle.Flat;
            this.btnShowFinalManage.Font = new Font("맑은 고딕", 10F, FontStyle.Regular);
            this.btnShowFinalManage.ForeColor = Color.White;
            this.btnShowFinalManage.Margin = new Padding(0, 0, 0, 10);
            this.btnShowFinalManage.Name = "btnShowFinalManage";
            this.btnShowFinalManage.Size = new Size(180, 60);
            this.btnShowFinalManage.TabIndex = 3;
            this.btnShowFinalManage.Text = "자리 배치 및 수정";
            this.btnShowFinalManage.Click += new System.EventHandler(this.btnShowOnClicked);
            //
            // btnStudentManage
            //
            this.btnStudentManage.BackColor = Color.FromArgb(55, 71, 133);
            this.btnStudentManage.Cursor = Cursors.Hand;
            this.btnStudentManage.Dock = DockStyle.Top;
            this.btnStudentManage.FlatAppearance.BorderSize = 0;
            this.btnStudentManage.FlatStyle = FlatStyle.Flat;
            this.btnStudentManage.Font = new Font("맑은 고딕", 10F, FontStyle.Regular);
            this.btnStudentManage.ForeColor = Color.White;
            this.btnStudentManage.Margin = new Padding(0, 0, 0, 10);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new Size(180, 60);
            this.btnStudentManage.TabIndex = 2;
            this.btnStudentManage.Text = "학생 명부 관리";
            this.btnStudentManage.Click += new System.EventHandler(this.StudentControllClick);
            //
            // btnSeatManage
            //
            this.btnSeatManage.BackColor = Color.FromArgb(55, 71, 133);
            this.btnSeatManage.Cursor = Cursors.Hand;
            this.btnSeatManage.Dock = DockStyle.Top;
            this.btnSeatManage.FlatAppearance.BorderSize = 0;
            this.btnSeatManage.FlatStyle = FlatStyle.Flat;
            this.btnSeatManage.Font = new Font("맑은 고딕", 10F, FontStyle.Regular);
            this.btnSeatManage.ForeColor = Color.White;
            this.btnSeatManage.Margin = new Padding(0, 0, 0, 10);
            this.btnSeatManage.Name = "btnSeatManage";
            this.btnSeatManage.Size = new Size(180, 60);
            this.btnSeatManage.TabIndex = 1;
            this.btnSeatManage.Text = "좌석 관리";
            this.btnSeatManage.Click += new System.EventHandler(this.btnSeatOnClicked);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(850, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.DrawerShowIconsWhenHidden = false;
            this.DrawerTabControl = null;
            this.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "자리 배치 프로그램";
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Panel sidebarPanel;
        private Button btnSeatManage;
        private Button btnStudentManage;
        private Button btnShowFinalManage;
        private Button btnClose;
        private Button btnContact;
    }
}
