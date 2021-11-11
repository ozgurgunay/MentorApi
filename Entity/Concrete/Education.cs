using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Education : IEducationBase
    {
        public Education()
        {
            Mentors = new HashSet<Mentor>();
            Mentees = new HashSet<Mentee>();
        }
        public Guid ID { get; set; }

        [Display(Name = "Ad"), Required(ErrorMessage = "İsim Boş geçilemez")]
        public string Name { get; set; }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        [Required(ErrorMessage = "Başlangıç Tarihi Boş Geçilemez.")]
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Bitiş Tarihi Boş Geçilemez.")]
        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Eğitim Günleri")]
        public EducationSchedules EducationSchedules { get; set; }
        public Guid EducationProgramID { get; set; }
        [Display(Name = "Eğitim Programı")]
        public virtual EducationProgram EducationProgram { get; set; }
        public Guid TemplateID { get; set; }
        [Display(Name = "Şablon")]
        public virtual Template Template { get; set; }
        public virtual ICollection<Mentee> Mentees { get; set; }
        public virtual ICollection<Mentor> Mentors { get; set; }
    }
}
