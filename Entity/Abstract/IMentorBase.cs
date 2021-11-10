using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Entity.Abstract
{
    public interface IMentorBase : IBaseEntity
    {
        string Department { get; set; }
        string Position { get; set; }
        string Professions { get; set; }
        short MaxMenteeNumber { get; set; }
        string UserID { get; set; }
        AppUser AppUser { get; set; }
        Guid? EducationID { get; set; }
        //Education Education { get; set; }
        ICollection<Mentee> Mentees { get; set; }
        //ICollection<Meeting> Meetings { get; set; }
        ICollection<Suggestion> Suggestions { get; set; }
        ICollection<Question> Questions { get; set; }
       // MeetingRequestHistory MeetingRequestHistory { get; set; }

    }
}
