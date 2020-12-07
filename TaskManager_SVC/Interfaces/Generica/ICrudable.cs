using System.Collections.Generic;

namespace TaskManager_SVC.Interfaces.Generica
{
    interface ICrudable<TEntity, TKey>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TKey id);
        void Post(TEntity reg);
        void Put(TKey id, TEntity reg);
        void Delete(TKey id);

    }
}
