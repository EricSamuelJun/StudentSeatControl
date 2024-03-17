using MetroFramework.Controls;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    partial class ShowFinalControl {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.lv_Classes = new MetroFramework.Controls.MetroListView();
            this.lv_Seats = new MetroFramework.Controls.MetroListView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Capture = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Classes
            // 
            this.lv_Classes.Font = new System.Drawing.Font("넥슨Lv2고딕", 20F);
            this.lv_Classes.FullRowSelect = true;
            this.lv_Classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Classes.HideSelection = false;
            this.lv_Classes.Location = new System.Drawing.Point(0, 0);
            this.lv_Classes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Classes.MultiSelect = false;
            this.lv_Classes.Name = "lv_Classes";
            this.lv_Classes.OwnerDraw = true;
            this.lv_Classes.Size = new System.Drawing.Size(150, 349);
            this.lv_Classes.TabIndex = 0;
            this.lv_Classes.TabStop = false;
            this.lv_Classes.UseCompatibleStateImageBehavior = false;
            this.lv_Classes.UseSelectable = true;
            this.lv_Classes.View = System.Windows.Forms.View.List;
            this.lv_Classes.SelectedIndexChanged += new System.EventHandler(this.whenClassesListIndexChanged);
            // 
            // lv_Seats
            // 
            this.lv_Seats.Font = new System.Drawing.Font("넥슨Lv2고딕", 20F);
            this.lv_Seats.FullRowSelect = true;
            this.lv_Seats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Seats.HideSelection = false;
            this.lv_Seats.Location = new System.Drawing.Point(0, 410);
            this.lv_Seats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Seats.MultiSelect = false;
            this.lv_Seats.Name = "lv_Seats";
            this.lv_Seats.OwnerDraw = true;
            this.lv_Seats.Size = new System.Drawing.Size(150, 349);
            this.lv_Seats.TabIndex = 1;
            this.lv_Seats.TabStop = false;
            this.lv_Seats.UseCompatibleStateImageBehavior = false;
            this.lv_Seats.UseSelectable = true;
            this.lv_Seats.View = System.Windows.Forms.View.List;
            this.lv_Seats.SelectedIndexChanged += new System.EventHandler(this.whenSeatListIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(150, 1);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(759, 759);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // btn_Capture
            // 
            this.btn_Capture.BackColor = System.Drawing.Color.Gold;
            this.btn_Capture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Capture.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Capture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Capture.Location = new System.Drawing.Point(0, 350);
            this.btn_Capture.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(151, 60);
            this.btn_Capture.TabIndex = 3;
            this.btn_Capture.TabStop = false;
            this.btn_Capture.Text = "캡쳐하기";
            this.btn_Capture.UseCustomBackColor = true;
            this.btn_Capture.UseSelectable = true;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(96, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 524);
            this.panel1.TabIndex = 2;
            // 
            // ShowFinalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lv_Seats);
            this.Controls.Add(this.lv_Classes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowFinalControl";
            this.Size = new System.Drawing.Size(909, 760);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lv_Classes;
        private MetroFramework.Controls.MetroListView lv_Seats;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroButton btn_Capture;
        private Panel panel1;
    }
}
