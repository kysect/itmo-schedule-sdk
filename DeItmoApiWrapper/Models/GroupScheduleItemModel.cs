namespace DeItmoApiWrapper.Models
{
    public class GroupScheduleItemModel
    {
        public int DataDay { get; set; }
        public string Status { get; set; }
        public int DataWeek { get; set; }
        public string Group { get; set; }
        public string SubjectTime { get; set; }
        public int Sortp { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Teacher { get; set; }
        public int? Pid { get; set; }
        public int? BldId { get; set; }
        public int? CathedraBunId { get; set; }
        public int? FacultyBunId { get; set; }
        public int Course { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}