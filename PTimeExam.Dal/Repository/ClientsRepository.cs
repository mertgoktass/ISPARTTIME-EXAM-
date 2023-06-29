using FinalExam.Dal.Interfaces;
using FinalExam.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Dal.Repository
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly DataContext _ctx;
        public ClientsRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Clients> CreateClientsAsync(Clients Clients)
        {
            _ctx.Clients.Add(Clients);
            await _ctx.SaveChangesAsync();
            return Clients;
        }

        public async Task<Movies> CreateMoviesAsync(Movies Movies, int ClientsId)
        {
            var Clients = await _ctx.Clients.Include(c => c.Movies)
                .FirstOrDefaultAsync(c => c.Id == ClientsId);

            Clients.Movies.Add(Movies);

            await _ctx.SaveChangesAsync();
            return Movies;
        }

        public void DeleteClientsAsync(int ClientsId)
        {
            var Clients = _ctx.Clients.FirstOrDefault(a => a.Id == ClientsId);

            _ctx.Clients.Remove(Clients);
            _ctx.SaveChanges();
        }

        public void DeleteMovies(int ClientsId, int MoviesId)
        {
            var Movies = _ctx.Movies.FirstOrDefault(e => e.Id == MoviesId && e.ClientsId == ClientsId);

            _ctx.Movies.Remove(Movies);
            _ctx.SaveChanges();
        }

        public async Task<List<Movies>> GetAllMoviesAsync(int ClientsId)
        {
            return await _ctx.Movies.Where(c => c.ClientsId == ClientsId).ToListAsync();
        }

        public async Task<List<Clients>> GetClientsAsync()
        {
            return await _ctx.Clients.ToListAsync();
        }

        public async Task<Clients> GetClientsByIdAsync(int ClientsId)
        {
            var Clients = await _ctx.Clients.FirstOrDefaultAsync(c => c.Id == ClientsId);

            if (Clients == null)
                return null;

            return Clients;
        }

        public async Task<Movies> GetMoviesByIdAsync(int companyId, int MoviesId)
        {
            var Movies = await _ctx.Movies.FirstOrDefaultAsync(e => e.ClientsId == ClientsId && e.Id == eMoviesId);

            if (Movies == null)
                return null;

            return Movies;
        }

        public async Task<Clients> UpdateClientsAsync(Clients updatedClients)
        {
            _ctx.Clients.Update(updatedClients);
            await _ctx.SaveChangesAsync();

            return updatedClients;
        }

        public async Task<Movies> UpdateMoviesAsync(Movies updatedMovies, int ClientsId)
        {
            _ctx.Movies.Update(updatedMovies);
            await _ctx.SaveChangesAsync();

            return updatedMovies;
        }
    }
}
