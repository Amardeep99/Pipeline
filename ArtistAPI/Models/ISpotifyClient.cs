namespace ArtistAPI.Models {
	public interface ISpotifyClient {
		Task<SpotifyArtistDetails> GetArtist(string id);
	}
}
