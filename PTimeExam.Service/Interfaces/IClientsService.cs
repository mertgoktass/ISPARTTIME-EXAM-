using FinalExam.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Service.Interfaces
{
    public interface IClientsService
    {
        Task<List<ClientsGetDto>> GetClientsAsync();
        Task<ClientsGetDto> GetClientsByIdAsync(int clientsId);
        Task<ClientsGetDto> CreateClientsAsync(ClientsPostPutDto clients);
        Task<ClientsGetDto> UpdateClientsAsync(ClientsPostPutDto updatedClients, int id);
        void DeleteClientsAsync(int clientsId);

        
        Task<List<MoviesGetDto>> GetAllMoviesAsync(int clientsId);
        Task<MoviesGetDto> GetMoviesByIdAsync(int clientsId, int moviesId);
        Task<MoviesGetDto> CreateMoviesAsync(MoviesPostPutDto newmovies, int clientsId);
        Task<MoviesGetDto> UpdateMoviesAsync(MoviesPostPutDto updatedmovies, int clientsId, int MoviesId);
        void DeleteMovies(int clientsId, int moviesId);
    }
}
