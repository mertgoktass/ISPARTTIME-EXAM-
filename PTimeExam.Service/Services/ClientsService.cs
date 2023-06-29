using AutoMapper;
using FinalExam.Dal.Interfaces;
using FinalExam.Dal.Models;
using FinalExam.Service.Dtos;
using FinalExam.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Service.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        private readonly IMapper _mapper;

        public ClientsService(IClientsRepository clientsRepository, IMapper mapper)
        {
            _clientsRepository = clientsRepository;
            _mapper = mapper;
        }

        public async Task<ClientsGetDto> CreateClientsAsync(ClientsPostPutDto clients)
        {
            var domainClients = _mapper.Map<Clients>(clients);
            await _clientsRepository.CreateClientsAsync(domainClients);

            var mapped = _mapper.Map<ClientsGetDto>(domainClients);

            return mapped;
        }

        public async Task<MoviesGetDto> CreateMoviesAsync(MoviesPostPutDto newMovies, int clientsId)
        {
            var Movies = _mapper.Map<Movies>(newClients);
            await _clientsRepository.CreateMoviesAsync(Movies, clientsId);

            var mapped = _mapper.Map<MoviesGetDto>(movies);

            return mapped;
        }

        public void DeleteClientsAsync(int clientsId)
        {
            _clientsRepository.DeleteClientsAsync(clientsId);
            Console.WriteLine("Clients deleted");
        }

        public void DeleteMovies(int clientsId, int moviesId)
        {
            _clientsRepository.DeleteMovies(clientsid, MoviesId);
            Console.WriteLine("Movies deleted");
        }

        public async Task<List<MoviesGetDto>> GetAllmoviesAsync(int clientsId)
        {
            var movies = await _clientsRepository.GetAllmoviesAsync(clientsId);
            var mapped = _mapper.Map<List<MoviesGetDto>>(movies);

            return mapped;
        }

        public async Task<List<ClientsGetDto>> GetClientsAsync()
        {
            var clients = await _clientsRepository.GetClientsAsync();
            var mapped = _mapper.Map<List<ClientsGetDto>>(clients);

            return mapped;
        }

        public async Task<ClientsGetDto> GetClientsByIdAsync(int ClientsId)
        {
            var Clients = await _ClientsRepository.GetClientsByIdAsync(ClientsId);

            if (Clients == null)
                return null;

            var mapped = _mapper.Map<ClientsGetDto>(Clients);
            return mapped;
        }

        public async Task<MoviesGetDto> GetMoviesByIdAsync(int ClientsId, int MoviesId)
        {
            var Movies = await _ClientsRepository.GetMoviesByIdAsync(ClientsId, MoviesId);

            if (Movies == null)
                return null;

            var mapped = _mapper.Map<MoviesGetDto>(Movies);

            return mapped;
        }

        public async Task<ClientsGetDto> UpdateClientsAsync(ClientsPostPutDto updatedClients, int id)
        {
            var toUpdate = _mapper.Map<Clients>(updatedClients);
            toUpdate.Id = id;

            await _ClientsRepository.UpdateClientsAsync(toUpdate);

            var mapped = _mapper.Map<ClientsGetDto>(toUpdate);

            return mapped;
        }


        public async Task<MoviesGetDto> UpdateMoviesAsync(MoviesPostPutDto updatedMovies, int ClientsId, int MoviesId)
        {
            var toUpdate = _mapper.Map<Movies>(updatedMovies);
            toUpdate.Id = MoviesId;
            toUpdate.ClientsId = ClientsId;

            await _ClientsRepository.UpdateMoviesAsync(toUpdate, ClientsId);

            var mapped = _mapper.Map<MoviesGetDto>(toUpdate);

            return mapped;
        }
    }
}
