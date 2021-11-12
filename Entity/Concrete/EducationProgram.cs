using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class EducationProgram : IEducationProgramBase
    {
        public EducationProgram()
        {
            Educations = new HashSet<Education>();
        }
        public Guid ID { get; set; }

        [Display(Name = "Ad"), Required(ErrorMessage = "İsim Boş geçilemez")]
        public string Name { get; set; }

        [Display(Name = "Konum"), Required(ErrorMessage = "Konum Boş Geçilemez")]
        public string Location { get; set; }

        [Display(Name = "Açıklama"), Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }

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

        public virtual ICollection<Education> Educations { get; set; }
    }
}
