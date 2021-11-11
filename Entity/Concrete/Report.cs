using Core.Enums;
using Entity.Abstract;
using Entity.Concrete;
using System;

namespace Entity.Concrete
{
    public class Report : IReportBase
    {
        public Guid ID { get; set; }
        public Status Status { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ReportName { get; set; }
        public string UserID { get; set; }
        public string CreatedBy { get; set; }
    }
}
