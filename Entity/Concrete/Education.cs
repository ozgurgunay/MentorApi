using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Education : IEducationBase
    {
        public Education()
        {
            
        }
        public Guid ID { get; set; }
        public string Name { get; set; }

        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EducationSchedules EducationSchedules { get; set; }
        public Guid EducationProgramID { get; set; }
        public EducationProgram EducationProgram { get; set; }
        public Guid TemplateID { get; set; }
        public Template Template { get; set; }
        public Status Status { get; set; }
    }
}
