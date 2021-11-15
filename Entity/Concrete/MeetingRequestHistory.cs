using Core.Enums;
using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class MeetingRequestHistory : IMeetingRequestHistoryBase
    {
        public Guid ID { get; set; }

        [Display(Name = "Toplantı Talep Tarihi")]
        public DateTime RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }

        [Display(Name = "Toplantı Durumu")]
        public MeetingStatus MeetingStatus { get; set; }

        private Status _status = Status.Active;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CreatedBy { get; set; }

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
        public Guid MailID { get; set; }
        public virtual Mail Mail { get; set; }
        public string MentorID { get; set; }
        public virtual Mentor Mentor { get; set; }
        public string MenteeID { get; set; }
        public virtual Mentee Mentee { get; set; }
        public Guid MeetingID { get; set; }
        public virtual Meeting Meeting { get; set; }
    }

}
