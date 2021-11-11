using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Dtos
{
    /// <summary>
    /// Mentor-Mentee arasında düzenelenecek görüşme için iletilecek mail için gerekli dto.
    /// </summary>
    public class MailMeetingDto
    {
        [Display(Name = "Gönderilen Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string To { get; set; }

        [Display(Name = "Gönderilecek Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string From { get; set; }
        public string Url { get; set; }
        [Display(Name = "İçerik")]
        public string Text { get; set; }

        [Display(Name = "Konu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Subject { get; set; }
        public MailStatus MailStatus { get; set; }

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
        [Required]
        public DateTime Start { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsApproved { get; set; }
        public MeetingPlatform MeetingPlatform { get; set; }
    }
}
