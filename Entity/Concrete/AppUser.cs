﻿using Core.Entities.Abstract;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class AppUser : IBase, IUserInfo
    {
        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public AppRoles AppRoles { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Admin Admin { get; set; }

    }
}
