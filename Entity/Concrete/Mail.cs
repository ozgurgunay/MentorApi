using Core.Enums;
using Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Mail : IMailBase
    {
        public Guid ID { get; set; }

        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
         ErrorMessage = "Invalid email format")]
        public string To { get; set; }

        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string From { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "İçerik")]
        public string Text { get; set; }

        [Display(Name = "Konu")]
        public string Subject { get; set; }
        public MailStatus MailStatus { get; set; }

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
        public virtual MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
