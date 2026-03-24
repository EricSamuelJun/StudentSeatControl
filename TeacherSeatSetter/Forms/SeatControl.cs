using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.MVP.Presenters;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Repositories;

namespace TeacherSeatSetter {
    public partial class SeatControl : UserControl, ISeatManagementView {
        private readonly SeatManagementPresenter _presenter;

        private readonly Button[] _seatTypeButtons;

        public List<Seat> seats => _presenter.Seats;
        private readonly List<Chair> _previewChairs = new List<Chair>();
        // 하위호환: pictureBoxes 참조가 남아있을 수 있으므로 유지
        public List<PictureBox> pictureBoxes;
        private Seat _selected;
        private Seat selectedSeat {
            get { return _selected; }
            set {
                _selected = value;
                setSeatPoints(value);
                UpdateInfoLabels(value);
                UpdateSeatTypeHighlight(value);
            }
        }

        public SeatControl() {
            InitializeComponent();
            _seatTypeButtons = new[] { btnOneSeat, btnTwoSeat, btnThreeSeat };
            _presenter = new SeatManagementPresenter(this, new EncryptedSeatRepository());
            FormInit();
        }

        private void setSeatPoints(Seat seat) {
            // 기존 미리보기 체어 제거
            foreach (Chair ch in _previewChairs) {
                seatPanel.Controls.Remove(ch);
                ch.Dispose();
            }
            _previewChairs.Clear();

            if (seat == null) {
                txt_People.Text = "총 학생수: 0";
                return;
            }

            int totalSlots = seat.TotalStudents;
            int chairW = seat.GetChairWidth();
            int chairH = seat.GetChairHeight();

            seatPanel.SuspendLayout();
            for (int i = 0; i < totalSlots; i++) {
                Chair chair = new Chair((i + 1).ToString());
                chair.Size = new Size(chairW, chairH);
                chair.Location = seat.getStudentPosition(i, seatPanel.Width, seatPanel.Height);
                chair.Enabled = false; // 미리보기 전용 (드래그 불가)
                _previewChairs.Add(chair);
                seatPanel.Controls.Add(chair);
            }
            seatPanel.ResumeLayout(true);

            txt_People.Text = "총 학생수:" + seat.TotalStudents;
        }

        private void UpdateInfoLabels(Seat seat) {
            if (seat == null) {
                lblRowCount.Text = "0";
                lblColCount.Text = "0";
                lblSeatCount.Text = "총 좌석: 0";
                lblCapacity.Text = "수용 인원: 0명";
                return;
            }

            lblRowCount.Text = seat.rowCount.ToString();
            lblColCount.Text = seat.columnCount.ToString();
            lblSeatCount.Text = $"총 좌석: {seat.Count}";

            int capacity = seat.Count * Convert.ToInt32(seat.seatType);
            string typeName = "";
            switch (seat.seatType) {
                case SeatType.OneSeat: typeName = "1인석"; break;
                case SeatType.TwoSeat: typeName = "2인석"; break;
                case SeatType.ThreeSeat: typeName = "3인석"; break;
            }
            lblCapacity.Text = $"수용 인원: {capacity}명 ({typeName})";
        }

        private void UpdateSeatTypeHighlight(Seat seat) {
            int activeIndex = -1;
            if (seat != null) {
                switch (seat.seatType) {
                    case SeatType.OneSeat: activeIndex = 0; break;
                    case SeatType.TwoSeat: activeIndex = 1; break;
                    case SeatType.ThreeSeat: activeIndex = 2; break;
                }
            }

            for (int i = 0; i < _seatTypeButtons.Length; i++) {
                if (i == activeIndex) {
                    _seatTypeButtons[i].BackColor = Color.FromArgb(66, 165, 245);
                    _seatTypeButtons[i].ForeColor = Color.White;
                    _seatTypeButtons[i].FlatAppearance.BorderColor = Color.FromArgb(66, 165, 245);
                } else {
                    _seatTypeButtons[i].BackColor = Color.White;
                    _seatTypeButtons[i].ForeColor = Color.FromArgb(33, 33, 33);
                    _seatTypeButtons[i].FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                }
            }
        }

        private void FormInit() {
            pictureBoxes = new List<PictureBox>(); // 하위호환
            selectedSeat = null;
            _presenter.Initialize();
        }

        private void btnCreateClicked(object sender, EventArgs e) {
            tb_SeatName.Text = string.Empty;
            _presenter.CreateNewSeat();
        }

        private void btnDeleteClicked(object sender, EventArgs e) {
            tb_SeatName.Text = string.Empty;
            _presenter.DeleteSelectedSeat();
        }

        private void btnSaveClicked(object sender, EventArgs e) {
            _presenter.SaveSelectedSeat(tb_SeatName.Text);
        }

        protected override void OnHandleDestroyed(EventArgs e) {
            _presenter.Save();
            base.OnHandleDestroyed(e);
        }

        private void rowDown(object sender, EventArgs e) {
            _presenter.DecreaseRow();
        }

        private void rowUp(object sender, EventArgs e) {
            _presenter.IncreaseRow();
        }

        private void colUp(object sender, EventArgs e) {
            _presenter.IncreaseColumn();
        }

        private void colDown(object sender, EventArgs e) {
            _presenter.DecreaseColumn();
        }

        private void listItemChanged(object sender, EventArgs e) {
            if (list_ItemListView.SelectedItems.Count <= 0) {
                return;
            }
            _presenter.SelectSeat(list_ItemListView.SelectedItems[0].Tag as Seat);
        }

        private void seatTypeButtonClicked(object sender, EventArgs e) {
            if (sender is Button btn && btn.Tag is int index) {
                _presenter.SetSeatTypeByIndex(index);
            }
        }

        public void BindSeatList(IEnumerable<Seat> seatsForBind) {
            list_ItemListView.Clear();
            if (seatsForBind == null) {
                return;
            }

            foreach (Seat seat in seatsForBind) {
                ListViewItem item = new ListViewItem {
                    Text = seat.name,
                    Tag = seat
                };
                list_ItemListView.Items.Add(item);
            }
        }

        public void UpdateSelectedSeat(Seat seat) {
            selectedSeat = seat;
            tb_SeatName.Text = seat?.name ?? string.Empty;
        }

        public void ShowInfo(string message) {
            MessageBox.Show(message);
        }

        public void ShowError(string message) {
            MessageBox.Show(message);
        }
    }
}
