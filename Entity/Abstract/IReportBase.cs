using Core.Entities.Abstract;
using Entity.Concrete;

namespace Entity.Abstract
{
    public interface IReportBase : IBase, IEntity, IBaseEntity
    {
        string ReportName { get; set; }
        string UserID { get; set; }
   }
}
