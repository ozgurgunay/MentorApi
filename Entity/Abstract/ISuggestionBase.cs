using Core.Entities.Abstract;
using Entity.Concrete;
using System;

namespace Entity.Abstract
{
    public interface ISuggestionBase : IBase,IEntity, IBaseEntity
    {
        string Content { get; set; }
        bool? Result { get; set; }
        DateTime? ResultDate { get; set; }
        string MenteeID { get; set; }
        Mentee Mentee { get; set; }
        string MentorID { get; set; }
        Mentor Mentor { get; set; }
    }
}
