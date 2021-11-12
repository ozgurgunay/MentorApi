using Core.Entities.Abstract;
using System;

namespace Entity.Abstract
{
    public interface INoteBase : IBase, IEntity, IBaseEntity
    {   
        string MainNote { get; set; }
        string NoteHidden { get; set; }
    
        Guid MeetingID { get; set; }
       // Meeting Meeting { get; set; }
    }
}
