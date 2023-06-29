using FinalExam.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Dal.Interfaces
{
    public interface IClientsRepository
    {
        Task<List<Clients>> GetClientsAsync();
        Task<Clients> GetClientsByIdAsync(int ClientsId);
        Task<Clients> CreateClientsAsync(Clients Clients);
        Task<Clients> UpdateClientsAsync(Clients updatedClients);
        void DeleteClientsAsync(int ClientsId);


        Task<List<Movies>> GetAllMoviesAsync(int ClientsId);
        Task<Movies> GetMoviesByIdAsync(int ClientsId, int MoviesId);
        Task<Movies> CreateMoviesAsync(Movies Movies, int ClientsId);
        Task<Movies> UpdateMoviesAsync(Movies updatedMovies, int ClientsId);
        void DeleteMovies(int ClientsId, int MoviesId);
    }
}
