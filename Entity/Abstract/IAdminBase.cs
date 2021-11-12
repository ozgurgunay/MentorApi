using Core.Entities.Abstract;
using Entity.Concrete;

namespace Entity.Abstract
{
    public interface IAdminBase : IBaseEntity
    {
        string UserID { get; set; }
        AppUser AppUser { get; set; }
    }
}
