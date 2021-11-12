using Entity.Concrete;
using System.Collections.Generic;

namespace BAMentorApp.DataAccess.EntityFramework.Abstract
{
    public interface IExpectedMeetingRepository : IRepository<ExpectedMeeting>
    {
        public List<ExpectedMeeting> GetExpectedMeetingsByMenteeId(string id);
    }
}
