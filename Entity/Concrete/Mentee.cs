using Core.CustomValidation;
using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Mentee : IMenteeBase
    {
        public Mentee()
        {
            Questions = new HashSet<Question>();
           // Meetings = new HashSet<Meeting>();
            Suggestions = new HashSet<Suggestion>();
        }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date, ErrorMessage = "Lütfen geçerli bir tarih giriniz.")]
        [BirthDateRange]
        public DateTime BirthDate { get; set; }

        [Display(Name = "İlgi Alanları")]
        public string Interests { get; set; }

        [Display(Name = "Tavsiye Edilen Alan")]
        public string RecommendedArea { get; set; }

        [Display(Name = "Eğitim geçmişi")]
        public string EducationalBackground { get; set; }


        public string UserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string MentorID { get; set; }
        public virtual Mentor OwnMentor { get; set; }
        public Guid? EducationID { get; set; }

        [Display(Name = "Eğitim")]
      //  public virtual Education Education { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
       // public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
       // public virtual MeetingRequestHistory MeetingRequestHistory { get; set; }

    }
}
