using Core.Enums;
using Entity.Abstract;
using System;

namespace Entity.Concrete
{
    public class Note : INoteBase
    {
        public Guid ID { get; set; }
        public string MainNote { get; set; }
        public string NoteHidden { get; set; }

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
        public AppRoles AppRoles { get; set; }
        public Guid MeetingID { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
