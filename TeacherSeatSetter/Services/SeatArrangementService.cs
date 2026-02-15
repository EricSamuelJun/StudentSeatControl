using System;
using System.Collections.Generic;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Services {
    internal sealed class SeatArrangementService : ISeatArrangementService {
        public List<SeatRenderItem> BuildLayout(Seat seat, StudentTable studentTable, int maxRenderCount) {
            List<SeatRenderItem> items = new List<SeatRenderItem>();
            if (seat == null || studentTable == null || maxRenderCount <= 0) {
                return items;
            }

            int renderCount = Math.Min(seat.Count, maxRenderCount);
            for (int i = 0; i < renderCount; i++) {
                items.Add(new SeatRenderItem {
                    Location = seat.getPosition(i),
                    Student = i < studentTable.count ? studentTable[i] : null
                });
            }

            return items;
        }
    }
}
