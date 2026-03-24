using System;
using System.Drawing;

namespace TeacherSeatSetter.Objects {
    public class Seat {
        // ShowFinalControl의 contentPanel 기본 크기
        private const int DEFAULT_PANEL_WIDTH = 728;
        private const int DEFAULT_PANEL_HEIGHT = 607;
        private const int CHAIR_SIZE = 50;
        private const int PADDING = 15;
        private const int TEACHER_TABLE_HEIGHT = 70;

        public SeatType seatType;
        public string name;
        public int rowCount;
        public int columnCount;
        public int Count {
            get { return (rowCount * columnCount); }
        }

        /// <summary>총 학생 수 (Count × seatType)</summary>
        public int TotalStudents {
            get { return Count * Math.Max((int)seatType, 1); }
        }

        /// <summary>학생 인덱스 → 화면 좌표 (기본 패널 크기 사용)</summary>
        public Point getStudentPosition(int studentIndex) {
            return getStudentPosition(studentIndex, DEFAULT_PANEL_WIDTH, DEFAULT_PANEL_HEIGHT);
        }

        /// <summary>학생 인덱스 → 화면 좌표 (패널 크기 지정)</summary>
        public Point getStudentPosition(int studentIndex, int panelWidth, int panelHeight) {
            int seatTypeInt = Math.Max((int)seatType, 1);
            int deskIndex = studentIndex / seatTypeInt;
            int slotIndex = studentIndex % seatTypeInt;

            Point deskPos = getPosition(deskIndex, panelWidth, panelHeight);

            if (seatTypeInt == 1) return deskPos;

            int chairW = GetChairWidth();
            int slotOffset = slotIndex * (chairW + 2);

            return new Point(deskPos.X + slotOffset, deskPos.Y);
        }

        /// <summary>seatType에 따른 개별 체어 너비</summary>
        public int GetChairWidth() {
            switch (seatType) {
                case SeatType.TwoSeat: return 40;
                case SeatType.ThreeSeat: return 30;
                default: return CHAIR_SIZE;
            }
        }

        /// <summary>체어 높이 (모든 타입 동일)</summary>
        public int GetChairHeight() {
            return CHAIR_SIZE;
        }

        public override string ToString() {
            return this.name;
        }

        public Seat() {
            seatType = SeatType.OneSeat;
            name = string.Empty;
            rowCount = 1;
            columnCount = 1;
        }

        /// <summary>책상 인덱스 → 좌표 (기본 패널 크기)</summary>
        public Point getPosition(int index) {
            return getPosition(index % rowCount, index / rowCount, DEFAULT_PANEL_WIDTH, DEFAULT_PANEL_HEIGHT);
        }

        /// <summary>책상 인덱스 → 좌표 (패널 크기 지정)</summary>
        public Point getPosition(int index, int panelWidth, int panelHeight) {
            return getPosition(index % rowCount, index / rowCount, panelWidth, panelHeight);
        }

        public Point getPosition(int xIndex, int yIndex) {
            return getPosition(xIndex, yIndex, DEFAULT_PANEL_WIDTH, DEFAULT_PANEL_HEIGHT);
        }

        public Point getPosition(int xIndex, int yIndex, int panelWidth, int panelHeight) {
            if (xIndex < 0 || xIndex >= rowCount)
                throw new IndexOutOfRangeException("row 이상의 data에 접근하기 시작했습니다.");
            if (yIndex < 0 || yIndex >= columnCount)
                throw new IndexOutOfRangeException("column 이상의 data에 접근하기 시작했습니다.");

            int seatTypeInt = Math.Max((int)seatType, 1);
            int chairW = GetChairWidth();
            int deskWidth = chairW * seatTypeInt + (seatTypeInt - 1) * 2;

            int availableWidth = panelWidth - 2 * PADDING;
            int availableHeight = panelHeight - TEACHER_TABLE_HEIGHT - 2 * PADDING;

            int spacingX = availableWidth / rowCount;
            int spacingY = availableHeight / columnCount;

            int xval = PADDING + spacingX * xIndex + (spacingX - deskWidth) / 2;
            int yval = PADDING + availableHeight - spacingY * (yIndex + 1) + (spacingY - CHAIR_SIZE) / 2;

            return new Point(xval, yval);
        }
    }

    public enum SeatType {
        None = 0, OneSeat = 1, TwoSeat = 2, ThreeSeat = 3, CircleSeat = -1,
    }
}
