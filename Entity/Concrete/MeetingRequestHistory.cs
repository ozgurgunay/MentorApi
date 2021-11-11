using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class MeetingRequestHistory : IMeetingRequestHistoryBase
    {
        public Guid ID { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public MeetingStatus MeetingStatus { get; set; }

        private Status _status = Status.Active;
        public Status Status
        { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get{ return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Guid MailID { get; set; }
        public Mail Mail { get; set; }
        public string MentorID { get; set; }
        public Mentor Mentor { get; set; }
        public string MenteeID { get; set; }
        public Mentee Mentee { get; set; }
        public Guid MeetingID { get; set; }
        public Meeting Meeting { get; set; }
    }

}
