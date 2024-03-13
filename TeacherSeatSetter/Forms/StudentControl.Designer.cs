namespace TeacherSeatSetter {
    partial class StudentControl {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdStudentList = new MetroFramework.Controls.MetroGrid();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboClass = new MetroFramework.Controls.MetroComboBox();
            this.btnExcelDownload = new MetroFramework.Controls.MetroButton();
            this.btnExcelUpload = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudentList
            // 
            this.grdStudentList.AllowUserToAddRows = false;
            this.grdStudentList.AllowUserToDeleteRows = false;
            this.grdStudentList.AllowUserToOrderColumns = true;
            this.grdStudentList.AllowUserToResizeRows = false;
            this.grdStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStudentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdStudentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("넥슨Lv2고딕 OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.className,
            this.seatNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("넥슨Lv2고딕", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdStudentList.EnableHeadersVisualStyles = false;
            this.grdStudentList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdStudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStudentList.Location = new System.Drawing.Point(5, 40);
            this.grdStudentList.Margin = new System.Windows.Forms.Padding(5);
            this.grdStudentList.Name = "grdStudentList";
            this.grdStudentList.ReadOnly = true;
            this.grdStudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdStudentList.RowHeadersVisible = false;
            this.grdStudentList.RowHeadersWidth = 40;
            this.grdStudentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdStudentList.RowTemplate.Height = 23;
            this.grdStudentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudentList.Size = new System.Drawing.Size(380, 615);
            this.grdStudentList.TabIndex = 1;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "학번";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "학생이름";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // className
            // 
            this.className.DataPropertyName = "className";
            this.className.HeaderText = "반";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // seatNumber
            // 
            this.seatNumber.DataPropertyName = "seatNumber";
            this.seatNumber.HeaderText = "좌석번호";
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.ReadOnly = true;
            this.seatNumber.Visible = false;
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.ItemHeight = 23;
            this.comboClass.Items.AddRange(new object[] {
            "테스트1",
            "테스트2"});
            this.comboClass.Location = new System.Drawing.Point(5, 5);
            this.comboClass.Margin = new System.Windows.Forms.Padding(5);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(252, 29);
            this.comboClass.TabIndex = 0;
            this.comboClass.UseSelectable = true;
            this.comboClass.SelectionChangeCommitted += new System.EventHandler(this.comboClass_SelectionChangeCommitted);
            // 
            // btnExcelDownload
            // 
            this.btnExcelDownload.BackgroundImage = global::TeacherSeatSetter.Properties.Resources.excelDownloadIcon;
            this.btnExcelDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelDownload.Location = new System.Drawing.Point(541, 120);
            this.btnExcelDownload.Name = "btnExcelDownload";
            this.btnExcelDownload.Size = new System.Drawing.Size(128, 128);
            this.btnExcelDownload.TabIndex = 2;
            this.btnExcelDownload.UseSelectable = true;
            this.btnExcelDownload.Click += new System.EventHandler(this.whenExcelSampleDownloadClicked);
            // 
            // btnExcelUpload
            // 
            this.btnExcelUpload.BackgroundImage = global::TeacherSeatSetter.Properties.Resources.excelUploadIcon;
            this.btnExcelUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelUpload.Location = new System.Drawing.Point(541, 381);
            this.btnExcelUpload.Name = "btnExcelUpload";
            this.btnExcelUpload.Size = new System.Drawing.Size(128, 128);
            this.btnExcelUpload.TabIndex = 3;
            this.btnExcelUpload.UseSelectable = true;
            this.btnExcelUpload.Click += new System.EventHandler(this.whenExcelUploadClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(265, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 29);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExcelUpload);
            this.Controls.Add(this.btnExcelDownload);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.grdStudentList);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(795, 660);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdStudentList;
        private MetroFramework.Controls.MetroComboBox comboClass;
        private MetroFramework.Controls.MetroButton btnExcelDownload;
        private MetroFramework.Controls.MetroButton btnExcelUpload;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumber;
    }
}
