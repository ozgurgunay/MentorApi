using Core.Entities.Abstract;
using Core.Enums;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Entity.Abstract
{
    public interface IEducationBase : IBase, IEntity, IDates, IBaseEntity
    {
        string Name { get; set; }
        EducationSchedules EducationSchedules { get; set; }
        Guid EducationProgramID { get; set; }
        EducationProgram EducationProgram { get; set; }
        Guid TemplateID { get; set; }
        Template Template { get; set; }
        ICollection<Mentee> Mentees { get; set; }
        ICollection<Mentor> Mentors { get; set; }

    }
}
