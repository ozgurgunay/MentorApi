﻿using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
    public interface IEducationProgramBase : IBase, IEntity, IBaseEntity
    {
        string Name { get; set; }
        string Location { get; set; }
        string Description { get; set; }
        ICollection<Education> Educations { get; set; }
    }
}
