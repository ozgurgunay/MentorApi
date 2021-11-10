using Core.Entities.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
    public interface IAdminBase : IBaseEntity
    {
        string UserID { get; set; }
        AppUser AppUser { get; set; }
    }
}
