using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class ExpectedMeeting : IExpectedMeeting
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Toplantı Başlangıç Tarihi")]
        public byte MeetingStartDate { get; set; }

        [Display(Name = "Toplantı Bitiş Tarihi")]
        public byte MeetingEndDate { get; set; }
        public Guid TemplateID { get; set; }
        public virtual Template Template { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
