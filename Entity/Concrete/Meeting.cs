using Core.Enums;
using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Meeting : IMeetingBase
    {
        public Guid ID { get; set; }
        public DateTime? ActualDate { get; set; }

        private Status _status = Status.Active;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CreatedBy { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan MeetingStartClock { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan MeetingEndClock { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Url { get; set; }
        public MeetingPlatform MeetingPlatform { get; set; }
        public string MenteeID { get; set; }
        public virtual Mentee Mentee { get; set; }
        public string MentorID { get; set; }
        public virtual Mentor Mentor { get; set; }
        public Guid? NoteID { get; set; }
        public virtual Note Note { get; set; }
        public Guid ExpectedMeetingID { get; set; }
        public virtual ExpectedMeeting ExpectedMeeting { get; set; }
        public Guid MeetingRequestHistoryID { get; set; }
        public virtual MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
