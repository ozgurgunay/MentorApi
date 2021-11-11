using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
    public class MentorsAndMenteesDto
    {
        public Guid MentorID { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }
        public string MentorEMail { get; set; }
        public Guid MenteeID { get; set; }
        public string MenteeFirstName { get; set; }
        public string MenteeLastName { get; set; }
        public string MenteeEMail { get; set; }
    }
}
