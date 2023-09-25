using sftlareWebEx.Data.Base;
using sftlareWebEx.Data.ViewModels;
using sftlareWebEx.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace sftlareWebEx.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateNewMovieAsync(NewMovieVM data);

        Task<List<string>> GetReservedSeatsForMovieAsync(int movieId);

    }
}
