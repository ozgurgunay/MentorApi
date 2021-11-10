using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class MeetingRequestHistory : IMeetingRequestHistoryBase
    {
        public DateTime RequestDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ResponseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid MailID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Mail Mail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Mentee Mentee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MentorID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MenteeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid MeetingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Meeting Meeting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Status status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DeletedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
