using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSeatSetter.Objects {
    public class Seat {
        public SeatType seatType;
        public string name;
        public int rowCount;
        public int columnCount;
        public int Count {
            get { return (rowCount * columnCount); }
        }
        public override string ToString() {
            return this.name;
        }
        public Seat() {
            seatType = SeatType.OneSeat;
            name = string.Empty;
            rowCount = 0;
            columnCount = 0;
        }
        public Point getPosition(int index) {
            return getPosition(index % rowCount, index / rowCount);
        }
        public Point getPosition(int xIndex,int yIndex) {
            if(xIndex< 0 || xIndex >= rowCount)
                throw new IndexOutOfRangeException("row 이상의 data에 접근하기 시작했습니다.");
            if(yIndex< 0 || yIndex >= columnCount)
                throw new IndexOutOfRangeException("column 이상의 data에 접근하기 시작했습니다.");
            //272,305 근데 이거 여기서 저장하는게 맞나?
            int xval = 0, yval = 0;
            switch (rowCount) {
                case 0:
                    xval = 0;
                    break;
                case 1:
                    xval = 272;
                    break;
                case 2:
                    xval = 172 + (200 * xIndex);
                    break;
                case 3:
                    xval = 122 + (155 * xIndex);
                    break;
                case 4:
                    xval = 90 + (130 * xIndex);
                    break;
                case 5:
                    xval = 90 + (90 * xIndex);
                    break;
                case 6:
                    xval = 55 + (90 * xIndex);
                    break;
            }
            switch (columnCount) {
                case 0:
                    yval = 0;
                    break;
                case 1:
                    yval = 305;
                    break;
                case 2:
                    yval = 410 - (210 * yIndex);
                    break;
                case 3:
                    yval = 410 - (105 * yIndex);
                    break;
                case 4:
                    yval = 460 - (90 * yIndex);
                    break;
                case 5:
                    yval = 460 - (72 * yIndex);
                    break;
                case 6:
                    yval = 460 - (60 * yIndex);
                    break;
            }
            return new Point(xval,yval);
        }

    }
    public enum SeatType {
        None, OneSeat,TwoSeat,ThreeSeat,CircleSeat,
    }
}
