using System;

namespace Core.Entities.Abstract
{
    public interface IDates
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
