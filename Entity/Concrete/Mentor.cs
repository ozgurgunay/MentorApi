using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Mentor : IMentorBase
    {
        public Mentor()
        {
            Mentees = new HashSet<Mentee>();
            Meetings = new HashSet<Meeting>();
            Suggestions = new HashSet<Suggestion>();
            Questions = new HashSet<Question>();
        }

        [Display(Name = "Bölüm")]
        public string Department { get; set; }

        [Display(Name = "Pozisyon")]
        public string Position { get; set; }

        [Display(Name = "Uzmanlık Alanları")]
        public string Professions { get; set; }
        public short MaxMenteeNumber { get; set; }
        public string UserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid? EducationID { get; set; }
        public virtual Education Education { get; set; }
        public virtual ICollection<Mentee> Mentees { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
