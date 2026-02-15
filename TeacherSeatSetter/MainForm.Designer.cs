using System.Windows.Forms;

namespace TeacherSeatSetter {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnContact = new MetroFramework.Controls.MetroButton();
            this.btnShowFinalManage = new MetroFramework.Controls.MetroButton();
            this.btnStudentManage = new MetroFramework.Controls.MetroButton();
            this.btnSeatManage = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.HorizontalScrollbarBarColor = true;
            this.contentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.contentPanel.HorizontalScrollbarSize = 10;
            this.contentPanel.Location = new System.Drawing.Point(200, 30);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(650, 650);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.VerticalScrollbarBarColor = true;
            this.contentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.contentPanel.VerticalScrollbarSize = 10;
            this.contentPanel.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.metroPanel1.Controls.Add(this.btnClose);
            this.metroPanel1.Controls.Add(this.btnContact);
            this.metroPanel1.Controls.Add(this.btnShowFinalManage);
            this.metroPanel1.Controls.Add(this.btnStudentManage);
            this.metroPanel1.Controls.Add(this.btnSeatManage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel1.Size = new System.Drawing.Size(200, 650);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.UseCustomBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(10, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "종료";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnContact.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(10, 220);
            this.btnContact.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(180, 60);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "문의하기";
            this.btnContact.UseCustomBackColor = true;
            this.btnContact.UseCustomForeColor = true;
            this.btnContact.UseSelectable = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnShowFinalManage
            // 
            this.btnShowFinalManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnShowFinalManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFinalManage.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowFinalManage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnShowFinalManage.ForeColor = System.Drawing.Color.White;
            this.btnShowFinalManage.Location = new System.Drawing.Point(10, 150);
            this.btnShowFinalManage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnShowFinalManage.Name = "btnShowFinalManage";
            this.btnShowFinalManage.Size = new System.Drawing.Size(180, 60);
            this.btnShowFinalManage.TabIndex = 3;
            this.btnShowFinalManage.Text = "자리 배치 및 수정";
            this.btnShowFinalManage.UseCustomBackColor = true;
            this.btnShowFinalManage.UseCustomForeColor = true;
            this.btnShowFinalManage.UseSelectable = true;
            this.btnShowFinalManage.Click += new System.EventHandler(this.btnShowOnClicked);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnStudentManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentManage.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStudentManage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStudentManage.ForeColor = System.Drawing.Color.White;
            this.btnStudentManage.Location = new System.Drawing.Point(10, 80);
            this.btnStudentManage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(180, 60);
            this.btnStudentManage.TabIndex = 2;
            this.btnStudentManage.Text = "학생 명부 관리";
            this.btnStudentManage.UseCustomBackColor = true;
            this.btnStudentManage.UseCustomForeColor = true;
            this.btnStudentManage.UseSelectable = true;
            this.btnStudentManage.Click += new System.EventHandler(this.StudentControllClick);
            // 
            // btnSeatManage
            // 
            this.btnSeatManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSeatManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeatManage.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeatManage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeatManage.ForeColor = System.Drawing.Color.White;
            this.btnSeatManage.Location = new System.Drawing.Point(10, 10);
            this.btnSeatManage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnSeatManage.Name = "btnSeatManage";
            this.btnSeatManage.Size = new System.Drawing.Size(180, 60);
            this.btnSeatManage.TabIndex = 1;
            this.btnSeatManage.Text = "좌석 관리";
            this.btnSeatManage.UseCustomBackColor = true;
            this.btnSeatManage.UseCustomForeColor = true;
            this.btnSeatManage.UseSelectable = true;
            this.btnSeatManage.Click += new System.EventHandler(this.btnSeatOnClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.ControlBox = false;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 20);
            this.Resizable = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(181)))));
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel contentPanel;
        
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSeatManage;
        private MetroFramework.Controls.MetroButton btnStudentManage;
        private MetroFramework.Controls.MetroButton btnShowFinalManage;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnContact;
    }
}

