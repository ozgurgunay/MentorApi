using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Enums
{
    public enum MeetingPlatform
    {
        [Display(Name = "Zoom Toplantısı")]
        Zoom,
        [Display(Name = "Google Toplantısı")]
        GoogleMeet,
        [Display(Name = "Teams Toplantısı")]
        TeamsMeeting,
        [Display(Name = "Diğer")]
        Diger
    }
}
