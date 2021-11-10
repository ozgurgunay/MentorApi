using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class ExpectedMeeting : IExpectedMeeting
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public byte MeetingStartDate { get; set; }
        public byte MeetingEndDate { get; set; }
    }
}
