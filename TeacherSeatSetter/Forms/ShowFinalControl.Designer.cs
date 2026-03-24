using System.Drawing;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    partial class ShowFinalControl {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        private void InitializeComponent() {
            this.leftPanel = new Panel();
            this.lblClassSection = new Label();
            this.lv_Classes = new ListView();
            this.lblSeatSection = new Label();
            this.lv_Seats = new ListView();
            this.separator1 = new Panel();
            this.btn_Random = new Button();
            this.btn_Capture = new Button();
            this.separator2 = new Panel();
            this.btn_Save = new Button();
            this.btn_Load = new Button();

            this.contentPanel = new Panel();
            this.tile_teacherTable = new Panel();
            this.lblTeacherTable = new Label();

            this.lblUnassigned = new Label();
            this.lstUnassigned = new ListBox();

            this.leftPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();

            // ══════════════════════════════════════════
            // 좌측 패널 (138px)
            // ══════════════════════════════════════════
            this.leftPanel.BackColor = Color.FromArgb(248, 249, 252);
            this.leftPanel.Location = new Point(0, 0);
            this.leftPanel.Size = new Size(138, 608);

            // 반 선택 섹션
            this.lblClassSection.Text = "반 선택";
            this.lblClassSection.Font = new Font("맑은 고딕", 8F, FontStyle.Bold);
            this.lblClassSection.ForeColor = Color.FromArgb(117, 117, 117);
            this.lblClassSection.Location = new Point(8, 8);
            this.lblClassSection.Size = new Size(122, 18);

            this.lv_Classes.Font = new Font("맑은 고딕", 10F);
            this.lv_Classes.FullRowSelect = true;
            this.lv_Classes.HeaderStyle = ColumnHeaderStyle.None;
            this.lv_Classes.HideSelection = false;
            this.lv_Classes.MultiSelect = false;
            this.lv_Classes.Location = new Point(8, 28);
            this.lv_Classes.Size = new Size(122, 170);
            this.lv_Classes.TabStop = false;
            this.lv_Classes.BorderStyle = BorderStyle.FixedSingle;
            this.lv_Classes.UseCompatibleStateImageBehavior = false;
            this.lv_Classes.View = View.List;
            this.lv_Classes.SelectedIndexChanged += new System.EventHandler(this.whenClassesListIndexChanged);

            // 교실 선택 섹션
            this.lblSeatSection.Text = "교실 선택";
            this.lblSeatSection.Font = new Font("맑은 고딕", 8F, FontStyle.Bold);
            this.lblSeatSection.ForeColor = Color.FromArgb(117, 117, 117);
            this.lblSeatSection.Location = new Point(8, 206);
            this.lblSeatSection.Size = new Size(122, 18);

            this.lv_Seats.Font = new Font("맑은 고딕", 10F);
            this.lv_Seats.FullRowSelect = true;
            this.lv_Seats.HeaderStyle = ColumnHeaderStyle.None;
            this.lv_Seats.HideSelection = false;
            this.lv_Seats.MultiSelect = false;
            this.lv_Seats.Location = new Point(8, 226);
            this.lv_Seats.Size = new Size(122, 130);
            this.lv_Seats.TabStop = false;
            this.lv_Seats.BorderStyle = BorderStyle.FixedSingle;
            this.lv_Seats.UseCompatibleStateImageBehavior = false;
            this.lv_Seats.View = View.List;
            this.lv_Seats.SelectedIndexChanged += new System.EventHandler(this.whenSeatListIndexChanged);

            // 구분선 1
            this.separator1.BackColor = Color.FromArgb(224, 224, 224);
            this.separator1.Location = new Point(8, 370);
            this.separator1.Size = new Size(122, 1);

            // 배치 액션 버튼
            this.btn_Random.Text = "랜덤 배치";
            this.btn_Random.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            this.btn_Random.BackColor = Color.FromArgb(66, 165, 245);
            this.btn_Random.ForeColor = Color.White;
            this.btn_Random.FlatStyle = FlatStyle.Flat;
            this.btn_Random.FlatAppearance.BorderSize = 0;
            this.btn_Random.Cursor = Cursors.Hand;
            this.btn_Random.Location = new Point(8, 380);
            this.btn_Random.Size = new Size(122, 38);
            this.btn_Random.TabStop = false;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);

            this.btn_Capture.Text = "캡쳐하기";
            this.btn_Capture.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            this.btn_Capture.BackColor = Color.FromArgb(255, 167, 38);
            this.btn_Capture.ForeColor = Color.White;
            this.btn_Capture.FlatStyle = FlatStyle.Flat;
            this.btn_Capture.FlatAppearance.BorderSize = 0;
            this.btn_Capture.Cursor = Cursors.Hand;
            this.btn_Capture.Location = new Point(8, 422);
            this.btn_Capture.Size = new Size(122, 38);
            this.btn_Capture.TabStop = false;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);

            // 구분선 2
            this.separator2.BackColor = Color.FromArgb(224, 224, 224);
            this.separator2.Location = new Point(8, 472);
            this.separator2.Size = new Size(122, 1);

            // 저장/불러오기 버튼
            this.btn_Save.Text = "배치 저장";
            this.btn_Save.Font = new Font("맑은 고딕", 9F);
            this.btn_Save.BackColor = Color.FromArgb(76, 175, 80);
            this.btn_Save.ForeColor = Color.White;
            this.btn_Save.FlatStyle = FlatStyle.Flat;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.Cursor = Cursors.Hand;
            this.btn_Save.Location = new Point(8, 482);
            this.btn_Save.Size = new Size(122, 34);
            this.btn_Save.TabStop = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);

            this.btn_Load.Text = "불러오기";
            this.btn_Load.Font = new Font("맑은 고딕", 9F);
            this.btn_Load.BackColor = Color.FromArgb(158, 158, 158);
            this.btn_Load.ForeColor = Color.White;
            this.btn_Load.FlatStyle = FlatStyle.Flat;
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.Cursor = Cursors.Hand;
            this.btn_Load.Location = new Point(8, 520);
            this.btn_Load.Size = new Size(122, 34);
            this.btn_Load.TabStop = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);

            // leftPanel에 컨트롤 추가
            this.leftPanel.Controls.Add(this.lblClassSection);
            this.leftPanel.Controls.Add(this.lv_Classes);
            this.leftPanel.Controls.Add(this.lblSeatSection);
            this.leftPanel.Controls.Add(this.lv_Seats);
            this.leftPanel.Controls.Add(this.separator1);
            this.leftPanel.Controls.Add(this.btn_Random);
            this.leftPanel.Controls.Add(this.btn_Capture);
            this.leftPanel.Controls.Add(this.separator2);
            this.leftPanel.Controls.Add(this.btn_Save);
            this.leftPanel.Controls.Add(this.btn_Load);

            // ══════════════════════════════════════════
            // 중앙 contentPanel (728x607)
            // ══════════════════════════════════════════
            this.contentPanel.Location = new Point(138, 0);
            this.contentPanel.Size = new Size(728, 607);
            this.contentPanel.BackColor = Color.White;

            this.tile_teacherTable.BackColor = Color.FromArgb(40, 53, 100);
            this.tile_teacherTable.Cursor = Cursors.No;
            this.tile_teacherTable.Location = new Point(299, 540);
            this.tile_teacherTable.Size = new Size(130, 42);
            this.tile_teacherTable.TabStop = false;

            this.lblTeacherTable.Text = "교탁";
            this.lblTeacherTable.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            this.lblTeacherTable.ForeColor = Color.White;
            this.lblTeacherTable.Dock = DockStyle.Fill;
            this.lblTeacherTable.TextAlign = ContentAlignment.MiddleCenter;
            this.tile_teacherTable.Controls.Add(this.lblTeacherTable);
            this.contentPanel.Controls.Add(this.tile_teacherTable);

            // ══════════════════════════════════════════
            // 우측: 미배치 학생 (135px)
            // ══════════════════════════════════════════
            this.lblUnassigned.BackColor = Color.FromArgb(40, 53, 100);
            this.lblUnassigned.ForeColor = Color.White;
            this.lblUnassigned.Location = new Point(866, 0);
            this.lblUnassigned.Size = new Size(135, 30);
            this.lblUnassigned.Text = "  미배치 학생";
            this.lblUnassigned.TextAlign = ContentAlignment.MiddleLeft;
            this.lblUnassigned.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);

            this.lstUnassigned.AllowDrop = true;
            this.lstUnassigned.BorderStyle = BorderStyle.FixedSingle;
            this.lstUnassigned.Font = new Font("맑은 고딕", 10F);
            this.lstUnassigned.FormattingEnabled = true;
            this.lstUnassigned.ItemHeight = 20;
            this.lstUnassigned.Location = new Point(866, 30);
            this.lstUnassigned.Size = new Size(135, 578);
            this.lstUnassigned.TabStop = false;
            this.lstUnassigned.MouseDown += new MouseEventHandler(this.lstUnassigned_MouseDown);
            this.lstUnassigned.DragEnter += new DragEventHandler(this.lstUnassigned_DragEnter);
            this.lstUnassigned.DragDrop += new DragEventHandler(this.lstUnassigned_DragDrop);

            // ══════════════════════════════════════════
            // ShowFinalControl
            // ══════════════════════════════════════════
            this.AutoScaleDimensions = new SizeF(7F, 12F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.lstUnassigned);
            this.Controls.Add(this.lblUnassigned);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "ShowFinalControl";
            this.Size = new Size(1001, 608);
            this.BackColor = Color.White;
            this.leftPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Label lblClassSection;
        private ListView lv_Classes;
        private Label lblSeatSection;
        private ListView lv_Seats;
        private Panel separator1;
        private Panel separator2;
        private Button btn_Random;
        private Button btn_Capture;
        private Button btn_Save;
        private Button btn_Load;

        private Panel contentPanel;
        private Panel tile_teacherTable;
        private Label lblTeacherTable;

        private Label lblUnassigned;
        private ListBox lstUnassigned;
    }
}
