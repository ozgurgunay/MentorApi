using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Meeting : IMeetingBase
    {
        public Guid ID { get; set; }
        public DateTime? ActualDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
        public Guid? NoteID { get; set; }
        public string MenteeID { get; set; }
        public Mentee Mentee { get; set; }
        public string MentorID { get; set; }
        public Guid MeetingRequestHistoryID { get; set; }
        public MeetingRequestHistory MeetingRequestHistory { get; set; }
        public Guid ExpectedMeetingID { get; set; }
        public ExpectedMeeting ExpectedMeeting { get; set; }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate {  get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Note Note { get; set; }
        public Mentor Mentor { get; set; }
        //edit!
        Abstract.Mentee IMeetingBase.Mentee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
