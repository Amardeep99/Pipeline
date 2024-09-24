namespace ArtistAPI.Models {

	public class SpotifyClient : ISpotifyClient{
		private readonly HttpClient _client;
		public SpotifyClient(HttpClient client) { 
			_client = client;
		}

		public async Task<SpotifyArtistDetails> GetArtist(string id) {
			HttpResponseMessage? response = await _client.GetAsync($"/{id}");

			if(!response.IsSuccessStatusCode) throw new HttpRequestException("Could not get response");

			SpotifyArtistDetails? artist = await response.Content.ReadFromJsonAsync<SpotifyArtistDetails>();

			return artist;
		}
	}
}	
