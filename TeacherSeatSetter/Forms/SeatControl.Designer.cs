using System.Drawing;
using System.Windows.Forms;

namespace TeacherSeatSetter {
    partial class SeatControl {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        private void InitializeComponent() {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.list_ItemListView = new System.Windows.Forms.ListView();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.separatorLeft = new System.Windows.Forms.Panel();
            this.lblSeatType = new System.Windows.Forms.Label();
            this.btnOneSeat = new System.Windows.Forms.Button();
            this.btnTwoSeat = new System.Windows.Forms.Button();
            this.btnThreeSeat = new System.Windows.Forms.Button();
            this.lblInfoSection = new System.Windows.Forms.Label();
            this.lblSeatCount = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.seatPanel = new System.Windows.Forms.Panel();
            this.tb_SeatName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_People = new System.Windows.Forms.Label();
            this.gridControlPanel = new System.Windows.Forms.Panel();
            this.lblRow = new System.Windows.Forms.Label();
            this.btn_rowNegative = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btn_rowPositive = new System.Windows.Forms.Button();
            this.lblCol = new System.Windows.Forms.Label();
            this.btn_ColNegative = new System.Windows.Forms.Button();
            this.lblColCount = new System.Windows.Forms.Label();
            this.btn_ColPositive = new System.Windows.Forms.Button();
            this.tile_teacherTable = new System.Windows.Forms.Panel();
            this.lblTeacherTable = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.seatPanel.SuspendLayout();
            this.gridControlPanel.SuspendLayout();
            this.tile_teacherTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.leftPanel.Controls.Add(this.list_ItemListView);
            this.leftPanel.Controls.Add(this.btnPanel);
            this.leftPanel.Controls.Add(this.separatorLeft);
            this.leftPanel.Controls.Add(this.lblSeatType);
            this.leftPanel.Controls.Add(this.btnOneSeat);
            this.leftPanel.Controls.Add(this.btnTwoSeat);
            this.leftPanel.Controls.Add(this.btnThreeSeat);
            this.leftPanel.Controls.Add(this.lblInfoSection);
            this.leftPanel.Controls.Add(this.lblSeatCount);
            this.leftPanel.Controls.Add(this.lblCapacity);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 608);
            this.leftPanel.TabIndex = 1;
            // 
            // list_ItemListView
            // 
            this.list_ItemListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_ItemListView.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.list_ItemListView.FullRowSelect = true;
            this.list_ItemListView.HideSelection = false;
            this.list_ItemListView.Location = new System.Drawing.Point(8, 8);
            this.list_ItemListView.Name = "list_ItemListView";
            this.list_ItemListView.Size = new System.Drawing.Size(184, 200);
            this.list_ItemListView.TabIndex = 0;
            this.list_ItemListView.TabStop = false;
            this.list_ItemListView.UseCompatibleStateImageBehavior = false;
            this.list_ItemListView.View = System.Windows.Forms.View.List;
            this.list_ItemListView.SelectedIndexChanged += new System.EventHandler(this.listItemChanged);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btn_Create);
            this.btnPanel.Controls.Add(this.btn_Delete);
            this.btnPanel.Location = new System.Drawing.Point(8, 212);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(184, 32);
            this.btnPanel.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("맑은 고딕", 8.5F);
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(0, 0);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(110, 32);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "+ 새로 만들기";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btnCreateClicked);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 8.5F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(114, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(70, 32);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btnDeleteClicked);
            // 
            // separatorLeft
            // 
            this.separatorLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.separatorLeft.Location = new System.Drawing.Point(8, 254);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Size = new System.Drawing.Size(184, 1);
            this.separatorLeft.TabIndex = 2;
            // 
            // lblSeatType
            // 
            this.lblSeatType.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeatType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblSeatType.Location = new System.Drawing.Point(8, 264);
            this.lblSeatType.Name = "lblSeatType";
            this.lblSeatType.Size = new System.Drawing.Size(184, 18);
            this.lblSeatType.TabIndex = 3;
            this.lblSeatType.Text = "좌석 종류";
            // 
            // btnOneSeat
            // 
            this.btnOneSeat.BackColor = System.Drawing.Color.White;
            this.btnOneSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneSeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnOneSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneSeat.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnOneSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnOneSeat.Location = new System.Drawing.Point(8, 286);
            this.btnOneSeat.Name = "btnOneSeat";
            this.btnOneSeat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOneSeat.Size = new System.Drawing.Size(184, 34);
            this.btnOneSeat.TabIndex = 4;
            this.btnOneSeat.Tag = 0;
            this.btnOneSeat.Text = "■  1인석";
            this.btnOneSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOneSeat.UseVisualStyleBackColor = false;
            this.btnOneSeat.Click += new System.EventHandler(this.seatTypeButtonClicked);
            // 
            // btnTwoSeat
            // 
            this.btnTwoSeat.BackColor = System.Drawing.Color.White;
            this.btnTwoSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwoSeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnTwoSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoSeat.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnTwoSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnTwoSeat.Location = new System.Drawing.Point(8, 324);
            this.btnTwoSeat.Name = "btnTwoSeat";
            this.btnTwoSeat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTwoSeat.Size = new System.Drawing.Size(184, 34);
            this.btnTwoSeat.TabIndex = 5;
            this.btnTwoSeat.Tag = 1;
            this.btnTwoSeat.Text = "■  2인석";
            this.btnTwoSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwoSeat.UseVisualStyleBackColor = false;
            this.btnTwoSeat.Click += new System.EventHandler(this.seatTypeButtonClicked);
            // 
            // btnThreeSeat
            // 
            this.btnThreeSeat.BackColor = System.Drawing.Color.White;
            this.btnThreeSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThreeSeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnThreeSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreeSeat.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnThreeSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnThreeSeat.Location = new System.Drawing.Point(8, 362);
            this.btnThreeSeat.Name = "btnThreeSeat";
            this.btnThreeSeat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThreeSeat.Size = new System.Drawing.Size(184, 34);
            this.btnThreeSeat.TabIndex = 6;
            this.btnThreeSeat.Tag = 2;
            this.btnThreeSeat.Text = "■  3인석";
            this.btnThreeSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThreeSeat.UseVisualStyleBackColor = false;
            this.btnThreeSeat.Click += new System.EventHandler(this.seatTypeButtonClicked);
            // 
            // lblInfoSection
            // 
            this.lblInfoSection.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold);
            this.lblInfoSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblInfoSection.Location = new System.Drawing.Point(8, 410);
            this.lblInfoSection.Name = "lblInfoSection";
            this.lblInfoSection.Size = new System.Drawing.Size(184, 18);
            this.lblInfoSection.TabIndex = 7;
            this.lblInfoSection.Text = "정보";
            // 
            // lblSeatCount
            // 
            this.lblSeatCount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblSeatCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSeatCount.Location = new System.Drawing.Point(8, 432);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(184, 20);
            this.lblSeatCount.TabIndex = 8;
            this.lblSeatCount.Text = "총 좌석: 0";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCapacity.Location = new System.Drawing.Point(8, 454);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(184, 20);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "수용 인원: 0명";
            // 
            // seatPanel
            // 
            this.seatPanel.BackColor = System.Drawing.Color.White;
            this.seatPanel.Controls.Add(this.tb_SeatName);
            this.seatPanel.Controls.Add(this.btn_Save);
            this.seatPanel.Controls.Add(this.txt_People);
            this.seatPanel.Controls.Add(this.gridControlPanel);
            this.seatPanel.Controls.Add(this.tile_teacherTable);
            this.seatPanel.Location = new System.Drawing.Point(200, 0);
            this.seatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.seatPanel.Name = "seatPanel";
            this.seatPanel.Size = new System.Drawing.Size(595, 608);
            this.seatPanel.TabIndex = 0;
            // 
            // tb_SeatName
            // 
            this.tb_SeatName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.tb_SeatName.Location = new System.Drawing.Point(12, 10);
            this.tb_SeatName.Name = "tb_SeatName";
            this.tb_SeatName.Size = new System.Drawing.Size(280, 32);
            this.tb_SeatName.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(300, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 34);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btnSaveClicked);
            // 
            // txt_People
            // 
            this.txt_People.AutoSize = true;
            this.txt_People.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txt_People.Location = new System.Drawing.Point(12, 46);
            this.txt_People.Name = "txt_People";
            this.txt_People.Size = new System.Drawing.Size(0, 20);
            this.txt_People.TabIndex = 2;
            this.txt_People.Visible = false;
            // 
            // gridControlPanel
            // 
            this.gridControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.gridControlPanel.Controls.Add(this.lblRow);
            this.gridControlPanel.Controls.Add(this.btn_rowNegative);
            this.gridControlPanel.Controls.Add(this.lblRowCount);
            this.gridControlPanel.Controls.Add(this.btn_rowPositive);
            this.gridControlPanel.Controls.Add(this.lblCol);
            this.gridControlPanel.Controls.Add(this.btn_ColNegative);
            this.gridControlPanel.Controls.Add(this.lblColCount);
            this.gridControlPanel.Controls.Add(this.btn_ColPositive);
            this.gridControlPanel.Location = new System.Drawing.Point(12, 520);
            this.gridControlPanel.Name = "gridControlPanel";
            this.gridControlPanel.Size = new System.Drawing.Size(400, 36);
            this.gridControlPanel.TabIndex = 3;
            // 
            // lblRow
            // 
            this.lblRow.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRow.Location = new System.Drawing.Point(8, 8);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(25, 20);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "열";
            this.lblRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_rowNegative
            // 
            this.btn_rowNegative.BackColor = System.Drawing.Color.White;
            this.btn_rowNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rowNegative.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_rowNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rowNegative.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rowNegative.Location = new System.Drawing.Point(38, 4);
            this.btn_rowNegative.Name = "btn_rowNegative";
            this.btn_rowNegative.Size = new System.Drawing.Size(30, 28);
            this.btn_rowNegative.TabIndex = 1;
            this.btn_rowNegative.Text = "−";
            this.btn_rowNegative.UseVisualStyleBackColor = false;
            this.btn_rowNegative.Click += new System.EventHandler(this.rowDown);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblRowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.lblRowCount.Location = new System.Drawing.Point(72, 8);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(28, 20);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.Text = "0";
            this.lblRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rowPositive
            // 
            this.btn_rowPositive.BackColor = System.Drawing.Color.White;
            this.btn_rowPositive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rowPositive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_rowPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rowPositive.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rowPositive.Location = new System.Drawing.Point(104, 4);
            this.btn_rowPositive.Name = "btn_rowPositive";
            this.btn_rowPositive.Size = new System.Drawing.Size(30, 28);
            this.btn_rowPositive.TabIndex = 3;
            this.btn_rowPositive.Text = "+";
            this.btn_rowPositive.UseVisualStyleBackColor = false;
            this.btn_rowPositive.Click += new System.EventHandler(this.rowUp);
            // 
            // lblCol
            // 
            this.lblCol.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCol.Location = new System.Drawing.Point(160, 8);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(25, 20);
            this.lblCol.TabIndex = 4;
            this.lblCol.Text = "행";
            this.lblCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ColNegative
            // 
            this.btn_ColNegative.BackColor = System.Drawing.Color.White;
            this.btn_ColNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ColNegative.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_ColNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColNegative.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ColNegative.Location = new System.Drawing.Point(190, 4);
            this.btn_ColNegative.Name = "btn_ColNegative";
            this.btn_ColNegative.Size = new System.Drawing.Size(30, 28);
            this.btn_ColNegative.TabIndex = 5;
            this.btn_ColNegative.Text = "−";
            this.btn_ColNegative.UseVisualStyleBackColor = false;
            this.btn_ColNegative.Click += new System.EventHandler(this.colDown);
            // 
            // lblColCount
            // 
            this.lblColCount.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblColCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.lblColCount.Location = new System.Drawing.Point(224, 8);
            this.lblColCount.Name = "lblColCount";
            this.lblColCount.Size = new System.Drawing.Size(28, 20);
            this.lblColCount.TabIndex = 6;
            this.lblColCount.Text = "0";
            this.lblColCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ColPositive
            // 
            this.btn_ColPositive.BackColor = System.Drawing.Color.White;
            this.btn_ColPositive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ColPositive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_ColPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColPositive.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ColPositive.Location = new System.Drawing.Point(256, 4);
            this.btn_ColPositive.Name = "btn_ColPositive";
            this.btn_ColPositive.Size = new System.Drawing.Size(30, 28);
            this.btn_ColPositive.TabIndex = 7;
            this.btn_ColPositive.Text = "+";
            this.btn_ColPositive.UseVisualStyleBackColor = false;
            this.btn_ColPositive.Click += new System.EventHandler(this.colUp);
            // 
            // tile_teacherTable
            // 
            this.tile_teacherTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.tile_teacherTable.Controls.Add(this.lblTeacherTable);
            this.tile_teacherTable.Cursor = System.Windows.Forms.Cursors.No;
            this.tile_teacherTable.Location = new System.Drawing.Point(232, 562);
            this.tile_teacherTable.Name = "tile_teacherTable";
            this.tile_teacherTable.Size = new System.Drawing.Size(130, 40);
            this.tile_teacherTable.TabIndex = 4;
            // 
            // lblTeacherTable
            // 
            this.lblTeacherTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeacherTable.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTeacherTable.ForeColor = System.Drawing.Color.White;
            this.lblTeacherTable.Location = new System.Drawing.Point(0, 0);
            this.lblTeacherTable.Name = "lblTeacherTable";
            this.lblTeacherTable.Size = new System.Drawing.Size(130, 40);
            this.lblTeacherTable.TabIndex = 0;
            this.lblTeacherTable.Text = "교탁";
            this.lblTeacherTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.seatPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "SeatControl";
            this.Size = new System.Drawing.Size(795, 608);
            this.leftPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.seatPanel.ResumeLayout(false);
            this.seatPanel.PerformLayout();
            this.gridControlPanel.ResumeLayout(false);
            this.tile_teacherTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanel;
        private ListView list_ItemListView;
        private Panel btnPanel;
        private Button btn_Create;
        private Button btn_Delete;
        private Panel separatorLeft;
        private Label lblSeatType;
        private Button btnOneSeat;
        private Button btnTwoSeat;
        private Button btnThreeSeat;
        private Label lblInfoSection;
        private Label lblSeatCount;
        private Label lblCapacity;

        private Panel seatPanel;
        private TextBox tb_SeatName;
        private Button btn_Save;
        private Panel tile_teacherTable;
        private Label lblTeacherTable;
        private Label txt_People;

        private Panel gridControlPanel;
        private Label lblRow;
        private Button btn_rowNegative;
        private Label lblRowCount;
        private Button btn_rowPositive;
        private Label lblCol;
        private Button btn_ColNegative;
        private Label lblColCount;
        private Button btn_ColPositive;
    }
}
