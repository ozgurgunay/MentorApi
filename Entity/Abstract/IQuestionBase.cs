using Core.Entities.Abstract;
using Entity.Concrete;

namespace Entity.Abstract
{
    public interface IQuestionBase : IBase, IEntity, IBaseEntity
    {
        string QuestionText { get; set; }
        string QuestionAnswer { get; set; }

        string MenteeID { get; set; }
        Mentee Mentee { get; set; }
        string MentorID { get; set; }
        Mentor Mentor { get; set; }
    }
}
