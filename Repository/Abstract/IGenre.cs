using Eseries.Models.Domain;

namespace Eseries.Repository.Abstract
{
    public interface IGenre
    {
        bool Add(Genre genre);
        bool Delete(int id);
        bool Update(Genre genre);
        Genre GetById(int id);  
        IQueryable<Genre> GetList();
    }
}
