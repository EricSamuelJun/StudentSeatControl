using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter {
    public partial class MainForm : MaterialForm {
        internal SeatControl seatControl;
        internal StudentControl studentControl;
        internal ShowFinalControl showFinalControl;

        private Size seatControlSize;
        private Size studentControlSize;
        private Size showFinalControlSize;

        private static readonly Color NAV_ACTIVE_COLOR = AppColors.NavActive;
        private static readonly Color NAV_DEFAULT_COLOR = AppColors.NavDefault;

        public List<StudentTable> students { get { return studentControl?.StudentBans; } }
        public List<Seat> seats { get { return seatControl?.seats; } }
        private const int DEFAULT_PANEL_WIDTH = 650;
        private const int DEFAULT_PANEL_HEIGHT = 600;

        // MaterialForm 크롬 오버헤드 (OnLoad에서 측정)
        private int _overheadW;
        private int _overheadH;

        public MainForm() {
            InitializeComponent();

            // MaterialSkin 테마 설정
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Indigo600, Primary.Indigo800, Primary.Indigo200,
                Accent.LightBlue400, TextShade.WHITE
            );

            seatControl = new SeatControl();
            studentControl = new StudentControl();
            showFinalControl = new ShowFinalControl();

            seatControlSize = seatControl.Size;
            studentControlSize = studentControl.Size;
            showFinalControlSize = showFinalControl.Size;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            // 폼이 완전히 레이아웃된 후 오버헤드 측정 (사이드바 + 타이틀바 + 테두리)
            _overheadW = this.Width - contentPanel.Width;
            _overheadH = this.Height - contentPanel.Height;
        }

        private void UpdateNavHighlight(Button activeBtn) {
            var navButtons = new[] { btnSeatManage, btnStudentManage, btnShowFinalManage, btnContact };
            foreach (var btn in navButtons) {
                btn.BackColor = NAV_DEFAULT_COLOR;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
            if (activeBtn != null) {
                activeBtn.BackColor = NAV_ACTIVE_COLOR;
                activeBtn.Font = new Font(activeBtn.Font, FontStyle.Bold);
            }
        }

        private void setContentPanel(Control content) {
            if (contentPanel.Controls.Count == 1 && contentPanel.Controls[0] == content) {
                contentPanel.Controls.Clear();
                ResizeFormToFitContent(new Size(DEFAULT_PANEL_WIDTH, DEFAULT_PANEL_HEIGHT));
                UpdateNavHighlight(null);
            } else {
                contentPanel.Controls.Clear();

                Size targetSize;
                if (content == seatControl) targetSize = seatControlSize;
                else if (content == studentControl) targetSize = studentControlSize;
                else if (content == showFinalControl) targetSize = showFinalControlSize;
                else targetSize = content.Size;

                content.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(content);

                ResizeFormToFitContent(targetSize);

                if (content == showFinalControl)
                    showFinalControl.OnFormCalled(students, seats);
            }
        }

        private void ResizeFormToFitContent(Size targetSize) {
            this.Size = new Size(targetSize.Width + _overheadW, targetSize.Height + _overheadH);
        }

        private void StudentControllClick(object sender, EventArgs e) {
            setContentPanel(studentControl);
            UpdateNavHighlight(btnStudentManage);
        }

        private void btnSeatOnClicked(object sender, EventArgs e) {
            setContentPanel(seatControl);
            UpdateNavHighlight(btnSeatManage);
        }

        private void btnShowOnClicked(object sender, EventArgs e) {
            setContentPanel(showFinalControl);
            UpdateNavHighlight(btnShowFinalManage);
        }

        private void btnContact_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://open.kakao.com/me/game_dev");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
