using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
    public interface IMailBase : IBase, IEntity, IBaseEntity
    {
        string To { get; set; }
        string From { get; set; }
        DateTime Date { get; set; }
        string Text { get; set; }
        string Subject { get; set; }
        //MailStatus MailStatus { get; set; }
        MeetingRequestHistory MeetingRequestHistory { get; set; }
    }
}
