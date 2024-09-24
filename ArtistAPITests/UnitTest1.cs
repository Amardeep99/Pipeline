using ArtistAPI.Controllers;
using ArtistAPI.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ArtistAPITests {
	public class UnitTest1 {

		private WebApplicationFactory<Program> _factory;


		[Fact]
		public void GetAllAlbums_ReturnsCorrectAmount() {
			//Arrange
			ArtistController controller = new ArtistController(null, null);
			var client = _factory.CreateClient();

			//Act
			var expected = controller.GetAllArtist();

			//Assert
			//Assert.True(response.count == expected);
		}
	}
}