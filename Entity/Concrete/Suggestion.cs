using Core.Entities.Abstract;
using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Suggestion : ISuggestionBase
    {
        public Guid ID { get; set; }
        public string Content { get; set; }
        public bool? Result { get; set; }
        public DateTime? ResultDate { get; set; }

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
            get
            { return _createdDate; }
            set { _createdDate = value; }
        }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string MenteeID { get; set; }
        public virtual Mentee Mentee { get; set; }
        public string MentorID { get; set; }
        public virtual Mentor Mentor { get; set; }
    }
}
