using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeacherSeatSetter.MVP.Presenters;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Repositories;

namespace TeacherSeatSetter {
    public partial class SeatControl : MetroFramework.Controls.MetroUserControl, ISeatManagementView {
        private readonly Size oneSeatSize = new Size(50, 50);
        private readonly Size twoSeatSize = new Size(80, 40);
        private readonly Size threeSeatSize = new Size(75, 25);
        private readonly SeatManagementPresenter _presenter;

        public List<Seat> seats => _presenter.Seats;
        public List<PictureBox> pictureBoxes;
        private Seat _selected;
        private Seat selectedSeat {
            get { return _selected; }
            set {
                _selected = value;
                setSeatPoints(value);
            }
        }

        public SeatControl() {
            InitializeComponent();
            _presenter = new SeatManagementPresenter(this, new EncryptedSeatRepository());
            FormInit();
        }

        private void setSeatPoints(Seat seat) {
            if (seat == null) {
                foreach (PictureBox pictureBox in pictureBoxes) {
                    pictureBox.Visible = false;
                }
                txt_People.Text = "Total students: 0";
                return;
            }

            int seatcount = seat.Count;
            for (int i = 0; i < seatcount; i++) {
                PictureBox pic;
                if (pictureBoxes.Count > i) {
                    pic = pictureBoxes[i];
                } else {
                    pic = new PictureBox();
                    seatPanel.Controls.Add(pic);
                    pictureBoxes.Insert(i, pic);
                }

                pic.Visible = true;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                switch (seat.seatType) {
                    case SeatType.OneSeat:
                        pic.Image = Properties.Resources.seat_1_noNum;
                        pic.Size = oneSeatSize;
                        break;
                    case SeatType.TwoSeat:
                        pic.Image = Properties.Resources.seat_2_noNum;
                        pic.Size = twoSeatSize;
                        break;
                    case SeatType.ThreeSeat:
                        pic.Image = Properties.Resources.seat_3_noNum;
                        pic.Size = threeSeatSize;
                        break;
                    default:
                        pic.Visible = false;
                        break;
                }

                pic.Location = seat.getPosition(i);
            }

            for (int i = seatcount; i < pictureBoxes.Count; i++) {
                pictureBoxes[i].Visible = false;
            }

            txt_People.Text = "Total students: " + seat.Count * Convert.ToInt32(seat.seatType);
        }

        private void FormInit() {
            pictureBoxes = new List<PictureBox>();
            selectedSeat = null;
            _presenter.Initialize();

            grd_Items.Rows.Add(1, Properties.Resources.seat_1, "Seat 1");
            grd_Items.Rows.Add(2, Properties.Resources.seat_2, "Seat 2");
            grd_Items.Rows.Add(3, Properties.Resources.seat_3, "Seat 3");
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

        private void grd_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            _presenter.SetSeatTypeByIndex(e.RowIndex);
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
