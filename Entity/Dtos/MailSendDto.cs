using System.ComponentModel.DataAnnotations;

namespace Entity.Dtos
{
    public class MailSendDto
    {
        [Display(Name = "Konu")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Subject { get; set; }

        [Display(Name = "Gönderilen Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        public string To { get; set; }

        [Display(Name = "Gönderilecek Mail Adresi")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        public string FromEMail { get; set; }

        [Display(Name = "Açıklama")]
        [Required]
        public string Text { get; set; }
    }
}
