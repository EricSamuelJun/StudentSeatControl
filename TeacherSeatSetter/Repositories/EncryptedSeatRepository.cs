using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Repositories {
    internal sealed class EncryptedSeatRepository : ISeatRepository {
        public List<Seat> Load() {
            var data = FileManagement.manager.LoadFile("seats", true);
            if (data == null) {
                return new List<Seat>();
            }

            try {
                return JsonConvert.DeserializeObject<List<Seat>>((string)data) ?? new List<Seat>();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Seat load failed: " + ex.Message);
                return new List<Seat>();
            }
        }

        public void Save(List<Seat> seats) {
            FileManagement.manager.SaveFile("seats", seats ?? new List<Seat>(), true);
        }
    }
}
