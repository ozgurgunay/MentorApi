﻿using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Abstract
{
    public interface IBase
    {
        Status status { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string DeletedBy { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
