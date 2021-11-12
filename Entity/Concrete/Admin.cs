using Entity.Abstract;

namespace Entity.Concrete
{
    public class Admin : IAdminBase
    {
        public string UserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
