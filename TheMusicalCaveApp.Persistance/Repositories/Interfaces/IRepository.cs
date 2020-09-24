using System.Collections.Generic;
using TheMusicalCaveApp.Models.Entities;

namespace TheMusicalCaveApp.Persistance.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        IEnumerable<TEntity> GetAll();
    }
}
