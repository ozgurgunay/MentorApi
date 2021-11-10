using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
    public interface IMeetingRequestHistoryBase : IBase, IEntity, IBaseEntity
    {
        DateTime RequestDate { get; set; }
        DateTime? ResponseDate { get; set; }
       // MeetingStatus MeetingStatus { get; set; }
        Guid MailID { get; set; }
        Mail Mail { get; set; }
        Mentee Mentee { get; set; }
        string MentorID { get; set; }
        //Mentor Mentor { get; set; }
        string MenteeID { get; set; }
        Guid MeetingID { get; set; }
        Meeting Meeting { get; set; }
    }
}
