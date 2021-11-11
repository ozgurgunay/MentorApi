using Core.CustomValidation;
using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Template : ITemplateBase
    {
        public Template()
        {
           Educations = new HashSet<Education>();
           ExpectedMeetings = new HashSet<ExpectedMeeting>();
        }
        public Guid ID { get; set; }

        [Display(Name ="Şablon Adı"), Required(ErrorMessage ="Lütfen şablon için bir ad giriniz!")]
        public string Name { get; set; }

        [Display(Name = "Açıklama"), Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }

        [Display(Name ="Eğitim Gün Sayısı"), Required(ErrorMessage = "Lütfen eğitim gün sayısını giriniz!")]
        [NegativeNumberCheck]
        public int EducationDayCount { get; set; }

        [Display(Name ="Planlanan Görüşme Sayısı"), Required(ErrorMessage = "Lütfen planlanan görüşme sayısını giriniz!")]
        [NegativeNumberCheck]
        public int PlannedMeetingCount { get; set; }

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
        public virtual ICollection<ExpectedMeeting> ExpectedMeetings { get; set; }
    }
}
