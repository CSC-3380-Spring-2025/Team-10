using System;
using System.Collections.Generic;
using System.Linq;

namespace StudySprout.DatabaseData
{
    public class StudyCalendarEdit
    {
        private List<StudyTime> _times = new();

        public List<StudyTime> GetAllTimes() => _times;

        public StudyTime? GetTime(int Id) => _times.FirstOrDefault(e => e.Id == Id);

        public void AddTime(StudyTime newTime)
        {
            newTime.Id = _times.Count > 0 ? _times.Max(e => e.Id) + 1 : 1;
            _times.Add(newTime);
        }

        public void UpdateTime(StudyTime updatedTime)
        {
            var existing = GetTime(updatedTime.Id);
            if (existing != null)
            {
                existing.Title = updatedTime.Title;
                existing.StartDate = updatedTime.StartDate;
                existing.EndDate = updatedTime.EndDate;
                existing.Description = updatedTime.Description;
            }
        }

        public void DeleteEvent(int id)
        {
            var ev = GetTime(id);
            if (ev != null)
            {
                _times.Remove(ev);
            }
        }

        public void AddSampleData()
        {
            AddTime(new StudyTime
            {
                Title = "CS Homework Due",
                StartDate = new DateTime(2021, 3, 1),
                EndDate = new DateTime(2021, 3, 1),
                Description = "Submit before 11:59PM"
            });
        }
    }
}
