using System.Collections.Generic;

namespace escola_api.Repositories
{
    public interface IRepository<TObject>
    {
        TObject Create(TObject entity);
        List<TObject> All();
    }
}