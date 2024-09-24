namespace ArtistAPI.Models {
	public class ArtistRepo : IArtistRepo {
		private List<Artist> _artists = new List<Artist>() {
			{ new Artist("711MCceyCBcFnzjGY4Q7Un", "AC/DC") },
			{ new Artist("3fMbdgg4jU18AjLCKBhRSm", "Micael Jackson") },
			{ new Artist("1OTNNdgU6qLUTCwvJxcObX", "Knutsen & Ludvigsen") },
			{ new Artist("12Chz98pHFMPJEknJQMWvI", "Muse") },
			{ new Artist("4TrraAsitQKl821DQY42cZ", "Sigrid") },
		};



		public List<Artist> GetAllArtists() => _artists;

		public Artist GetArtist(int id) => _artists[id];

		public bool AddArtist(Artist artist) {
			Artist? findArtist = _artists.FirstOrDefault(a => a.Id == artist.Id);

			if (findArtist == null) {
				_artists.Add(artist);
				return true;
			}

			return false;
		}

		public bool RemoveArtist(string id) {
			Artist? artist = _artists.FirstOrDefault(a => a.Id == id);

			if (artist != null) {
				_artists.Remove(artist);
				return true;
			}

			return false;
		}
	}

}
