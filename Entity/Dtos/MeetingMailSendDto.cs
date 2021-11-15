using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Dtos
{
    public class MeetingMailSendDto
    {
        [Display(Name = "Gönderilen Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string To { get; set; }
        [Display(Name = "Konu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Subject { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Toplantı Başlangıç Saati")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public TimeSpan MeetingStartClock { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Toplantı Bitiş Saati")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public TimeSpan MeetingEndClock { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Toplantı Başlangıç Tarihi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public DateTime Start { get; set; }
        public string Description { get; set; }
        public DateTime End { get; set; }

        [Display(Name = "Gönderilecek Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string FromEMail { get; set; }
    }
}
