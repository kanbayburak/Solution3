using Burak.OgrenciTakip.Model.Entities.Base;

namespace Burak.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool UpDate(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();
    }
}
