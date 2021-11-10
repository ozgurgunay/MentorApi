using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Admin : IAdminBase
    {
        public string UserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
