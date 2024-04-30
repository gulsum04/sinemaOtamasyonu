using sinemaOtamasyonu.Data.Base;
using sinemaOtamasyonu.Models;

namespace sinemaOtamasyonu.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
