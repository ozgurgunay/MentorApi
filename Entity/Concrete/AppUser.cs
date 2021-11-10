using Core.Entities.Abstract;
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
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DeletedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AppRoles AppRoles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
    }
}
