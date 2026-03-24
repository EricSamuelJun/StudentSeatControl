using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Repositories {
    internal sealed class EncryptedArrangementRepository : IArrangementRepository {
        public List<ArrangementRecord> LoadAll() {
            var data = FileManagement.manager.LoadFile("arrangements", true);
            if (data == null) {
                return new List<ArrangementRecord>();
            }

            try {
                return JsonConvert.DeserializeObject<List<ArrangementRecord>>((string)data) ?? new List<ArrangementRecord>();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Arrangement load failed: " + ex.Message);
                return new List<ArrangementRecord>();
            }
        }

        public void Save(List<ArrangementRecord> records) {
            FileManagement.manager.SaveFile("arrangements", records ?? new List<ArrangementRecord>(), true);
        }
    }
}
