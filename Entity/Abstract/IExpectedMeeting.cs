using Core.Entities.Abstract;
using Entity.Concrete;
using System;

namespace Entity.Abstract
{
    public interface IExpectedMeeting : IEntity, IBaseEntity
    {
        string Name { get; set; }
        byte MeetingStartDate { get; set; }
        byte MeetingEndDate { get; set; }
        Guid TemplateID { get; set; }
        Template Template { get; set; }
        Meeting Meeting { get; set; }
    }
}
