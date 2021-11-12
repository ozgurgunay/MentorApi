using Core.Entities.Abstract;
using Core.Enums;
using Entity.Concrete;
using System;

namespace Entity.Abstract
{
    public interface IMailBase : IBase, IEntity, IBaseEntity
    {
        string To { get; set; }
        string From { get; set; }
        DateTime Date { get; set; }
        string Text { get; set; }
        string Subject { get; set; }
        MailStatus MailStatus { get; set; }
        MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
