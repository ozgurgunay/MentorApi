using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Mail : IMailBase
    {
        public Guid ID { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
