using System.Windows.Forms;
using System.Drawing;

namespace TeacherSeatSetter {
    partial class StudentControl {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        private void InitializeComponent() {
            var headerCellStyle = new DataGridViewCellStyle();
            var defaultCellStyle = new DataGridViewCellStyle();
            var rowHeaderCellStyle = new DataGridViewCellStyle();

            this.comboClass = new ComboBox();
            this.btnDelete = new Button();
            this.txtClassName = new TextBox();
            this.btnCreateClass = new Button();
            this.grdStudentList = new DataGridView();
            this.number = new DataGridViewTextBoxColumn();
            this.name = new DataGridViewTextBoxColumn();
            this.className = new DataGridViewTextBoxColumn();
            this.seatNumber = new DataGridViewTextBoxColumn();
            this.lblStudentName = new Label();
            this.txtStudentName = new TextBox();
            this.lblStudentNumber = new Label();
            this.txtStudentNumber = new TextBox();
            this.btnAddStudent = new Button();
            this.btnEditStudent = new Button();
            this.btnDeleteStudent = new Button();
            this.btnExcelDownload = new Button();
            this.btnExcelUpload = new Button();
            this.lblSectionClass = new Label();
            this.lblSectionEdit = new Label();
            this.lblSectionExcel = new Label();
            this.separatorLine1 = new Panel();
            this.separatorLine2 = new Panel();
            this.separatorLine3 = new Panel();

            ((System.ComponentModel.ISupportInitialize)(this.grdStudentList)).BeginInit();
            this.SuspendLayout();

            // ═══════════════════════════════════════════════
            // 섹션 1: 반 관리 (y=0~44)
            // ═══════════════════════════════════════════════
            //
            // lblSectionClass
            //
            this.lblSectionClass.Text = "반 관리";
            this.lblSectionClass.Location = new Point(10, 4);
            this.lblSectionClass.Size = new Size(60, 16);
            this.lblSectionClass.Font = new Font("맑은 고딕", 8F, FontStyle.Bold);
            this.lblSectionClass.ForeColor = Color.FromArgb(120, 120, 120);
            //
            // comboClass
            //
            this.comboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboClass.Font = new Font("맑은 고딕", 10F);
            this.comboClass.Location = new Point(10, 22);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new Size(210, 25);
            this.comboClass.TabIndex = 0;
            this.comboClass.SelectionChangeCommitted += new System.EventHandler(this.comboClass_SelectionChangeCommitted);
            //
            // btnDelete
            //
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnDelete.Font = new Font("맑은 고딕", 8.5F);
            this.btnDelete.Location = new Point(225, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(65, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "반 삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // txtClassName
            //
            this.txtClassName.Font = new Font("맑은 고딕", 10F);
            this.txtClassName.Location = new Point(310, 22);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new Size(170, 25);
            //
            // btnCreateClass
            //
            this.btnCreateClass.FlatStyle = FlatStyle.Flat;
            this.btnCreateClass.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnCreateClass.Font = new Font("맑은 고딕", 8.5F);
            this.btnCreateClass.Location = new Point(485, 21);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new Size(75, 27);
            this.btnCreateClass.Text = "반 추가";
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            //
            // separatorLine1
            //
            this.separatorLine1.BackColor = Color.FromArgb(230, 230, 230);
            this.separatorLine1.Location = new Point(10, 55);
            this.separatorLine1.Size = new Size(553, 1);

            // ═══════════════════════════════════════════════
            // 섹션 2: 학생 목록 (y=58~468)
            // ═══════════════════════════════════════════════
            //
            // grdStudentList
            //
            this.grdStudentList.AllowUserToAddRows = false;
            this.grdStudentList.AllowUserToDeleteRows = false;
            this.grdStudentList.AllowUserToOrderColumns = true;
            this.grdStudentList.AllowUserToResizeRows = false;
            this.grdStudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentList.BackgroundColor = Color.White;
            this.grdStudentList.BorderStyle = BorderStyle.None;
            this.grdStudentList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.grdStudentList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            headerCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerCellStyle.BackColor = Color.FromArgb(55, 71, 133);
            headerCellStyle.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            headerCellStyle.ForeColor = Color.White;
            headerCellStyle.SelectionBackColor = Color.FromArgb(66, 165, 245);
            headerCellStyle.SelectionForeColor = Color.FromArgb(17, 17, 17);
            headerCellStyle.WrapMode = DataGridViewTriState.True;
            this.grdStudentList.ColumnHeadersDefaultCellStyle = headerCellStyle;
            this.grdStudentList.ColumnHeadersHeight = 32;
            this.grdStudentList.Columns.AddRange(new DataGridViewColumn[] {
                this.number, this.name, this.className, this.seatNumber
            });
            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("맑은 고딕", 9.5F);
            defaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(66, 165, 245);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(17, 17, 17);
            defaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.grdStudentList.DefaultCellStyle = defaultCellStyle;
            this.grdStudentList.EnableHeadersVisualStyles = false;
            this.grdStudentList.GridColor = Color.FromArgb(240, 240, 240);
            this.grdStudentList.Location = new Point(10, 60);
            this.grdStudentList.Name = "grdStudentList";
            this.grdStudentList.ReadOnly = true;
            this.grdStudentList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            rowHeaderCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowHeaderCellStyle.BackColor = Color.FromArgb(55, 71, 133);
            rowHeaderCellStyle.Font = new Font("맑은 고딕", 9F);
            rowHeaderCellStyle.ForeColor = Color.White;
            rowHeaderCellStyle.SelectionBackColor = Color.FromArgb(66, 165, 245);
            rowHeaderCellStyle.SelectionForeColor = Color.FromArgb(17, 17, 17);
            rowHeaderCellStyle.WrapMode = DataGridViewTriState.True;
            this.grdStudentList.RowHeadersDefaultCellStyle = rowHeaderCellStyle;
            this.grdStudentList.RowHeadersVisible = false;
            this.grdStudentList.RowHeadersWidth = 40;
            this.grdStudentList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdStudentList.RowTemplate.Height = 26;
            this.grdStudentList.ScrollBars = ScrollBars.Vertical;
            this.grdStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdStudentList.Size = new Size(553, 408);
            this.grdStudentList.TabIndex = 2;
            this.grdStudentList.SelectionChanged += new System.EventHandler(this.grdStudentList_SelectionChanged);
            //
            // number
            //
            this.number.DataPropertyName = "number1";
            this.number.HeaderText = "번호";
            this.number.Name = "number1";
            this.number.ReadOnly = true;
            this.number.FillWeight = 60;
            //
            // name
            //
            this.name.DataPropertyName = "name1";
            this.name.HeaderText = "이름";
            this.name.Name = "name1";
            this.name.ReadOnly = true;
            this.name.FillWeight = 120;
            //
            // className
            //
            this.className.DataPropertyName = "className1";
            this.className.HeaderText = "반";
            this.className.Name = "className1";
            this.className.ReadOnly = true;
            this.className.FillWeight = 80;
            //
            // seatNumber
            //
            this.seatNumber.DataPropertyName = "seatNumber1";
            this.seatNumber.HeaderText = "좌석번호";
            this.seatNumber.Name = "seatNumber1";
            this.seatNumber.ReadOnly = true;
            this.seatNumber.Visible = false;
            //
            // separatorLine2
            //
            this.separatorLine2.BackColor = Color.FromArgb(230, 230, 230);
            this.separatorLine2.Location = new Point(10, 474);
            this.separatorLine2.Size = new Size(553, 1);

            // ═══════════════════════════════════════════════
            // 섹션 3: 학생 편집 (y=478~538)
            // ═══════════════════════════════════════════════
            //
            // lblSectionEdit
            //
            this.lblSectionEdit.Text = "학생 편집";
            this.lblSectionEdit.Location = new Point(10, 480);
            this.lblSectionEdit.Size = new Size(80, 16);
            this.lblSectionEdit.Font = new Font("맑은 고딕", 8F, FontStyle.Bold);
            this.lblSectionEdit.ForeColor = Color.FromArgb(120, 120, 120);
            //
            // lblStudentName
            //
            this.lblStudentName.Text = "이름";
            this.lblStudentName.Location = new Point(10, 503);
            this.lblStudentName.Size = new Size(35, 20);
            this.lblStudentName.Font = new Font("맑은 고딕", 9F);
            this.lblStudentName.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtStudentName
            //
            this.txtStudentName.Font = new Font("맑은 고딕", 10F);
            this.txtStudentName.Location = new Point(48, 500);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new Size(180, 25);
            this.txtStudentName.TabIndex = 3;
            //
            // lblStudentNumber
            //
            this.lblStudentNumber.Text = "번호";
            this.lblStudentNumber.Location = new Point(235, 503);
            this.lblStudentNumber.Size = new Size(35, 20);
            this.lblStudentNumber.Font = new Font("맑은 고딕", 9F);
            this.lblStudentNumber.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtStudentNumber
            //
            this.txtStudentNumber.Font = new Font("맑은 고딕", 10F);
            this.txtStudentNumber.Location = new Point(273, 500);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new Size(80, 25);
            this.txtStudentNumber.TabIndex = 4;
            //
            // btnAddStudent
            //
            this.btnAddStudent.FlatStyle = FlatStyle.Flat;
            this.btnAddStudent.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnAddStudent.Font = new Font("맑은 고딕", 8.5F);
            this.btnAddStudent.Location = new Point(370, 499);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new Size(60, 27);
            this.btnAddStudent.Text = "추가";
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            //
            // btnEditStudent
            //
            this.btnEditStudent.FlatStyle = FlatStyle.Flat;
            this.btnEditStudent.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnEditStudent.Font = new Font("맑은 고딕", 8.5F);
            this.btnEditStudent.Location = new Point(435, 499);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new Size(60, 27);
            this.btnEditStudent.Text = "수정";
            this.btnEditStudent.TabIndex = 6;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            //
            // btnDeleteStudent
            //
            this.btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            this.btnDeleteStudent.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnDeleteStudent.Font = new Font("맑은 고딕", 8.5F);
            this.btnDeleteStudent.Location = new Point(500, 499);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new Size(60, 27);
            this.btnDeleteStudent.Text = "삭제";
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            //
            // separatorLine3
            //
            this.separatorLine3.BackColor = Color.FromArgb(230, 230, 230);
            this.separatorLine3.Location = new Point(10, 538);
            this.separatorLine3.Size = new Size(553, 1);

            // ═══════════════════════════════════════════════
            // 섹션 4: Excel 가져오기 (y=542~600)
            // ═══════════════════════════════════════════════
            //
            // lblSectionExcel
            //
            this.lblSectionExcel.Text = "Excel 가져오기";
            this.lblSectionExcel.Location = new Point(10, 544);
            this.lblSectionExcel.Size = new Size(110, 16);
            this.lblSectionExcel.Font = new Font("맑은 고딕", 8F, FontStyle.Bold);
            this.lblSectionExcel.ForeColor = Color.FromArgb(120, 120, 120);
            //
            // btnExcelDownload
            //
            this.btnExcelDownload.FlatStyle = FlatStyle.Flat;
            this.btnExcelDownload.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnExcelDownload.Font = new Font("맑은 고딕", 8.5F);
            this.btnExcelDownload.Location = new Point(10, 564);
            this.btnExcelDownload.Name = "btnExcelDownload";
            this.btnExcelDownload.Size = new Size(270, 36);
            this.btnExcelDownload.Text = "샘플 양식 다운로드";
            this.btnExcelDownload.TabIndex = 8;
            this.btnExcelDownload.Click += new System.EventHandler(this.whenExcelSampleDownloadClicked);
            //
            // btnExcelUpload
            //
            this.btnExcelUpload.FlatStyle = FlatStyle.Flat;
            this.btnExcelUpload.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            this.btnExcelUpload.Font = new Font("맑은 고딕", 8.5F);
            this.btnExcelUpload.Location = new Point(290, 564);
            this.btnExcelUpload.Name = "btnExcelUpload";
            this.btnExcelUpload.Size = new Size(270, 36);
            this.btnExcelUpload.Text = "엑셀에서 학생 가져오기";
            this.btnExcelUpload.TabIndex = 9;
            this.btnExcelUpload.Click += new System.EventHandler(this.whenExcelUploadClicked);

            // ═══════════════════════════════════════════════
            // StudentControl
            // ═══════════════════════════════════════════════
            this.AutoScaleDimensions = new SizeF(7F, 12F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.lblSectionClass);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.separatorLine1);
            this.Controls.Add(this.grdStudentList);
            this.Controls.Add(this.separatorLine2);
            this.Controls.Add(this.lblSectionEdit);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.separatorLine3);
            this.Controls.Add(this.lblSectionExcel);
            this.Controls.Add(this.btnExcelDownload);
            this.Controls.Add(this.btnExcelUpload);
            this.Margin = new Padding(5);
            this.Name = "StudentControl";
            this.Size = new Size(583, 608);
            this.BackColor = Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // 반 관리
        private ComboBox comboClass;
        private Button btnDelete;
        private TextBox txtClassName;
        private Button btnCreateClass;

        // 학생 목록
        private DataGridView grdStudentList;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn seatNumber;

        // 학생 편집
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblStudentNumber;
        private TextBox txtStudentNumber;
        private Button btnAddStudent;
        private Button btnEditStudent;
        private Button btnDeleteStudent;

        // Excel
        private Button btnExcelDownload;
        private Button btnExcelUpload;

        // 섹션 라벨 & 구분선
        private Label lblSectionClass;
        private Label lblSectionEdit;
        private Label lblSectionExcel;
        private Panel separatorLine1;
        private Panel separatorLine2;
        private Panel separatorLine3;
    }
}
