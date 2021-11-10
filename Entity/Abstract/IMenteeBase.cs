using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Entity.Abstract
{
    public interface IMenteeBase : IBaseEntity
    {
        DateTime BirthDate { get; set; }
        string Interests { get; set; }
        string RecommendedArea { get; set; }
        string EducationalBackground { get; set; }

        string UserID { get; set; }
        AppUser AppUser { get; set; }
        string MentorID { get; set; }
        Mentor OwnMentor { get; set; }
        Guid? EducationID { get; set; }
        //Education Education { get; set; }
        ICollection<Question> Questions { get; set; }
        //ICollection<Meeting> Meetings { get; set; }
        ICollection<Suggestion> Suggestions { get; set; }
       // MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
