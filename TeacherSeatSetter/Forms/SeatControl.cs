using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSeatSetter.Objects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeacherSeatSetter {
    public partial class SeatControl : MetroFramework.Controls.MetroUserControl {
        public SeatControl() {
            InitializeComponent();
            FormInit();
        }
        public List<Seat> seats;
        public List<PictureBox> pictureBoxes;
        private Seat _selected;
        private Seat selectedSeat {
            get { return _selected; }
            set { setSeatPoints(value); _selected = value; }
        }

        private void setSeatPoints(Seat seat) {
            Console.WriteLine("좌석 세팅 시작");
            debugSeatVal(seat);
            if (seat == null) {
                foreach(PictureBox pictureBox in pictureBoxes) {
                    pictureBox.Visible = false;
                }
                return;
            }

            int seatcount = seat.Count;
            //없으면 만들고 있으면 위치조정
            for (int i =0; i< seatcount; i++) {
                PictureBox pic;

                if (pictureBoxes.Count > i)
                    pic = pictureBoxes[i];
                else {
                    pic = new PictureBox();
                    seatPanel.Controls.Add(pic);
                    pictureBoxes.Insert(i, pic);
                }
                //Console.WriteLine("좌석 [{0}] 세팅 시작",i);
                pic.Visible = true;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                switch (seat.seatType) {
                    case SeatType.OneSeat:
                        pic.Image = Properties.Resources.seat_1_noNum;
                        break;
                    case SeatType.TwoSeat:
                        pic.Image = Properties.Resources.seat_2_noNum;
                        break;
                    case SeatType.ThreeSeat:
                        pic.Image = Properties.Resources.seat_3_noNum;
                        break;
                    case SeatType.CircleSeat:
                        pic.Visible = false;
                        break;
                    case SeatType.None:
                        pic.Visible = false;
                        break;
                }
                pic.Location = seat.getPosition(i);
            }
            int picCount = (pictureBoxes == null ? 0 : pictureBoxes.Count);
            //만약 많으면 오브젝트 풀 처럼 쓰게 사용 불가 해놓자
            for(int i = seatcount; i< picCount; i++) {
                PictureBox pic = pictureBoxes[i];
                pic.Visible = false;
            }
        }
        
        private void FormInit() {
            //데이터 로드
            var data = FileManagement.manager.LoadFile("seats", true);
            try {
                seats = (data == null ? new List<Seat>() : (Newtonsoft.Json.JsonConvert.DeserializeObject<List<Seat>>((string)data)));
            } catch (Exception ex) {
                Console.WriteLine("Exception: " + ex.Message + "\n" + ex.StackTrace);
                seats = new List<Seat>();
            }

            Console.WriteLine("seats Count: " + seats.Count);
            pictureBoxes = new List<PictureBox>();
            selectedSeat = null;
            renewListofItems();
            //reloadNameList();
        }

        private void renewListofItems() {
            list_ItemListView.Clear();
            foreach (Seat seat in seats) {
                ListViewItem item = new ListViewItem();
                item.Text = seat.name;
                item.Tag = seat;
                list_ItemListView.Items.Add(item);
            }
        }

        private void btnCreateClicked(object sender, EventArgs e) {
            Seat newSeat = new Seat();
            tb_SeatName.Text = string.Empty;
            selectedSeat = newSeat;
            Console.WriteLine("새로 만듬");
            setSeatPoints(newSeat);
        }

        private void btnDeleteClicked(object sender, EventArgs e) {
            tb_SeatName.Text = string.Empty;
            if(selectedSeat == null) {
                return;
            }
            Console.WriteLine("삭제 구동");
            seats.Remove(selectedSeat);
            selectedSeat = null;
            renewListofItems();
        }
        private void btnSaveClicked(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tb_SeatName.Text)) {
                MessageBox.Show("좌석 명을 입력해주셔야 합니다!\n저장을 하지 못했습니다!");
                return;
            }
            if(selectedSeat == null) {
                MessageBox.Show("선택된 자석이 없습니다!\n저장을 하지 못했습니다!");
                return;
            }
            Console.WriteLine("저장 시작");
            //새로만든 좌석이거나, 수정된 좌석이거나
            //새로만든 좌석이다
            if (!seats.Contains(selectedSeat)) {
                Console.WriteLine("신규 좌석");
                selectedSeat.name = tb_SeatName.Text;
                seats.Add(selectedSeat);
            }
            //수정된 좌석은 어차피 자동 체인지인데 뭐... 이름만 바꾸지
            else {
                Console.WriteLine("수정 좌석");
                selectedSeat.name = tb_SeatName.Text;
            }

            renewListofItems();

        }

        protected override void OnHandleDestroyed(EventArgs e) {
            if (seats.Count == 0) {
                //return;
            }
            Console.WriteLine("DEBUG: " + seats.Count);
            FileManagement.manager.SaveFile("seats", seats, true);
            base.OnHandleDestroyed(e);
        }

        private void rowDown(object sender, EventArgs e) {
            if (selectedSeat.rowCount <= 0)
                return;
            Console.WriteLine("row --");
            selectedSeat.rowCount--;
            setSeatPoints(selectedSeat);
        }

        private void rowUp(object sender, EventArgs e) {
            if (selectedSeat.rowCount >= 6)
                return;
            Console.WriteLine("row ++");
            selectedSeat.rowCount++;
            setSeatPoints(selectedSeat);
        }

        private void colUp(object sender, EventArgs e) {
            if (selectedSeat.columnCount >= 6)
                return;
            Console.WriteLine("col ++");
            selectedSeat.columnCount++;
            setSeatPoints(selectedSeat);
        }

        private void colDown(object sender, EventArgs e) {
            if (selectedSeat.columnCount <= 0)
                return;
            Console.WriteLine("col --");
            selectedSeat.columnCount--;
            setSeatPoints(selectedSeat);
        }

        private void listItemChanged(object sender, EventArgs e) {
            if (list_ItemListView.SelectedItems.Count <= 0)
                return;
            selectedSeat = list_ItemListView.SelectedItems[0].Tag as Seat;
            if (selectedSeat != null)
                tb_SeatName.Text = selectedSeat.name;
            else
                return;
        }

        private void debugSeatVal(Seat seat) {
            if (seat == null)
                return;
            Console.WriteLine("Selected Seat:[{0}], row: {1}, col: {2}, Type: {3}", seat.name, seat.rowCount,seat.columnCount,seat.seatType.ToString());
        }
    }
}
