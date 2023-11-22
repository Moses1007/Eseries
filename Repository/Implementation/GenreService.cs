using Eseries.Models.Domain;
using Eseries.Repository.Abstract;

namespace Eseries.Repository.Implementation
{
    public class GenreService : IGenre
    {
        private readonly DatabaseContext _databaseContext;
        public GenreService(DatabaseContext databaseContext)
        {

            _databaseContext = databaseContext;

        }
        public bool Add(Genre genre)
        {
            try
            {
                _databaseContext.Genre.Add(genre);
                _databaseContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = GetById(id);
                
                if( data == null )
                    return false;
                _databaseContext.Genre.Remove(data);
                _databaseContext.SaveChanges() ;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre GetById(int id)
        {
            return _databaseContext.Genre.Find(id);
        }

        public IQueryable<Genre> GetList()
        {
            var data = _databaseContext.Genre.AsQueryable();
            return data;
        }

        public bool Update(Genre genre)
        {
            try
            {
                _databaseContext.Genre.Update(genre);
                _databaseContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
