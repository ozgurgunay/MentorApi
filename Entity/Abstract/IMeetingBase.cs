using Core.Entities.Abstract;
using Entity.Concrete;
using System;

namespace Entity.Abstract
{
    public interface IMeetingBase : IBase, IEntity, IBaseEntity
    {
        DateTime? ActualDate { get; set; }
        Guid? NoteID { get; set; }
        Note Note { get; set; }
        string MenteeID { get; set; }
        Mentee Mentee { get; set; }
        string MentorID { get; set; }
        Mentor Mentor { get; set; }
        Guid MeetingRequestHistoryID { get; set; }
        MeetingRequestHistory MeetingRequestHistory { get; set; }
        Guid ExpectedMeetingID { get; set; }
        ExpectedMeeting ExpectedMeeting { get; set; }
    }
}
