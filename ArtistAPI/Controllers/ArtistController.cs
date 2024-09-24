using ArtistAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArtistAPI.Controllers {

	[ApiController]
	[Route("artists")]
	public class ArtistController : ControllerBase {
		private ArtistRepo _repo;
		private readonly ISpotifyClient _client;

		public ArtistController(ArtistRepo repo, ISpotifyClient spotifyClient) {
			_repo = repo;
			_client = spotifyClient;
		}


		[HttpGet("")]
		public ActionResult<List<Artist>> GetAllArtist() {
			return Ok(_repo.GetAllArtists());
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetArtist(string id) {
			try {
				SpotifyArtistDetails? artist = await _client.GetArtist(id);
				return Ok(artist);
			} catch (NotImplementedException) {
				return StatusCode(StatusCodes.Status500InternalServerError, "Not implemented");
			}
		}

		[HttpPost("")]
		public ActionResult CreateArtist(Artist artist) {
			if (ModelState.IsValid) {
				bool couldAdd = _repo.AddArtist(artist);
				if (couldAdd) return Ok();
			}

			return NotFound();
		}

		[HttpDelete("{id}")]
		public ActionResult DeleteArtist(string id) {
			bool couldRemove = _repo.RemoveArtist(id);
			if(couldRemove) return Ok(_repo.GetAllArtists());

			return NotFound();
		}
	}
}
