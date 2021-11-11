using Core.Entities.Abstract;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class AppUser : IBase, IUserInfo
    {
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
        public string CreatedBy { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public AppRoles AppRoles { get; set; }

        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual Mentee Mentee { get; set; }

    }
}
