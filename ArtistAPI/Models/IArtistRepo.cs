namespace ArtistAPI.Models {
	public interface IArtistRepo {

		public List<Artist> GetAllArtists();

		public Artist GetArtist(int id);

		public bool AddArtist(Artist artist);
	}
}
