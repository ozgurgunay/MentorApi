﻿using Core.Enums;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class EducationProgram : IEducationProgramBase
    {
        public EducationProgram()
        {

        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
