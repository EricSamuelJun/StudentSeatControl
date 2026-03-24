using System;
using System.Collections.Generic;
using System.Linq;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Services {
    internal sealed class SeatArrangementService : ISeatArrangementService {
        private static readonly Random _random = new Random();

        public List<SeatRenderItem> BuildLayout(Seat seat, StudentTable studentTable) {
            List<SeatRenderItem> items = new List<SeatRenderItem>();
            if (seat == null || studentTable == null) {
                return items;
            }

            int totalSlots = seat.TotalStudents;
            for (int i = 0; i < totalSlots; i++) {
                items.Add(new SeatRenderItem {
                    Location = seat.getStudentPosition(i),
                    Student = i < studentTable.count ? studentTable[i] : null
                });
            }

            return items;
        }

        public List<SeatRenderItem> BuildRandomLayout(Seat seat, StudentTable studentTable, out int excessStudents, out int emptySeats) {
            excessStudents = 0;
            emptySeats = 0;
            List<SeatRenderItem> items = new List<SeatRenderItem>();
            if (seat == null || studentTable == null) {
                return items;
            }

            List<Student> shuffled = studentTable.students.ToList();
            for (int i = shuffled.Count - 1; i > 0; i--) {
                int j = _random.Next(i + 1);
                Student temp = shuffled[i];
                shuffled[i] = shuffled[j];
                shuffled[j] = temp;
            }

            int totalSlots = seat.TotalStudents;
            int studentCount = shuffled.Count;

            if (studentCount > totalSlots) {
                excessStudents = studentCount - totalSlots;
            } else if (totalSlots > studentCount) {
                emptySeats = totalSlots - studentCount;
            }

            for (int i = 0; i < totalSlots; i++) {
                items.Add(new SeatRenderItem {
                    Location = seat.getStudentPosition(i),
                    Student = i < studentCount ? shuffled[i] : null
                });
            }

            return items;
        }
    }
}
