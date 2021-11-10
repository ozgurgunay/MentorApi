using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Abstract
{
    public interface IDates
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
