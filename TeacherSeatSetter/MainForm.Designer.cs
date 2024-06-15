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
            this.btnSeatManage = new MetroFramework.Controls.MetroButton();
            this.btnStudentManage = new MetroFramework.Controls.MetroButton();
            this.btnShowFinalManage = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MarginPanelBetweenBtn4 = new System.Windows.Forms.Panel();
            this.btnContact = new MetroFramework.Controls.MetroButton();
            this.MarginPanelBetweenBtn3 = new System.Windows.Forms.Panel();
            this.MarginPanelBetweenBtn2 = new System.Windows.Forms.Panel();
            this.MarginPanelBetweenBtn1 = new System.Windows.Forms.Panel();
            this.marginPanelWithContentPanels = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.HorizontalScrollbarBarColor = true;
            this.contentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.contentPanel.HorizontalScrollbarSize = 10;
            this.contentPanel.Location = new System.Drawing.Point(210, 32);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.MaximumSize = new System.Drawing.Size(1000, 900);
            this.contentPanel.MinimumSize = new System.Drawing.Size(2, 300);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(620, 646);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.VerticalScrollbarBarColor = true;
            this.contentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.contentPanel.VerticalScrollbarSize = 10;
            // 
            // btnSeatManage
            // 
            this.btnSeatManage.BackColor = System.Drawing.Color.Cyan;
            this.btnSeatManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeatManage.Location = new System.Drawing.Point(5, 5);
            this.btnSeatManage.Name = "btnSeatManage";
            this.btnSeatManage.Size = new System.Drawing.Size(166, 131);
            this.btnSeatManage.TabIndex = 2;
            this.btnSeatManage.Text = "좌석관리";
            this.btnSeatManage.UseSelectable = true;
            this.btnSeatManage.Click += new System.EventHandler(this.btnSeatOnClicked);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentManage.Location = new System.Drawing.Point(5, 146);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(166, 139);
            this.btnStudentManage.TabIndex = 3;
            this.btnStudentManage.Text = "학생명부 관리";
            this.btnStudentManage.UseSelectable = true;
            this.btnStudentManage.Click += new System.EventHandler(this.StudentControllClick);
            // 
            // btnShowFinalManage
            // 
            this.btnShowFinalManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFinalManage.Location = new System.Drawing.Point(5, 295);
            this.btnShowFinalManage.Name = "btnShowFinalManage";
            this.btnShowFinalManage.Size = new System.Drawing.Size(166, 124);
            this.btnShowFinalManage.TabIndex = 4;
            this.btnShowFinalManage.Text = "좌석 수정";
            this.btnShowFinalManage.UseSelectable = true;
            this.btnShowFinalManage.Click += new System.EventHandler(this.btnShowOnClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(5, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 70);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "프로그램 종료";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnClose);
            this.metroPanel1.Controls.Add(this.MarginPanelBetweenBtn4);
            this.metroPanel1.Controls.Add(this.btnContact);
            this.metroPanel1.Controls.Add(this.MarginPanelBetweenBtn3);
            this.metroPanel1.Controls.Add(this.btnShowFinalManage);
            this.metroPanel1.Controls.Add(this.MarginPanelBetweenBtn2);
            this.metroPanel1.Controls.Add(this.btnStudentManage);
            this.metroPanel1.Controls.Add(this.MarginPanelBetweenBtn1);
            this.metroPanel1.Controls.Add(this.btnSeatManage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 32);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel1.Size = new System.Drawing.Size(178, 646);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MarginPanelBetweenBtn4
            // 
            this.MarginPanelBetweenBtn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarginPanelBetweenBtn4.Location = new System.Drawing.Point(5, 553);
            this.MarginPanelBetweenBtn4.Name = "MarginPanelBetweenBtn4";
            this.MarginPanelBetweenBtn4.Size = new System.Drawing.Size(166, 10);
            this.MarginPanelBetweenBtn4.TabIndex = 5;
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.Location = new System.Drawing.Point(5, 429);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(166, 124);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "문의 연락";
            this.btnContact.UseSelectable = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // MarginPanelBetweenBtn3
            // 
            this.MarginPanelBetweenBtn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarginPanelBetweenBtn3.Location = new System.Drawing.Point(5, 419);
            this.MarginPanelBetweenBtn3.Name = "MarginPanelBetweenBtn3";
            this.MarginPanelBetweenBtn3.Size = new System.Drawing.Size(166, 10);
            this.MarginPanelBetweenBtn3.TabIndex = 5;
            // 
            // MarginPanelBetweenBtn2
            // 
            this.MarginPanelBetweenBtn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarginPanelBetweenBtn2.Location = new System.Drawing.Point(5, 285);
            this.MarginPanelBetweenBtn2.Name = "MarginPanelBetweenBtn2";
            this.MarginPanelBetweenBtn2.Size = new System.Drawing.Size(166, 10);
            this.MarginPanelBetweenBtn2.TabIndex = 5;
            // 
            // MarginPanelBetweenBtn1
            // 
            this.MarginPanelBetweenBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarginPanelBetweenBtn1.Location = new System.Drawing.Point(5, 136);
            this.MarginPanelBetweenBtn1.Name = "MarginPanelBetweenBtn1";
            this.MarginPanelBetweenBtn1.Size = new System.Drawing.Size(166, 10);
            this.MarginPanelBetweenBtn1.TabIndex = 5;
            // 
            // marginPanelWithContentPanels
            // 
            this.marginPanelWithContentPanels.Dock = System.Windows.Forms.DockStyle.Right;
            this.marginPanelWithContentPanels.Location = new System.Drawing.Point(200, 32);
            this.marginPanelWithContentPanels.Name = "marginPanelWithContentPanels";
            this.marginPanelWithContentPanels.Size = new System.Drawing.Size(10, 646);
            this.marginPanelWithContentPanels.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.marginPanelWithContentPanels);
            this.Controls.Add(this.contentPanel);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("넥슨Lv2고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 32, 20, 22);
            this.Resizable = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(181)))));
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel contentPanel;
        private Panel marginPanelWithContentPanels;
        
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSeatManage;
        private MetroFramework.Controls.MetroButton btnStudentManage;
        private MetroFramework.Controls.MetroButton btnShowFinalManage;
        private MetroFramework.Controls.MetroButton btnClose;
        private Panel MarginPanelBetweenBtn1;
        private Panel MarginPanelBetweenBtn2;
        private Panel MarginPanelBetweenBtn3;
        private Panel MarginPanelBetweenBtn4;
        private MetroFramework.Controls.MetroButton btnContact;
    }
}

