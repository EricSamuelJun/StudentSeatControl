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
            this.list_ItemListView = new MetroFramework.Controls.MetroListView();
            this.seatPanel = new MetroFramework.Controls.MetroPanel();
            this.btn_rowNegative = new MetroFramework.Controls.MetroButton();
            this.btn_Create = new MetroFramework.Controls.MetroButton();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.tb_SeatName = new System.Windows.Forms.TextBox();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.tile_teacherTable = new MetroFramework.Controls.MetroTile();
            this.btn_rowPositive = new MetroFramework.Controls.MetroButton();
            this.btn_ColNegative = new MetroFramework.Controls.MetroButton();
            this.btn_ColPositive = new MetroFramework.Controls.MetroButton();
            this.seatPanel.SuspendLayout();
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
            this.seatPanel.Size = new System.Drawing.Size(595, 660);
            this.seatPanel.TabIndex = 5;
            this.seatPanel.VerticalScrollbarBarColor = true;
            this.seatPanel.VerticalScrollbarHighlightOnWheel = false;
            this.seatPanel.VerticalScrollbarSize = 10;
            // 
            // btn_rowNegative
            // 
            this.btn_rowNegative.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_rowNegative.Location = new System.Drawing.Point(3, 593);
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
            this.tile_teacherTable.Location = new System.Drawing.Point(232, 538);
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
            // btn_rowPositive
            // 
            this.btn_rowPositive.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_rowPositive.Location = new System.Drawing.Point(84, 593);
            this.btn_rowPositive.Name = "btn_rowPositive";
            this.btn_rowPositive.Size = new System.Drawing.Size(75, 64);
            this.btn_rowPositive.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_rowPositive.TabIndex = 12;
            this.btn_rowPositive.Text = "▶";
            this.btn_rowPositive.UseSelectable = true;
            this.btn_rowPositive.Click += new System.EventHandler(this.rowUp);
            // 
            // btn_ColNegative
            // 
            this.btn_ColNegative.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_ColNegative.Location = new System.Drawing.Point(512, 593);
            this.btn_ColNegative.Name = "btn_ColNegative";
            this.btn_ColNegative.Size = new System.Drawing.Size(75, 64);
            this.btn_ColNegative.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_ColNegative.TabIndex = 13;
            this.btn_ColNegative.Text = "▼";
            this.btn_ColNegative.UseSelectable = true;
            this.btn_ColNegative.Click += new System.EventHandler(this.colDown);
            // 
            // btn_ColPositive
            // 
            this.btn_ColPositive.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_ColPositive.Location = new System.Drawing.Point(512, 523);
            this.btn_ColPositive.Name = "btn_ColPositive";
            this.btn_ColPositive.Size = new System.Drawing.Size(75, 64);
            this.btn_ColPositive.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_ColPositive.TabIndex = 14;
            this.btn_ColPositive.Text = "▲";
            this.btn_ColPositive.UseSelectable = true;
            this.btn_ColPositive.Click += new System.EventHandler(this.colUp);
            // 
            // SeatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seatPanel);
            this.Controls.Add(this.list_ItemListView);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SeatControl";
            this.Size = new System.Drawing.Size(795, 660);
            this.seatPanel.ResumeLayout(false);
            this.seatPanel.PerformLayout();
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
    }
}
