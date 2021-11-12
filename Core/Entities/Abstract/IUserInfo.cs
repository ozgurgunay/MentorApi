using Core.Enums;

namespace Core.Entities.Abstract
{
    public interface IUserInfo
    {
        AppRoles AppRoles { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}
