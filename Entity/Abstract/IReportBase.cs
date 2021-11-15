using Core.Entities.Abstract;

namespace Entity.Abstract
{
    public interface IReportBase : IBase, IEntity, IBaseEntity
    {
        string ReportName { get; set; }
        string UserID { get; set; }
   }
}
