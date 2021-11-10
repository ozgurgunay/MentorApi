using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Abstract
{
    public interface IEntity
    {
        public Guid ID { get; set; }
    }
}
