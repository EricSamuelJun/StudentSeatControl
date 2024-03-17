namespace TeacherSeatSetter {
    partial class SeatControl {
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
            this.list_ItemListView = new MetroFramework.Controls.MetroListView();
            this.seatPanel = new MetroFramework.Controls.MetroPanel();
            this.btn_ColPositive = new MetroFramework.Controls.MetroButton();
            this.btn_ColNegative = new MetroFramework.Controls.MetroButton();
            this.btn_rowPositive = new MetroFramework.Controls.MetroButton();
            this.btn_rowNegative = new MetroFramework.Controls.MetroButton();
            this.btn_Create = new MetroFramework.Controls.MetroButton();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.tb_SeatName = new System.Windows.Forms.TextBox();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.tile_teacherTable = new MetroFramework.Controls.MetroTile();
            this.grd_Items = new MetroFramework.Controls.MetroGrid();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_People = new MetroFramework.Controls.MetroLabel();
            this.seatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // list_ItemListView
            // 
            this.list_ItemListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.list_ItemListView.FullRowSelect = true;
            this.list_ItemListView.Location = new System.Drawing.Point(0, 0);
            this.list_ItemListView.Name = "list_ItemListView";
            this.list_ItemListView.OwnerDraw = true;
            this.list_ItemListView.Size = new System.Drawing.Size(200, 400);
            this.list_ItemListView.TabIndex = 3;
            this.list_ItemListView.TabStop = false;
            this.list_ItemListView.UseCompatibleStateImageBehavior = false;
            this.list_ItemListView.UseSelectable = true;
            this.list_ItemListView.View = System.Windows.Forms.View.List;
            this.list_ItemListView.SelectedIndexChanged += new System.EventHandler(this.listItemChanged);
            // 
            // seatPanel
            // 
            this.seatPanel.Controls.Add(this.txt_People);
            this.seatPanel.Controls.Add(this.btn_ColPositive);
            this.seatPanel.Controls.Add(this.btn_ColNegative);
            this.seatPanel.Controls.Add(this.btn_rowPositive);
            this.seatPanel.Controls.Add(this.btn_rowNegative);
            this.seatPanel.Controls.Add(this.btn_Create);
            this.seatPanel.Controls.Add(this.btn_Delete);
            this.seatPanel.Controls.Add(this.tb_SeatName);
            this.seatPanel.Controls.Add(this.btn_Save);
            this.seatPanel.Controls.Add(this.tile_teacherTable);
            this.seatPanel.HorizontalScrollbarBarColor = true;
            this.seatPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.seatPanel.HorizontalScrollbarSize = 10;
            this.seatPanel.Location = new System.Drawing.Point(200, 0);
            this.seatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.seatPanel.Name = "seatPanel";
            this.seatPanel.Size = new System.Drawing.Size(595, 606);
            this.seatPanel.TabIndex = 5;
            this.seatPanel.VerticalScrollbarBarColor = true;
            this.seatPanel.VerticalScrollbarHighlightOnWheel = false;
            this.seatPanel.VerticalScrollbarSize = 10;
            // 
            // btn_ColPositive
            // 
            this.btn_ColPositive.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_ColPositive.Location = new System.Drawing.Point(512, 468);
            this.btn_ColPositive.Name = "btn_ColPositive";
            this.btn_ColPositive.Size = new System.Drawing.Size(75, 64);
            this.btn_ColPositive.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_ColPositive.TabIndex = 14;
            this.btn_ColPositive.Text = "▲";
            this.btn_ColPositive.UseSelectable = true;
            this.btn_ColPositive.Click += new System.EventHandler(this.colUp);
            // 
            // btn_ColNegative
            // 
            this.btn_ColNegative.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_ColNegative.Location = new System.Drawing.Point(512, 538);
            this.btn_ColNegative.Name = "btn_ColNegative";
            this.btn_ColNegative.Size = new System.Drawing.Size(75, 64);
            this.btn_ColNegative.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_ColNegative.TabIndex = 13;
            this.btn_ColNegative.Text = "▼";
            this.btn_ColNegative.UseSelectable = true;
            this.btn_ColNegative.Click += new System.EventHandler(this.colDown);
            // 
            // btn_rowPositive
            // 
            this.btn_rowPositive.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_rowPositive.Location = new System.Drawing.Point(84, 538);
            this.btn_rowPositive.Name = "btn_rowPositive";
            this.btn_rowPositive.Size = new System.Drawing.Size(75, 64);
            this.btn_rowPositive.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_rowPositive.TabIndex = 12;
            this.btn_rowPositive.Text = "▶";
            this.btn_rowPositive.UseSelectable = true;
            this.btn_rowPositive.Click += new System.EventHandler(this.rowUp);
            // 
            // btn_rowNegative
            // 
            this.btn_rowNegative.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_rowNegative.Location = new System.Drawing.Point(3, 538);
            this.btn_rowNegative.Name = "btn_rowNegative";
            this.btn_rowNegative.Size = new System.Drawing.Size(75, 64);
            this.btn_rowNegative.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_rowNegative.TabIndex = 11;
            this.btn_rowNegative.Text = "◀";
            this.btn_rowNegative.UseSelectable = true;
            this.btn_rowNegative.Click += new System.EventHandler(this.rowDown);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Create.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Create.ForeColor = System.Drawing.Color.Black;
            this.btn_Create.Location = new System.Drawing.Point(442, 6);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(145, 36);
            this.btn_Create.TabIndex = 10;
            this.btn_Create.Text = "새로 만들기";
            this.btn_Create.UseCustomBackColor = true;
            this.btn_Create.UseCustomForeColor = true;
            this.btn_Create.UseSelectable = true;
            this.btn_Create.UseStyleColors = true;
            this.btn_Create.Click += new System.EventHandler(this.btnCreateClicked);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Delete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(354, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 36);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseCustomBackColor = true;
            this.btn_Delete.UseCustomForeColor = true;
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.UseStyleColors = true;
            this.btn_Delete.Click += new System.EventHandler(this.btnDeleteClicked);
            // 
            // tb_SeatName
            // 
            this.tb_SeatName.Font = new System.Drawing.Font("넥슨Lv2고딕 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_SeatName.Location = new System.Drawing.Point(12, 10);
            this.tb_SeatName.Name = "tb_SeatName";
            this.tb_SeatName.Size = new System.Drawing.Size(230, 29);
            this.tb_SeatName.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(261, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseCustomBackColor = true;
            this.btn_Save.UseCustomForeColor = true;
            this.btn_Save.UseSelectable = true;
            this.btn_Save.UseStyleColors = true;
            this.btn_Save.Click += new System.EventHandler(this.btnSaveClicked);
            // 
            // tile_teacherTable
            // 
            this.tile_teacherTable.ActiveControl = null;
            this.tile_teacherTable.BackColor = System.Drawing.Color.SaddleBrown;
            this.tile_teacherTable.Cursor = System.Windows.Forms.Cursors.No;
            this.tile_teacherTable.Location = new System.Drawing.Point(261, 482);
            this.tile_teacherTable.Name = "tile_teacherTable";
            this.tile_teacherTable.Size = new System.Drawing.Size(130, 50);
            this.tile_teacherTable.TabIndex = 5;
            this.tile_teacherTable.TabStop = false;
            this.tile_teacherTable.Text = "교탁";
            this.tile_teacherTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_teacherTable.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_teacherTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tile_teacherTable.UseCustomBackColor = true;
            this.tile_teacherTable.UseSelectable = true;
            // 
            // grd_Items
            // 
            this.grd_Items.AllowUserToAddRows = false;
            this.grd_Items.AllowUserToDeleteRows = false;
            this.grd_Items.AllowUserToResizeColumns = false;
            this.grd_Items.AllowUserToResizeRows = false;
            this.grd_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Items.ColumnHeadersVisible = false;
            this.grd_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.image,
            this.text});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Items.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Items.EnableHeadersVisualStyles = false;
            this.grd_Items.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Items.Location = new System.Drawing.Point(3, 406);
            this.grd_Items.MultiSelect = false;
            this.grd_Items.Name = "grd_Items";
            this.grd_Items.ReadOnly = true;
            this.grd_Items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_Items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Items.RowTemplate.Height = 23;
            this.grd_Items.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Items.Size = new System.Drawing.Size(194, 196);
            this.grd_Items.TabIndex = 6;
            this.grd_Items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Items_CellDoubleClick);
            // 
            // index
            // 
            this.index.HeaderText = "Column1";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Visible = false;
            // 
            // image
            // 
            this.image.HeaderText = "아이콘";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // text
            // 
            this.text.HeaderText = "좌석";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // txt_People
            // 
            this.txt_People.AutoSize = true;
            this.txt_People.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_People.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txt_People.Location = new System.Drawing.Point(12, 46);
            this.txt_People.Name = "txt_People";
            this.txt_People.Size = new System.Drawing.Size(115, 25);
            this.txt_People.TabIndex = 15;
            this.txt_People.Text = "총 인원: n 명";
            // 
            // SeatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd_Items);
            this.Controls.Add(this.seatPanel);
            this.Controls.Add(this.list_ItemListView);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SeatControl";
            this.Size = new System.Drawing.Size(795, 608);
            this.seatPanel.ResumeLayout(false);
            this.seatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroListView list_ItemListView;
        private MetroFramework.Controls.MetroPanel seatPanel;
        private MetroFramework.Controls.MetroTile tile_teacherTable;
        private MetroFramework.Controls.MetroButton btn_Save;
        private System.Windows.Forms.TextBox tb_SeatName;
        private MetroFramework.Controls.MetroButton btn_Delete;
        private MetroFramework.Controls.MetroButton btn_Create;
        private MetroFramework.Controls.MetroButton btn_rowNegative;
        private MetroFramework.Controls.MetroButton btn_ColPositive;
        private MetroFramework.Controls.MetroButton btn_ColNegative;
        private MetroFramework.Controls.MetroButton btn_rowPositive;
        private MetroFramework.Controls.MetroGrid grd_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private MetroFramework.Controls.MetroLabel txt_People;
    }
}
