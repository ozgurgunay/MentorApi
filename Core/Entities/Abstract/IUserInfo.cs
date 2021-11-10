using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Abstract
{
    public interface IUserInfo
    {
        AppRoles AppRoles { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}
