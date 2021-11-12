using Core.Entities.Abstract;

namespace Entity.Abstract
{
    public interface ITemplateBase : IBase, IEntity, IBaseEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        int EducationDayCount { get; set; }
        int PlannedMeetingCount { get; set; }
       // ICollection<Education> Educations { get; set; }
       // ICollection<ExpectedMeeting> ExpectedMeetings { get; set; }
    }
}
