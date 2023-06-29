using FinalExam.Service.Dtos;
using FinalExam.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly IClientsService _ClientsService;

        public CClientsController(IClientsService ClientsService)
        {
            _ClientsService = ClientsService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllClients()
        {
            var Clients = await _ClientsService.GetClientsAsync();
            return Ok(Clients);
        }
        [HttpGet]
        [Route("{ClientsyId}")]
        public async Task<IActionResult> GetClientsId(int id)
        {

            var Clients = await _ClientsService.GetClientsByIdAsync(id);
            if (Clients == null)
                return NotFound("Item not found");

            return Ok(Clients);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClients([FromBody] ClientsPostPutDto Clients)
        {

            if (Clients == null)
                return BadRequest(ModelState);

            var ClientsPost = await _ClientsService.CreateClientsAsync(Clients);

            return CreatedAtAction(nameof(CreateClients), new { id = ClientsPost.Id }, ClientsPost);
        }

        [HttpPut]
        [Route("{ClientsId}")]
        public async Task<IActionResult> UpdateClients([FromBody] ClientsPostPutDto updatedClients, int id)
        {


            var update = await _ClientsService.UpdateClientsAsync(updatedClients, id);

            return NoContent();
        }

        [HttpDelete]
        [Route("{ClientsId}")]
        public void DeleteClients(int id)
        {

            _companyClients.DeleteClientsAsync(id);
        }

        [HttpGet]
        [Route("{ClientsId}/movies")]
        public async Task<IActionResult> GetAllmovies(int ClientsId)
        {
            var movies = await _ClientsService.GetAllmoviesAsync(ClientsId);

            return Ok(movies);
        }

        [HttpGet]
        [Route("{clientsId}/movies/{moviesId}")]
        public async Task<IActionResult> GetmoviesById(int ClientsId, int moviesId)
        {
            var movies = await _clientsService.GetmoviesByIdAsync(ClientsId, moviesId);
            if (movies == null)
                return NotFound("movies not found");

            return Ok(movies);
        }

        [HttpPost]
        [Route("{clientsId}/movies")]
        public async Task<IActionResult> Createmovies([FromBody] MoviesPostPutDto newmovies, int clientsId)
        {
            if (newmovies == null)
                return BadRequest(ModelState);


            var movies = await _clientsService.CreatemoviesAsync(newmovies, clientsId);

            return CreatedAtAction(nameof(Createmovies),
                       new { clientsId = companyId, moviesId = movies.Id }, movies);
        }

        [HttpPut]
        [Route("{clientsId}/movies/{moviesId}")]
        public async Task<IActionResult> Updatemovies([FromBody] MoviesPostPutDto updatedmovies, int clientsId, int moviesId)
        {

            var update = await _clientsService.UpdatemoviesAsync(updatedmovies, clientsId, moviesId);

            return NoContent();
        }

        [HttpDelete]
        [Route("{clientsId}/movies/{moviesId}")]
        public void Deletemovies(int clientsId, int moviesId)
        {
            _clientsService.Deletemovies(clientsId, moviesId);
        }




    }
}
