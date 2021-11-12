using Core.Enums;
using Entity.Abstract;
using System;

namespace Entity.Concrete
{
    public class Question : IQuestionBase
    {
        public Guid ID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswer { get; set; }
        public Status Status { get; set; }
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
        public string MenteeID { get; set; }
        public virtual Mentee Mentee { get; set; }
        public string MentorID { get; set; }
        public virtual Mentor Mentor { get; set; }
    }
}
