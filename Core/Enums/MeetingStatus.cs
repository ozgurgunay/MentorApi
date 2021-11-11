using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Enums
{
    public enum MeetingStatus
    {
        [Display(Name = "Bekliyor")]
        Awaited = 1,
        [Display(Name = "Mentee Toplantı Talebi")]
        MenteeMeetingRequest,
        [Display(Name = "Oluşturuldu")]
        Created,
        [Display(Name = "Mentor Toplantı Yanıtı")]
        MentorMeetingResponse,
        [Display(Name = "Not Girişi Beklemede")]
        NoteEntryPending,
        [Display(Name = "Tamamlandı")]
        Done
    }
}
