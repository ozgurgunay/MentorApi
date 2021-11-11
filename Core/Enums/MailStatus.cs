using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enums
{
    public enum MailStatus
    {
        MeetingRequest = 1,
        MeetingResponse,
        ApprovedMeeting,
        RejectedMeeting,
        MeetingReqestReminder,
        MeetingResponseReminder,
        MentorNoteReminder,
        MenteeNoteReminder,
        AdminMail
    }
}
